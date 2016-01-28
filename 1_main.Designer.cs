namespace 記帳程式_家用版
{
    partial class Form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.mns_main = new System.Windows.Forms.MenuStrip();
            this.記帳ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增交易ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯交易資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查詢交易紀錄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_close = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增科目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯現有科目ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.統計ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資產負債表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.損益表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_main = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_near = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Loss = new System.Windows.Forms.DataGridView();
            this.dgv_Income = new System.Windows.Forms.DataGridView();
            this.dgv_Equity = new System.Windows.Forms.DataGridView();
            this.dgv_Liability = new System.Windows.Forms.DataGridView();
            this.dgv_Asset = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mns_main.SuspendLayout();
            this.tsr_main.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_near)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Income)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Equity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asset)).BeginInit();
            this.SuspendLayout();
            // 
            // mns_main
            // 
            this.mns_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.記帳ToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.統計ToolStripMenuItem});
            this.mns_main.Location = new System.Drawing.Point(0, 0);
            this.mns_main.Name = "mns_main";
            this.mns_main.Size = new System.Drawing.Size(1227, 27);
            this.mns_main.TabIndex = 0;
            this.mns_main.Text = "mns_main";
            // 
            // 記帳ToolStripMenuItem
            // 
            this.記帳ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增交易ToolStripMenuItem,
            this.編輯交易資料ToolStripMenuItem,
            this.查詢交易紀錄ToolStripMenuItem,
            this.tsmi_close});
            this.記帳ToolStripMenuItem.Name = "記帳ToolStripMenuItem";
            this.記帳ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.記帳ToolStripMenuItem.Text = "交易";
            // 
            // 新增交易ToolStripMenuItem
            // 
            this.新增交易ToolStripMenuItem.Name = "新增交易ToolStripMenuItem";
            this.新增交易ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.新增交易ToolStripMenuItem.Text = "新增交易";
            this.新增交易ToolStripMenuItem.Click += new System.EventHandler(this.新增交易ToolStripMenuItem_Click);
            // 
            // 編輯交易資料ToolStripMenuItem
            // 
            this.編輯交易資料ToolStripMenuItem.Name = "編輯交易資料ToolStripMenuItem";
            this.編輯交易資料ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.編輯交易資料ToolStripMenuItem.Text = "編輯交易資料";
            this.編輯交易資料ToolStripMenuItem.Click += new System.EventHandler(this.編輯交易資料ToolStripMenuItem_Click);
            // 
            // 查詢交易紀錄ToolStripMenuItem
            // 
            this.查詢交易紀錄ToolStripMenuItem.Name = "查詢交易紀錄ToolStripMenuItem";
            this.查詢交易紀錄ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.查詢交易紀錄ToolStripMenuItem.Text = "查詢交易紀錄";
            this.查詢交易紀錄ToolStripMenuItem.Click += new System.EventHandler(this.查詢交易紀錄ToolStripMenuItem_Click);
            // 
            // tsmi_close
            // 
            this.tsmi_close.Name = "tsmi_close";
            this.tsmi_close.Size = new System.Drawing.Size(174, 26);
            this.tsmi_close.Text = "收支結清";
            this.tsmi_close.Click += new System.EventHandler(this.虛帳戶結帳ToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增科目ToolStripMenuItem,
            this.編輯現有科目ToolStripMenuItem1});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.設定ToolStripMenuItem.Text = "科目";
            // 
            // 新增科目ToolStripMenuItem
            // 
            this.新增科目ToolStripMenuItem.Name = "新增科目ToolStripMenuItem";
            this.新增科目ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.新增科目ToolStripMenuItem.Text = "新增科目";
            this.新增科目ToolStripMenuItem.Click += new System.EventHandler(this.新增科目ToolStripMenuItem_Click);
            // 
            // 編輯現有科目ToolStripMenuItem1
            // 
            this.編輯現有科目ToolStripMenuItem1.Name = "編輯現有科目ToolStripMenuItem1";
            this.編輯現有科目ToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.編輯現有科目ToolStripMenuItem1.Text = "編輯科目資料";
            this.編輯現有科目ToolStripMenuItem1.Click += new System.EventHandler(this.編輯現有科目ToolStripMenuItem1_Click);
            // 
            // 統計ToolStripMenuItem
            // 
            this.統計ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.資產負債表ToolStripMenuItem,
            this.損益表ToolStripMenuItem});
            this.統計ToolStripMenuItem.Name = "統計ToolStripMenuItem";
            this.統計ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.統計ToolStripMenuItem.Text = "報表";
            // 
            // 資產負債表ToolStripMenuItem
            // 
            this.資產負債表ToolStripMenuItem.Name = "資產負債表ToolStripMenuItem";
            this.資產負債表ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.資產負債表ToolStripMenuItem.Text = "資產負債表";
            this.資產負債表ToolStripMenuItem.Click += new System.EventHandler(this.資產負債表ToolStripMenuItem_Click);
            // 
            // 損益表ToolStripMenuItem
            // 
            this.損益表ToolStripMenuItem.Name = "損益表ToolStripMenuItem";
            this.損益表ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.損益表ToolStripMenuItem.Text = "損益表";
            this.損益表ToolStripMenuItem.Click += new System.EventHandler(this.損益表ToolStripMenuItem_Click);
            // 
            // tsr_main
            // 
            this.tsr_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsr_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.tsr_main.Location = new System.Drawing.Point(0, 27);
            this.tsr_main.Name = "tsr_main";
            this.tsr_main.Size = new System.Drawing.Size(1227, 27);
            this.tsr_main.TabIndex = 1;
            this.tsr_main.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "新增交易";
            this.toolStripButton1.ToolTipText = "新增交易";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_near);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 9F);
            this.groupBox2.Location = new System.Drawing.Point(400, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 523);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "最近交易紀錄";
            // 
            // dgv_near
            // 
            this.dgv_near.AllowUserToAddRows = false;
            this.dgv_near.AllowUserToDeleteRows = false;
            this.dgv_near.AllowUserToResizeColumns = false;
            this.dgv_near.AllowUserToResizeRows = false;
            this.dgv_near.CausesValidation = false;
            this.dgv_near.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_near.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_near.Location = new System.Drawing.Point(3, 21);
            this.dgv_near.Name = "dgv_near";
            this.dgv_near.ReadOnly = true;
            this.dgv_near.RowTemplate.Height = 27;
            this.dgv_near.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_near.Size = new System.Drawing.Size(809, 499);
            this.dgv_near.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Loss);
            this.groupBox1.Controls.Add(this.dgv_Income);
            this.groupBox1.Controls.Add(this.dgv_Equity);
            this.groupBox1.Controls.Add(this.dgv_Liability);
            this.groupBox1.Controls.Add(this.dgv_Asset);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 523);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "各類科目餘額";
            // 
            // dgv_Loss
            // 
            this.dgv_Loss.AllowUserToAddRows = false;
            this.dgv_Loss.AllowUserToDeleteRows = false;
            this.dgv_Loss.AllowUserToResizeColumns = false;
            this.dgv_Loss.AllowUserToResizeRows = false;
            this.dgv_Loss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Loss.Location = new System.Drawing.Point(195, 355);
            this.dgv_Loss.Name = "dgv_Loss";
            this.dgv_Loss.ReadOnly = true;
            this.dgv_Loss.RowHeadersVisible = false;
            this.dgv_Loss.RowTemplate.Height = 27;
            this.dgv_Loss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Loss.Size = new System.Drawing.Size(180, 163);
            this.dgv_Loss.TabIndex = 13;
            this.dgv_Loss.DataSourceChanged += new System.EventHandler(this.dgv_DataSourceChanged);
            // 
            // dgv_Income
            // 
            this.dgv_Income.AllowUserToAddRows = false;
            this.dgv_Income.AllowUserToDeleteRows = false;
            this.dgv_Income.AllowUserToResizeColumns = false;
            this.dgv_Income.AllowUserToResizeRows = false;
            this.dgv_Income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Income.Location = new System.Drawing.Point(9, 355);
            this.dgv_Income.Name = "dgv_Income";
            this.dgv_Income.ReadOnly = true;
            this.dgv_Income.RowHeadersVisible = false;
            this.dgv_Income.RowTemplate.Height = 27;
            this.dgv_Income.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Income.Size = new System.Drawing.Size(180, 163);
            this.dgv_Income.TabIndex = 12;
            this.dgv_Income.DataSourceChanged += new System.EventHandler(this.dgv_DataSourceChanged);
            // 
            // dgv_Equity
            // 
            this.dgv_Equity.AllowUserToAddRows = false;
            this.dgv_Equity.AllowUserToDeleteRows = false;
            this.dgv_Equity.AllowUserToResizeColumns = false;
            this.dgv_Equity.AllowUserToResizeRows = false;
            this.dgv_Equity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Equity.Location = new System.Drawing.Point(195, 226);
            this.dgv_Equity.Name = "dgv_Equity";
            this.dgv_Equity.ReadOnly = true;
            this.dgv_Equity.RowHeadersVisible = false;
            this.dgv_Equity.RowTemplate.Height = 27;
            this.dgv_Equity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Equity.Size = new System.Drawing.Size(180, 106);
            this.dgv_Equity.TabIndex = 11;
            this.dgv_Equity.DataSourceChanged += new System.EventHandler(this.dgv_DataSourceChanged);
            // 
            // dgv_Liability
            // 
            this.dgv_Liability.AllowUserToAddRows = false;
            this.dgv_Liability.AllowUserToDeleteRows = false;
            this.dgv_Liability.AllowUserToResizeColumns = false;
            this.dgv_Liability.AllowUserToResizeRows = false;
            this.dgv_Liability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Liability.Location = new System.Drawing.Point(195, 40);
            this.dgv_Liability.Name = "dgv_Liability";
            this.dgv_Liability.ReadOnly = true;
            this.dgv_Liability.RowHeadersVisible = false;
            this.dgv_Liability.RowTemplate.Height = 27;
            this.dgv_Liability.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Liability.Size = new System.Drawing.Size(180, 164);
            this.dgv_Liability.TabIndex = 10;
            this.dgv_Liability.DataSourceChanged += new System.EventHandler(this.dgv_DataSourceChanged);
            // 
            // dgv_Asset
            // 
            this.dgv_Asset.AllowUserToAddRows = false;
            this.dgv_Asset.AllowUserToDeleteRows = false;
            this.dgv_Asset.AllowUserToResizeColumns = false;
            this.dgv_Asset.AllowUserToResizeRows = false;
            this.dgv_Asset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Asset.Location = new System.Drawing.Point(9, 40);
            this.dgv_Asset.Name = "dgv_Asset";
            this.dgv_Asset.ReadOnly = true;
            this.dgv_Asset.RowHeadersVisible = false;
            this.dgv_Asset.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_Asset.RowTemplate.Height = 27;
            this.dgv_Asset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Asset.Size = new System.Drawing.Size(180, 292);
            this.dgv_Asset.TabIndex = 9;
            this.dgv_Asset.DataSourceChanged += new System.EventHandler(this.dgv_DataSourceChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "支出";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "淨值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "收入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "負債";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "資產";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 594);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tsr_main);
            this.Controls.Add(this.mns_main);
            this.MainMenuStrip = this.mns_main;
            this.Name = "Form_main";
            this.Text = "程式主畫面";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.Shown += new System.EventHandler(this.Form_main_Shown);
            this.mns_main.ResumeLayout(false);
            this.mns_main.PerformLayout();
            this.tsr_main.ResumeLayout(false);
            this.tsr_main.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_near)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Income)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Equity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_main;
        private System.Windows.Forms.ToolStripMenuItem 記帳ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增交易ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯交易資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsr_main;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_near;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增科目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯現有科目ToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem 統計ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 資產負債表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 損益表ToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Loss;
        private System.Windows.Forms.DataGridView dgv_Income;
        private System.Windows.Forms.DataGridView dgv_Equity;
        private System.Windows.Forms.DataGridView dgv_Liability;
        private System.Windows.Forms.DataGridView dgv_Asset;
        private System.Windows.Forms.ToolStripMenuItem 查詢交易紀錄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_close;
    }
}