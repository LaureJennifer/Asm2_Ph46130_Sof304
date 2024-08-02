namespace asm2
{
    partial class Form1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            GiaTxt = new TextBox();
            TenTxt = new TextBox();
            HangxeCbo = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            ClearBtn = new Button();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            AddBtn = new Button();
            groupBox3 = new GroupBox();
            SearchTxt = new TextBox();
            lstXeDvg = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lstXeDvg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GiaTxt);
            groupBox1.Controls.Add(TenTxt);
            groupBox1.Controls.Add(HangxeCbo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 225);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "input";
            // 
            // GiaTxt
            // 
            GiaTxt.Location = new Point(102, 80);
            GiaTxt.Name = "GiaTxt";
            GiaTxt.Size = new Size(360, 27);
            GiaTxt.TabIndex = 7;
            // 
            // TenTxt
            // 
            TenTxt.Location = new Point(102, 31);
            TenTxt.Name = "TenTxt";
            TenTxt.Size = new Size(360, 27);
            TenTxt.TabIndex = 6;
            // 
            // HangxeCbo
            // 
            HangxeCbo.FormattingEnabled = true;
            HangxeCbo.Location = new Point(105, 136);
            HangxeCbo.Name = "HangxeCbo";
            HangxeCbo.Size = new Size(354, 28);
            HangxeCbo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 136);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Hãng xe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Giá bán";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ClearBtn);
            groupBox2.Controls.Add(DeleteBtn);
            groupBox2.Controls.Add(UpdateBtn);
            groupBox2.Controls.Add(AddBtn);
            groupBox2.Location = new Point(537, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(252, 230);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "button";
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(26, 174);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(202, 35);
            ClearBtn.TabIndex = 3;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(26, 126);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(202, 35);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "Xóa";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(26, 77);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(202, 35);
            UpdateBtn.TabIndex = 1;
            UpdateBtn.Text = "Sửa";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(26, 26);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(202, 35);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Thêm";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(SearchTxt);
            groupBox3.Controls.Add(lstXeDvg);
            groupBox3.Location = new Point(19, 238);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(772, 210);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "GridView";
            // 
            // SearchTxt
            // 
            SearchTxt.Location = new Point(97, 23);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(357, 27);
            SearchTxt.TabIndex = 1;
            // 
            // lstXeDvg
            // 
            lstXeDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lstXeDvg.Location = new Point(24, 56);
            lstXeDvg.Name = "lstXeDvg";
            lstXeDvg.RowHeadersWidth = 51;
            lstXeDvg.RowTemplate.Height = 29;
            lstXeDvg.Size = new Size(722, 148);
            lstXeDvg.TabIndex = 0;
            lstXeDvg.CellClick += lstXeDvg_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lstXeDvg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView lstXeDvg;
        private ComboBox HangxeCbo;
        private Button ClearBtn;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button AddBtn;
        private TextBox SearchTxt;
        private TextBox GiaTxt;
        private TextBox TenTxt;
    }
}
