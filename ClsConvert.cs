using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV01PG01
{
    internal class ClsConvert
    {

        public void Fn_Replace(TextBox textBoxInput, TextBox textBoxOutput,string 置換前の文字列,string 置換後の文字列)
        {
            // 入力TextBoxのテキストを行単位で取得
            string[] lines = textBoxInput.Lines;

            // 置換後の行を格納するリスト
            var replacedLines = lines.Select(line => line.Replace(置換前の文字列, 置換後の文字列)).ToArray();

            // 出力TextBoxに置換後の行を設定
            textBoxOutput.Lines = replacedLines;

        }
        public void Fn_SQL_To_Code(TextBox textBoxInput, TextBox textBoxOutput, string 先頭に追加する文字, string 末尾に追加する文字)
        {
            // 入力TextBoxのテキストを行単位で取得
            string[] lines = textBoxInput.Lines;

            // 各行の先頭と末尾に指定した文字を追加
            string prefix = 先頭に追加する文字;
            string suffix = 末尾に追加する文字;
            var modifiedLines = lines.Select(line => $"{prefix}{line}{suffix}").ToArray();

            // 出力TextBoxに加工後の行を設定
            textBoxOutput.Lines = modifiedLines;

        }


        public void Fn_LeftOnepace(TextBox textBoxInput, TextBox textBoxOutput)
        {
            // 入力TextBoxのテキストを行単位で取得
            string[] lines = textBoxInput.Lines;

            // 各行の先頭の空白を取り除き、空白1文字に置き換える
            var modifiedLines = lines.Select(line => " " + line.TrimStart()).ToArray();

            // 出力TextBoxに置換後の行を設定
            textBoxOutput.Lines = modifiedLines;

            // タブ文字をスペース1文字に置換
            textBoxOutput.Text = textBoxOutput.Text.Replace("\t", " ");

            // 各行の右後ろのスペースを取り除く処理
            var lines2 = textBoxOutput.Lines;
            var trimmedLines = lines2.Select(line => line.TrimEnd()).ToArray();
            textBoxOutput.Lines = trimmedLines;

            // 右端に、1バイトスペースを追加。
            Fn_RightSpace(textBoxOutput);
        }

        /// <summary>
        /// 右端に、1バイトスペースを追加。
        /// </summary>
        /// <param name="textBoxInput"></param>
        /// <param name="textBoxOutput"></param>
        public void Fn_RightSpace(TextBox textBoxOutput)
        {
            // 現在のテキストを行ごとに分割
            string[] lines = textBoxOutput.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++)
            {
                // 各行の末尾にスペースを追加
                if (!lines[i].EndsWith(" "))
                {
                    lines[i] += " ";
                }
            }

            // 行を再度結合してTextBoxに設定
            textBoxOutput.Text = string.Join(Environment.NewLine, lines);

        }

        public void Fn_CapitalLetter(TextBox textBoxInput, TextBox textBoxOutput)
        {
            // 入力TextBoxのテキストを行単位で取得
            string[] lines = textBoxInput.Lines;

            // 置換
            var Lines1 = lines.Select(line => line.Replace("select ", "SELECT ")).ToArray();
            var Lines2 = Lines1.Select(line => line.Replace("or ", "OR ")).ToArray();
            var Lines3 = Lines2.Select(line => line.Replace("and ", "AND ")).ToArray();
            var Lines4 = Lines3.Select(line => line.Replace("group by", "GROUP BY")).ToArray();
            var Lines5 = Lines4.Select(line => line.Replace("order by", "ORDER BY")).ToArray();
            var Lines6 = Lines5.Select(line => line.Replace("sum(", "SUM(")).ToArray();
            var Lines7 = Lines6.Select(line => line.Replace("left join", "LEFT JOIN")).ToArray();
            var Lines8 = Lines7.Select(line => line.Replace("left outer join", "LEFT JOIN")).ToArray();
            var Lines9 = Lines8.Select(line => line.Replace("max(", "MAX(")).ToArray();
            var Lines10 = Lines9.Select(line => line.Replace("min(", "MIN(")).ToArray();
            var Lines11 = Lines10.Select(line => line.Replace("where ", "WHERE ")).ToArray();
            var Lines12 = Lines11.Select(line => line.Replace("union all", "UNION ALL")).ToArray();
            var Lines13 = Lines12.Select(line => line.Replace("having ", "HAVING ")).ToArray();
            var Lines14 = Lines13.Select(line => line.Replace("from ", "FROM ")).ToArray();
            var Lines15 = Lines14.Select(line => line.Replace("as ", "AS ")).ToArray();
            var Lines16 = Lines15.Select(line => line.Replace("LEFT OUTER JOIN", "LEFT JOIN")).ToArray();
            var Lines17 = Lines16.Select(line => line.Replace("in ", "IN ")).ToArray();
            var Lines18 = Lines17.Select(line => line.Replace("Group by", "GROUP BY")).ToArray();
            var Lines19 = Lines18.Select(line => line.Replace("on ", "ON ")).ToArray();
            var Lines20 = Lines19.Select(line => line.Replace("end ", "END ")).ToArray();
            var Lines21 = Lines20.Select(line => line.Replace("case ", "CASE ")).ToArray();
            var Lines22 = Lines21.Select(line => line.Replace("when ", "WHEN ")).ToArray();


            var replacedLines = Lines22;

            // 出力TextBoxに置換後の行を設定
            textBoxOutput.Lines = replacedLines;
        }


        /// <summary>
        /// 前の行のAND ORを次の行の先頭に移動する。
        /// </summary>
        /// <param name="textBoxOutput"></param>
        public void Fn_CheckEndLetter(TextBox textBoxInput,TextBox textBoxOutput)
        {
            // 現在のテキストを行ごとに分割
            string[] lines = textBoxInput.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            string sADD = "";
            // 各行を加工
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = " " + lines[i].Trim();
                if (sADD != "")
                {
                    lines[i] = sADD + lines[i];
                    sADD = "";
                }

                string thisLine = lines[i];
                
                if (thisLine.Length >= 4 && thisLine.Substring(thisLine.Length - 4) == " AND")
                {
                    lines[i] = thisLine.Substring(0, thisLine.Length - 4);
                    sADD = " AND";
                }
                if (thisLine.Length >= 4 && thisLine.Substring(thisLine.Length - 3) == " OR")
                {
                    lines[i] = thisLine.Substring(0, thisLine.Length - 3);
                    sADD = " OR";
                }
                if (thisLine.Length >= 4 && thisLine.Substring(thisLine.Length - 3) == " ON")
                {
                    lines[i] = thisLine.Substring(0, thisLine.Length - 3);
                    sADD = " ON";
                }
            }

            // 行を再度結合してTextBoxに設定
            textBoxOutput.Text = string.Join(Environment.NewLine, lines);

        }

    }
}
