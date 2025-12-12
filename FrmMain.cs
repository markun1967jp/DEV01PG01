namespace DEV01PG01
{
    using System.Windows.Forms;

    public partial class FrmMain : Form
    {
        private ClsConvert clsCnv = new ClsConvert();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            // ファイルバージョン取得
            System.Diagnostics.FileVersionInfo sVer = System.Diagnostics.FileVersionInfo.GetVersionInfo(
                    System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text += "(v" + sVer.FileVersion + ")";

        }

        private void ClrTextTo()
        {
            txtTo.Text = "";
        }

        /// <summary>
        /// 置換する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTran_Click(object sender, EventArgs e)
        {
            clsCnv.Fn_Replace(txtFrom, txtTo, txtTranFrom.Text, txtTranTo.Text);

            MessageBox.Show("完了！", "置換", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// sSQL += " xxxx "; の形にする。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SQLVSソース化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsCnv.Fn_SQL_To_Code(txtFrom, txtTo, "sSQL += \"", "\";");

            MessageBox.Show("完了！", "SQLVSソース化", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 先頭1スペースToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsCnv.Fn_LeftOnepace(txtFrom, txtTo);

            MessageBox.Show("完了！", "先頭1スペース", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            txtFrom.Text = txtTo.Text;
            txtTo.Text = "";
        }

        private void btnCLR_Click(object sender, EventArgs e)
        {
            txtFrom.Text = "";
            txtTo.Text = "";
        }

        private void sQL句大文字化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsCnv.Fn_CapitalLetter(txtFrom, txtTo);

            MessageBox.Show("完了！", "SQL句、大文字化", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelAllUpper_Click(object sender, EventArgs e)
        {
            txtFrom.Focus();
            txtFrom.SelectAll();
        }

        private void btnSelAllBottom_Click(object sender, EventArgs e)
        {
            txtTo.Focus();
            txtTo.SelectAll();
        }

        private void 末尾ORANDONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsCnv.Fn_CheckEndLetter(txtFrom, txtTo);

            MessageBox.Show("完了！", "SQL句、末尾チェック", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 改行コード除去ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsCnv.RemoveCarrigeReturn(txtFrom, txtTo);

            MessageBox.Show("完了！", "S改行コード、除去", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mn仕切り線_Click(object sender, EventArgs e)
        {
            clsCnv.SeparateLine(txtFrom, txtTo);
            MessageBox.Show("完了！", "関数、仕切り線追加", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTo_KeyDown(object sender, KeyEventArgs e)
        {
            // Tab / Shift+Tab 以外はそのまま
            if (e.KeyCode != Keys.Tab) return;

            var tb = (TextBox)sender!;
            if (tb.SelectionLength == 0)
            {
                // 選択なし → 通常のタブ挿入だけ行う場合は以下の1行でOK
                // tb.SelectedText = "\t";
                // ただし自前で抑止しないなら AcceptsTab に任せてもよい
                return;
            }

            e.SuppressKeyPress = true; // 既定のタブ挿入を抑止

            // 選択開始・終了の文字インデックス
            int selStart = tb.SelectionStart;
            int selEnd = selStart + tb.SelectionLength;

            // 選択範囲の先頭・末尾が属する行番号
            int startLine = tb.GetLineFromCharIndex(selStart);
            int endLine = tb.GetLineFromCharIndex(selEnd);

            // 行頭のインデント対象は「選択開始行の先頭」から「選択末尾行の末尾」まで
            int lineStartIndex = tb.GetFirstCharIndexFromLine(startLine);

            // 選択末尾行の先頭インデックス（最終行の文字数を足して末尾位置）
            int lastLineFirstIndex = tb.GetFirstCharIndexFromLine(endLine);
            int lastLineLength = GetLineText(tb, endLine).Length;
            int lineEndIndex = lastLineFirstIndex + lastLineLength; // CRLFは含めない

            // 対象テキスト取得（必ず行単位で切り出す）
            string target = tb.Text.Substring(lineStartIndex, lineEndIndex - lineStartIndex);

            // 行分割（CRLF / CR / LF いずれにも対応）
            var lines = target.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.None);

            bool unindent = e.Shift;   // Shift+Tab はインデント解除
            string tab = "\t";         // もしスペースインデントにしたい場合は "    " などに変更

            int deltaTotal = 0;        // 文字数の増減合計（選択範囲の更新に使用）

            for (int i = 0; i < lines.Length; i++)
            {
                if (unindent)
                {
                    if (lines[i].StartsWith(tab))
                    {
                        lines[i] = lines[i].Substring(tab.Length);
                        deltaTotal -= tab.Length;
                    }
                    else if (lines[i].StartsWith("    ")) // タブの代わりにスペースが並んでいる場合の軽い対処
                    {
                        lines[i] = lines[i].Substring(4);
                        deltaTotal -= 4;
                    }
                    // 行頭が空白でない場合は何もしない
                }
                else
                {
                    lines[i] = tab + lines[i];
                    deltaTotal += tab.Length;
                }
            }

            // 加工後テキストを結合（元の区切り文字と一致させるため、対象範囲から推定）
            string newline = DetectNewline(tb.Text);
            string replaced = string.Join(newline, lines);

            // TextBox のテキストを書き換え
            tb.SelectionStart = lineStartIndex;
            tb.SelectionLength = lineEndIndex - lineStartIndex;
            tb.SelectedText = replaced;

            // 選択範囲を再設定（元の選択行全体を維持）
            int newSelStart = selStart + (lineStartIndex < selStart ? (unindent ? Math.Min(0, deltaTotal) : Math.Max(0, deltaTotal)) : 0);
            // ただし選択開始位置が行頭より後の場合の微調整は不要にするため、行全体で再選択
            int newStart = tb.GetFirstCharIndexFromLine(startLine);
            int newEndFirst = tb.GetFirstCharIndexFromLine(endLine);
            int newEndLen = GetLineText(tb, endLine).Length;
            int newEnd = newEndFirst + newEndLen;

            tb.SelectionStart = newStart;
            tb.SelectionLength = newEnd - newStart;
        }



        private void txtFrom_KeyDown(object sender, KeyEventArgs e)
        {
            // Tab / Shift+Tab 以外はそのまま
            if (e.KeyCode != Keys.Tab) return;

            var tb = (TextBox)sender!;
            if (tb.SelectionLength == 0)
            {
                // 選択なし → 通常のタブ挿入だけ行う場合は以下の1行でOK
                // tb.SelectedText = "\t";
                // ただし自前で抑止しないなら AcceptsTab に任せてもよい
                return;
            }

            e.SuppressKeyPress = true; // 既定のタブ挿入を抑止

            // 選択開始・終了の文字インデックス
            int selStart = tb.SelectionStart;
            int selEnd = selStart + tb.SelectionLength;

            // 選択範囲の先頭・末尾が属する行番号
            int startLine = tb.GetLineFromCharIndex(selStart);
            int endLine = tb.GetLineFromCharIndex(selEnd);

            // 行頭のインデント対象は「選択開始行の先頭」から「選択末尾行の末尾」まで
            int lineStartIndex = tb.GetFirstCharIndexFromLine(startLine);

            // 選択末尾行の先頭インデックス（最終行の文字数を足して末尾位置）
            int lastLineFirstIndex = tb.GetFirstCharIndexFromLine(endLine);
            int lastLineLength = GetLineText(tb, endLine).Length;
            int lineEndIndex = lastLineFirstIndex + lastLineLength; // CRLFは含めない

            // 対象テキスト取得（必ず行単位で切り出す）
            string target = tb.Text.Substring(lineStartIndex, lineEndIndex - lineStartIndex);

            // 行分割（CRLF / CR / LF いずれにも対応）
            var lines = target.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.None);

            bool unindent = e.Shift;   // Shift+Tab はインデント解除
            string tab = "\t";         // もしスペースインデントにしたい場合は "    " などに変更

            int deltaTotal = 0;        // 文字数の増減合計（選択範囲の更新に使用）

            for (int i = 0; i < lines.Length; i++)
            {
                if (unindent)
                {
                    if (lines[i].StartsWith(tab))
                    {
                        lines[i] = lines[i].Substring(tab.Length);
                        deltaTotal -= tab.Length;
                    }
                    else if (lines[i].StartsWith("    ")) // タブの代わりにスペースが並んでいる場合の軽い対処
                    {
                        lines[i] = lines[i].Substring(4);
                        deltaTotal -= 4;
                    }
                    // 行頭が空白でない場合は何もしない
                }
                else
                {
                    lines[i] = tab + lines[i];
                    deltaTotal += tab.Length;
                }
            }

            // 加工後テキストを結合（元の区切り文字と一致させるため、対象範囲から推定）
            string newline = DetectNewline(tb.Text);
            string replaced = string.Join(newline, lines);

            // TextBox のテキストを書き換え
            tb.SelectionStart = lineStartIndex;
            tb.SelectionLength = lineEndIndex - lineStartIndex;
            tb.SelectedText = replaced;

            // 選択範囲を再設定（元の選択行全体を維持）
            int newSelStart = selStart + (lineStartIndex < selStart ? (unindent ? Math.Min(0, deltaTotal) : Math.Max(0, deltaTotal)) : 0);
            // ただし選択開始位置が行頭より後の場合の微調整は不要にするため、行全体で再選択
            int newStart = tb.GetFirstCharIndexFromLine(startLine);
            int newEndFirst = tb.GetFirstCharIndexFromLine(endLine);
            int newEndLen = GetLineText(tb, endLine).Length;
            int newEnd = newEndFirst + newEndLen;

            tb.SelectionStart = newStart;
            tb.SelectionLength = newEnd - newStart;
        }

        // 指定行のテキスト（改行を除く）を取得
        private static string GetLineText(TextBox tb, int lineIndex)
        {
            if (lineIndex < 0 || lineIndex >= tb.Lines.Length) return string.Empty;
            return tb.Lines[lineIndex];
        }

        // 改行コードの推定（混在時は CRLF 優先）
        private static string DetectNewline(string text)
        {
            if (text.Contains("\r\n")) return "\r\n";
            if (text.Contains("\n")) return "\n";
            return "\r\n"; // デフォルト
        }
    }
}
