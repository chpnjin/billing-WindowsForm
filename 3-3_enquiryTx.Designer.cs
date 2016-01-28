namespace 記帳程式_家用版
{
    partial class Form_enquiry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_editTxdata = new System.Windows.Forms.Button();
            this.dgv_ALLlot = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Txdata = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ALLlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Txdata)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_editTxdata);
            this.groupBox1.Controls.Add(this.dgv_ALLlot);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.dtp_start);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查詢條件";
            // 
            // btn_editTxdata
            // 
            this.btn_editTxdata.Location = new System.Drawing.Point(157, 108);
            this.btn_editTxdata.Name = "btn_editTxdata";
            this.btn_editTxdata.Size = new System.Drawing.Size(45, 23);
            this.btn_editTxdata.TabIndex = 16;
            this.btn_editTxdata.Text = "修改";
            this.btn_editTxdata.UseVisualStyleBackColor = true;
            this.btn_editTxdata.Click += new System.EventHandler(this.btn_editTxdata_Click);
            // 
            // dgv_ALLlot
            // 
            this.dgv_ALLlot.AllowUserToAddRows = false;
            this.dgv_ALLlot.AllowUserToDeleteRows = false;
            this.dgv_ALLlot.AllowUserToResizeColumns = false;
            this.dgv_ALLlot.AllowUserToResizeRows = false;
            this.dgv_ALLlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ALLlot.Location = new System.Drawing.Point(6, 138);
            this.dgv_ALLlot.MultiSelect = false;
            this.dgv_ALLlot.Name = "dgv_ALLlot";
            this.dgv_ALLlot.ReadOnly = true;
            this.dgv_ALLlot.RowHeadersVisible = false;
            this.dgv_ALLlot.RowTemplate.Height = 27;
            this.dgv_ALLlot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ALLlot.Size = new System.Drawing.Size(196, 265);
            this.dgv_ALLlot.TabIndex = 15;
            this.dgv_ALLlot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ALLlot_CellContentClick);
            this.dgv_ALLlot.SelectionChanged += new System.EventHandler(this.dgv_ALLlot_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "結束";
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(49, 77);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(153, 25);
            this.dtp_end.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(96, 108);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(45, 23);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "清除";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(6, 108);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "確認查詢";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(49, 46);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(153, 25);
            this.dtp_start.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "開始";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "交易日期";
            // 
            // dgv_Txdata
            // 
            this.dgv_Txdata.AllowUserToAddRows = false;
            this.dgv_Txdata.AllowUserToDeleteRows = false;
            this.dgv_Txdata.AllowUserToResizeColumns = false;
            this.dgv_Txdata.AllowUserToResizeRows = false;
            this.dgv_Txdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Txdata.Location = new System.Drawing.Point(227, 13);
            this.dgv_Txdata.Name = "dgv_Txdata";
            this.dgv_Txdata.ReadOnly = true;
            this.dgv_Txdata.RowTemplate.Height = 27;
            this.dgv_Txdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Txdata.Size = new System.Drawing.Size(503, 403);
            this.dgv_Txdata.TabIndex = 14;
            this.dgv_Txdata.DataSourceChanged += new System.EventHandler(this.dgv_Txdata_DataSourceChanged);
            // 
            // Form_enquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 427);
            this.Controls.Add(this.dgv_Txdata);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_enquiry";
            this.Text = "查詢交易紀錄";
            this.Load += new System.EventHandler(this.Form_enquiry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ALLlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Txdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Txdata;
        private System.Windows.Forms.DataGridView dgv_ALLlot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_editTxdata;
    }
}