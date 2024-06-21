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
        }

    }
}
