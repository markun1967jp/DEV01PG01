namespace DEV01PG01
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new MenuStrip();
            sQL関連ToolStripMenuItem = new ToolStripMenuItem();
            sQLVSソース化ToolStripMenuItem = new ToolStripMenuItem();
            先頭1スペースToolStripMenuItem = new ToolStripMenuItem();
            sQL句大文字化ToolStripMenuItem = new ToolStripMenuItem();
            末尾ORANDONToolStripMenuItem = new ToolStripMenuItem();
            改行コード除去ToolStripMenuItem = new ToolStripMenuItem();
            mn仕切り線 = new ToolStripMenuItem();
            panel1 = new Panel();
            btnTran = new Button();
            txtTranTo = new TextBox();
            label2 = new Label();
            txtTranFrom = new TextBox();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStrip1 = new ToolStrip();
            btnClose = new ToolStripButton();
            btnResult = new ToolStripButton();
            btnCLR = new ToolStripButton();
            btnSelAllUpper = new ToolStripButton();
            btnSelAllBottom = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sQL関連ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sQL関連ToolStripMenuItem
            // 
            sQL関連ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sQLVSソース化ToolStripMenuItem, 先頭1スペースToolStripMenuItem, sQL句大文字化ToolStripMenuItem, 末尾ORANDONToolStripMenuItem, 改行コード除去ToolStripMenuItem, mn仕切り線 });
            sQL関連ToolStripMenuItem.Name = "sQL関連ToolStripMenuItem";
            sQL関連ToolStripMenuItem.Size = new Size(64, 20);
            sQL関連ToolStripMenuItem.Text = "SQL関連";
            // 
            // sQLVSソース化ToolStripMenuItem
            // 
            sQLVSソース化ToolStripMenuItem.Name = "sQLVSソース化ToolStripMenuItem";
            sQLVSソース化ToolStripMenuItem.Size = new Size(189, 22);
            sQLVSソース化ToolStripMenuItem.Text = "01-SQL_VS_ソース化";
            sQLVSソース化ToolStripMenuItem.Click += SQLVSソース化ToolStripMenuItem_Click;
            // 
            // 先頭1スペースToolStripMenuItem
            // 
            先頭1スペースToolStripMenuItem.Name = "先頭1スペースToolStripMenuItem";
            先頭1スペースToolStripMenuItem.Size = new Size(189, 22);
            先頭1スペースToolStripMenuItem.Text = "02-先頭1スペース";
            先頭1スペースToolStripMenuItem.Click += 先頭1スペースToolStripMenuItem_Click;
            // 
            // sQL句大文字化ToolStripMenuItem
            // 
            sQL句大文字化ToolStripMenuItem.Name = "sQL句大文字化ToolStripMenuItem";
            sQL句大文字化ToolStripMenuItem.Size = new Size(189, 22);
            sQL句大文字化ToolStripMenuItem.Text = "03-SQL句_大文字化";
            sQL句大文字化ToolStripMenuItem.Click += sQL句大文字化ToolStripMenuItem_Click;
            // 
            // 末尾ORANDONToolStripMenuItem
            // 
            末尾ORANDONToolStripMenuItem.Name = "末尾ORANDONToolStripMenuItem";
            末尾ORANDONToolStripMenuItem.Size = new Size(189, 22);
            末尾ORANDONToolStripMenuItem.Text = "04-末尾_OR_AND_ON";
            末尾ORANDONToolStripMenuItem.Click += 末尾ORANDONToolStripMenuItem_Click;
            // 
            // 改行コード除去ToolStripMenuItem
            // 
            改行コード除去ToolStripMenuItem.Name = "改行コード除去ToolStripMenuItem";
            改行コード除去ToolStripMenuItem.Size = new Size(189, 22);
            改行コード除去ToolStripMenuItem.Text = "05.改行コード、除去";
            改行コード除去ToolStripMenuItem.Click += 改行コード除去ToolStripMenuItem_Click;
            // 
            // mn仕切り線
            // 
            mn仕切り線.Name = "mn仕切り線";
            mn仕切り線.Size = new Size(189, 22);
            mn仕切り線.Text = "06.仕切り線 ///---";
            mn仕切り線.Click += mn仕切り線_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(btnTran);
            panel1.Controls.Add(txtTranTo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTranFrom);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 41);
            panel1.TabIndex = 1;
            // 
            // btnTran
            // 
            btnTran.BackColor = Color.FromArgb(128, 255, 255);
            btnTran.FlatStyle = FlatStyle.Flat;
            btnTran.Font = new Font("BIZ UDゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnTran.Location = new Point(691, 10);
            btnTran.Name = "btnTran";
            btnTran.Size = new Size(52, 22);
            btnTran.TabIndex = 4;
            btnTran.Text = "置換";
            btnTran.UseVisualStyleBackColor = false;
            btnTran.Click += BtnTran_Click;
            // 
            // txtTranTo
            // 
            txtTranTo.Font = new Font("BIZ UDゴシック", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtTranTo.Location = new Point(385, 12);
            txtTranTo.MaxLength = 100;
            txtTranTo.Name = "txtTranTo";
            txtTranTo.Size = new Size(290, 20);
            txtTranTo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 14);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 2;
            label2.Text = ">";
            // 
            // txtTranFrom
            // 
            txtTranFrom.Font = new Font("BIZ UDゴシック", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtTranFrom.Location = new Point(58, 12);
            txtTranFrom.MaxLength = 100;
            txtTranFrom.Name = "txtTranFrom";
            txtTranFrom.Size = new Size(290, 20);
            txtTranFrom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "置換:";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 542);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnClose, btnResult, btnCLR, btnSelAllUpper, btnSelAllBottom });
            toolStrip1.Location = new Point(0, 515);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(784, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnClose
            // 
            btnClose.Alignment = ToolStripItemAlignment.Right;
            btnClose.BackColor = Color.FromArgb(224, 224, 224);
            btnClose.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnClose.Font = new Font("BIZ UDゴシック", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageTransparentColor = Color.Magenta;
            btnClose.Margin = new Padding(1);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(4);
            btnClose.RightToLeft = RightToLeft.No;
            btnClose.Size = new Size(58, 25);
            btnClose.Text = "閉じる";
            btnClose.TextImageRelation = TextImageRelation.Overlay;
            btnClose.Click += BtnClose_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(128, 255, 128);
            btnResult.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnResult.Font = new Font("BIZ UDゴシック", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnResult.Image = (Image)resources.GetObject("btnResult.Image");
            btnResult.ImageTransparentColor = Color.Magenta;
            btnResult.Margin = new Padding(1);
            btnResult.Name = "btnResult";
            btnResult.Padding = new Padding(4);
            btnResult.Size = new Size(72, 25);
            btnResult.Text = "結果(↑)";
            btnResult.Click += BtnResult_Click;
            // 
            // btnCLR
            // 
            btnCLR.AutoSize = false;
            btnCLR.BackColor = Color.Cyan;
            btnCLR.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCLR.Font = new Font("BIZ UDゴシック", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnCLR.Image = (Image)resources.GetObject("btnCLR.Image");
            btnCLR.ImageTransparentColor = Color.Magenta;
            btnCLR.Name = "btnCLR";
            btnCLR.Size = new Size(70, 24);
            btnCLR.Text = "クリア";
            btnCLR.Click += btnCLR_Click;
            // 
            // btnSelAllUpper
            // 
            btnSelAllUpper.BackColor = Color.FromArgb(192, 192, 255);
            btnSelAllUpper.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSelAllUpper.Image = (Image)resources.GetObject("btnSelAllUpper.Image");
            btnSelAllUpper.ImageTransparentColor = Color.Magenta;
            btnSelAllUpper.Name = "btnSelAllUpper";
            btnSelAllUpper.Size = new Size(59, 24);
            btnSelAllUpper.Text = "↑全選択";
            btnSelAllUpper.Click += btnSelAllUpper_Click;
            // 
            // btnSelAllBottom
            // 
            btnSelAllBottom.BackColor = Color.FromArgb(192, 255, 255);
            btnSelAllBottom.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSelAllBottom.Image = (Image)resources.GetObject("btnSelAllBottom.Image");
            btnSelAllBottom.ImageTransparentColor = Color.Magenta;
            btnSelAllBottom.Name = "btnSelAllBottom";
            btnSelAllBottom.Size = new Size(59, 24);
            btnSelAllBottom.Text = "↓全選択";
            btnSelAllBottom.Click += btnSelAllBottom_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 65);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtFrom);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtTo);
            splitContainer1.Size = new Size(784, 450);
            splitContainer1.SplitterDistance = 223;
            splitContainer1.TabIndex = 4;
            // 
            // txtFrom
            // 
            txtFrom.Dock = DockStyle.Fill;
            txtFrom.Font = new Font("BIZ UDゴシック", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtFrom.Location = new Point(0, 0);
            txtFrom.Multiline = true;
            txtFrom.Name = "txtFrom";
            txtFrom.ScrollBars = ScrollBars.Both;
            txtFrom.Size = new Size(784, 223);
            txtFrom.TabIndex = 0;
            // 
            // txtTo
            // 
            txtTo.Dock = DockStyle.Fill;
            txtTo.Font = new Font("BIZ UDゴシック", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtTo.Location = new Point(0, 0);
            txtTo.Multiline = true;
            txtTo.Name = "txtTo";
            txtTo.ScrollBars = ScrollBars.Both;
            txtTo.Size = new Size(784, 223);
            txtTo.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 564);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 603);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "開発支援、各種文字変換";
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sQL関連ToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem sQLVSソース化ToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnClose;
        private SplitContainer splitContainer1;
        private TextBox txtFrom;
        private TextBox txtTo;
        private TextBox txtTranTo;
        private Label label2;
        private TextBox txtTranFrom;
        private Label label1;
        private Button btnTran;
        private ToolStripMenuItem 先頭1スペースToolStripMenuItem;
        private ToolStripButton btnResult;
        private ToolStripButton btnCLR;
        private ToolStripMenuItem sQL句大文字化ToolStripMenuItem;
        private ToolStripButton btnSelAllUpper;
        private ToolStripButton btnSelAllBottom;
        private ToolStripMenuItem 末尾ORANDONToolStripMenuItem;
        private ToolStripMenuItem 改行コード除去ToolStripMenuItem;
        private ToolStripMenuItem mn仕切り線;
    }
}
