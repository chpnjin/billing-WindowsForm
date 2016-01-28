namespace 記帳程式_家用版
{
    partial class Form_addSub
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
            this.lbl_subname = new System.Windows.Forms.Label();
            this.lbl_subtype = new System.Windows.Forms.Label();
            this.lbl_remark = new System.Windows.Forms.Label();
            this.txt_subname = new System.Windows.Forms.TextBox();
            this.cbo_subtype = new System.Windows.Forms.ComboBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.btn_Addcomplete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_subname
            // 
            this.lbl_subname.AutoSize = true;
            this.lbl_subname.Location = new System.Drawing.Point(12, 15);
            this.lbl_subname.Name = "lbl_subname";
            this.lbl_subname.Size = new System.Drawing.Size(67, 15);
            this.lbl_subname.TabIndex = 0;
            this.lbl_subname.Text = "科目名稱";
            // 
            // lbl_subtype
            // 
            this.lbl_subtype.AutoSize = true;
            this.lbl_subtype.Location = new System.Drawing.Point(12, 72);
            this.lbl_subtype.Name = "lbl_subtype";
            this.lbl_subtype.Size = new System.Drawing.Size(67, 15);
            this.lbl_subtype.TabIndex = 1;
            this.lbl_subtype.Text = "科目類別";
            // 
            // lbl_remark
            // 
            this.lbl_remark.AutoSize = true;
            this.lbl_remark.Location = new System.Drawing.Point(12, 100);
            this.lbl_remark.Name = "lbl_remark";
            this.lbl_remark.Size = new System.Drawing.Size(37, 15);
            this.lbl_remark.TabIndex = 2;
            this.lbl_remark.Text = "備註";
            // 
            // txt_subname
            // 
            this.txt_subname.Location = new System.Drawing.Point(15, 33);
            this.txt_subname.Name = "txt_subname";
            this.txt_subname.Size = new System.Drawing.Size(199, 25);
            this.txt_subname.TabIndex = 3;
            // 
            // cbo_subtype
            // 
            this.cbo_subtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_subtype.FormattingEnabled = true;
            this.cbo_subtype.Location = new System.Drawing.Point(85, 69);
            this.cbo_subtype.Name = "cbo_subtype";
            this.cbo_subtype.Size = new System.Drawing.Size(129, 23);
            this.cbo_subtype.TabIndex = 4;
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(12, 118);
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_remark.Size = new System.Drawing.Size(202, 164);
            this.txt_remark.TabIndex = 5;
            // 
            // btn_Addcomplete
            // 
            this.btn_Addcomplete.Location = new System.Drawing.Point(139, 288);
            this.btn_Addcomplete.Name = "btn_Addcomplete";
            this.btn_Addcomplete.Size = new System.Drawing.Size(75, 23);
            this.btn_Addcomplete.TabIndex = 6;
            this.btn_Addcomplete.Text = "確認新增";
            this.btn_Addcomplete.UseVisualStyleBackColor = true;
            this.btn_Addcomplete.Click += new System.EventHandler(this.btn_Addcomplete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(87, 288);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(46, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Form_addSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(226, 321);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Addcomplete);
            this.Controls.Add(this.txt_remark);
            this.Controls.Add(this.cbo_subtype);
            this.Controls.Add(this.txt_subname);
            this.Controls.Add(this.lbl_remark);
            this.Controls.Add(this.lbl_subtype);
            this.Controls.Add(this.lbl_subname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_addSub";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "新增科目";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_addSub_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_subname;
        private System.Windows.Forms.Label lbl_subtype;
        private System.Windows.Forms.Label lbl_remark;
        private System.Windows.Forms.TextBox txt_subname;
        private System.Windows.Forms.ComboBox cbo_subtype;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Button btn_Addcomplete;
        private System.Windows.Forms.Button btn_cancel;
    }
}