namespace DEV01PG01
{
    public partial class FrmMain : Form
    {
        private ClsConvert clsCnv = new ClsConvert();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

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
    }
}
