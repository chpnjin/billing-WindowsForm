namespace 記帳程式_家用版
{
    partial class Form_Login
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
            this.btn_creatNewUser = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_PASSWORD = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_creatNewUser
            // 
            this.btn_creatNewUser.Enabled = false;
            this.btn_creatNewUser.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_creatNewUser.Location = new System.Drawing.Point(118, 140);
            this.btn_creatNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.btn_creatNewUser.Name = "btn_creatNewUser";
            this.btn_creatNewUser.Size = new System.Drawing.Size(171, 49);
            this.btn_creatNewUser.TabIndex = 11;
            this.btn_creatNewUser.Text = "建立新使用者";
            this.btn_creatNewUser.UseVisualStyleBackColor = true;
            this.btn_creatNewUser.Click += new System.EventHandler(this.btn_creatNewUser_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_Login.Location = new System.Drawing.Point(9, 140);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(93, 49);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "登入";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_PASSWORD
            // 
            this.txt_PASSWORD.Font = new System.Drawing.Font("新細明體", 20F);
            this.txt_PASSWORD.Location = new System.Drawing.Point(105, 78);
            this.txt_PASSWORD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PASSWORD.Name = "txt_PASSWORD";
            this.txt_PASSWORD.Size = new System.Drawing.Size(181, 47);
            this.txt_PASSWORD.TabIndex = 9;
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("新細明體", 20F);
            this.txt_ID.Location = new System.Drawing.Point(105, 13);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(181, 47);
            this.txt_ID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "密碼";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "帳號";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 199);
            this.Controls.Add(this.btn_creatNewUser);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_PASSWORD);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Login";
            this.Text = "使用者登入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_creatNewUser;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_PASSWORD;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}