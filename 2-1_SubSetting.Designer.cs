namespace 記帳程式_家用版
{
    partial class Form_SubSetting
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
            this.dgv_sublist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_subname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_subtype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.btn_overset = new System.Windows.Forms.Button();
            this.btn_INSERTsub = new System.Windows.Forms.Button();
            this.btn_UPDATAsub = new System.Windows.Forms.Button();
            this.btn_DELETEsub = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sublist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_sublist);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 270);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "現有科目總表";
            // 
            // dgv_sublist
            // 
            this.dgv_sublist.AllowUserToResizeColumns = false;
            this.dgv_sublist.AllowUserToResizeRows = false;
            this.dgv_sublist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sublist.Location = new System.Drawing.Point(7, 24);
            this.dgv_sublist.MultiSelect = false;
            this.dgv_sublist.Name = "dgv_sublist";
            this.dgv_sublist.ReadOnly = true;
            this.dgv_sublist.RowTemplate.Height = 27;
            this.dgv_sublist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sublist.Size = new System.Drawing.Size(142, 240);
            this.dgv_sublist.TabIndex = 0;
            this.dgv_sublist.SelectionChanged += new System.EventHandler(this.dgv_sublist_SelectionChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "科目名稱";
            // 
            // txt_subname
            // 
            this.txt_subname.Location = new System.Drawing.Point(243, 19);
            this.txt_subname.Name = "txt_subname";
            this.txt_subname.Size = new System.Drawing.Size(119, 25);
            this.txt_subname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "科目類型";
            // 
            // cbo_subtype
            // 
            this.cbo_subtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_subtype.FormattingEnabled = true;
            this.cbo_subtype.Location = new System.Drawing.Point(243, 50);
            this.cbo_subtype.Name = "cbo_subtype";
            this.cbo_subtype.Size = new System.Drawing.Size(119, 23);
            this.cbo_subtype.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "說明";
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(176, 100);
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_remark.Size = new System.Drawing.Size(186, 176);
            this.txt_remark.TabIndex = 10;
            // 
            // btn_overset
            // 
            this.btn_overset.Location = new System.Drawing.Point(285, 288);
            this.btn_overset.Name = "btn_overset";
            this.btn_overset.Size = new System.Drawing.Size(77, 27);
            this.btn_overset.TabIndex = 11;
            this.btn_overset.Text = "設定完成";
            this.btn_overset.UseVisualStyleBackColor = true;
            this.btn_overset.Click += new System.EventHandler(this.btn_overset_Click);
            // 
            // btn_INSERTsub
            // 
            this.btn_INSERTsub.Location = new System.Drawing.Point(12, 288);
            this.btn_INSERTsub.Name = "btn_INSERTsub";
            this.btn_INSERTsub.Size = new System.Drawing.Size(49, 27);
            this.btn_INSERTsub.TabIndex = 12;
            this.btn_INSERTsub.Text = "新增";
            this.btn_INSERTsub.UseVisualStyleBackColor = true;
            this.btn_INSERTsub.Click += new System.EventHandler(this.btn_INSERTsub_Click);
            // 
            // btn_UPDATAsub
            // 
            this.btn_UPDATAsub.Location = new System.Drawing.Point(67, 288);
            this.btn_UPDATAsub.Name = "btn_UPDATAsub";
            this.btn_UPDATAsub.Size = new System.Drawing.Size(49, 27);
            this.btn_UPDATAsub.TabIndex = 13;
            this.btn_UPDATAsub.Text = "修改";
            this.btn_UPDATAsub.UseVisualStyleBackColor = true;
            this.btn_UPDATAsub.Click += new System.EventHandler(this.btn_UPDATAsub_Click);
            // 
            // btn_DELETEsub
            // 
            this.btn_DELETEsub.Location = new System.Drawing.Point(122, 288);
            this.btn_DELETEsub.Name = "btn_DELETEsub";
            this.btn_DELETEsub.Size = new System.Drawing.Size(49, 27);
            this.btn_DELETEsub.TabIndex = 14;
            this.btn_DELETEsub.Text = "刪除";
            this.btn_DELETEsub.UseVisualStyleBackColor = true;
            btn_DELETEsub.Click += new System.EventHandler(btn_DELETEsub_Click);
            // 
            // Form_SubSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(373, 325);
            this.Controls.Add(this.btn_DELETEsub);
            this.Controls.Add(this.btn_UPDATAsub);
            this.Controls.Add(this.btn_INSERTsub);
            this.Controls.Add(this.btn_overset);
            this.Controls.Add(this.txt_remark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_subtype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_subname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_SubSetting";
            this.Text = "交易科目設定";
            this.Load += new System.EventHandler(this.Form_SubSetting_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sublist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_subname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_subtype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Button btn_overset;
        private System.Windows.Forms.Button btn_INSERTsub;
        private System.Windows.Forms.Button btn_UPDATAsub;
        private System.Windows.Forms.Button btn_DELETEsub;
        private System.Windows.Forms.DataGridView dgv_sublist;
    }
}