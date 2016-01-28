namespace 記帳程式_家用版
{
    partial class Form_firstUse
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_finish = new System.Windows.Forms.Button();
            this.dgv_NewSub = new System.Windows.Forms.DataGridView();
            this.btn_delsub = new System.Windows.Forms.Button();
            this.btn_addsub = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_balance = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.lbl_assets = new System.Windows.Forms.Label();
            this.lbl_Liabilities = new System.Windows.Forms.Label();
            this.txt_L = new System.Windows.Forms.TextBox();
            this.lbl_net = new System.Windows.Forms.Label();
            this.txt_N = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_startday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NewSub)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "歡迎使用本記帳程式，初次使用時須先設定實帳戶(資產,負債,淨值)\r\n資產類至少一項，負債或淨值類加起來必須超過一項";
            // 
            // btn_finish
            // 
            this.btn_finish.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_finish.Location = new System.Drawing.Point(692, 291);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(101, 32);
            this.btn_finish.TabIndex = 4;
            this.btn_finish.Text = "設定完成";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // dgv_NewSub
            // 
            this.dgv_NewSub.AllowUserToAddRows = false;
            this.dgv_NewSub.AllowUserToResizeColumns = false;
            this.dgv_NewSub.AllowUserToResizeRows = false;
            this.dgv_NewSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NewSub.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_NewSub.Location = new System.Drawing.Point(76, 21);
            this.dgv_NewSub.Name = "dgv_NewSub";
            this.dgv_NewSub.RowTemplate.Height = 27;
            this.dgv_NewSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NewSub.Size = new System.Drawing.Size(705, 173);
            this.dgv_NewSub.TabIndex = 5;
            // 
            // btn_delsub
            // 
            this.btn_delsub.Location = new System.Drawing.Point(6, 79);
            this.btn_delsub.Name = "btn_delsub";
            this.btn_delsub.Size = new System.Drawing.Size(64, 51);
            this.btn_delsub.TabIndex = 14;
            this.btn_delsub.Text = "刪除";
            this.btn_delsub.UseVisualStyleBackColor = true;
            this.btn_delsub.Click += new System.EventHandler(this.btn_delsub_Click);
            // 
            // btn_addsub
            // 
            this.btn_addsub.Location = new System.Drawing.Point(6, 21);
            this.btn_addsub.Name = "btn_addsub";
            this.btn_addsub.Size = new System.Drawing.Size(64, 52);
            this.btn_addsub.TabIndex = 12;
            this.btn_addsub.Text = "新增";
            this.btn_addsub.UseVisualStyleBackColor = true;
            this.btn_addsub.Click += new System.EventHandler(this.btn_addsub_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_balance);
            this.groupBox1.Controls.Add(this.dgv_NewSub);
            this.groupBox1.Controls.Add(this.btn_delsub);
            this.groupBox1.Controls.Add(this.btn_addsub);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 197);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btn_balance
            // 
            this.btn_balance.Location = new System.Drawing.Point(6, 136);
            this.btn_balance.Name = "btn_balance";
            this.btn_balance.Size = new System.Drawing.Size(64, 51);
            this.btn_balance.TabIndex = 15;
            this.btn_balance.Text = "試算";
            this.btn_balance.UseVisualStyleBackColor = true;
            this.btn_balance.Click += new System.EventHandler(this.btn_balance_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(8, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "借貸平衡試算：";
            // 
            // txt_A
            // 
            this.txt_A.Font = new System.Drawing.Font("新細明體", 12F);
            this.txt_A.Location = new System.Drawing.Point(67, 292);
            this.txt_A.Name = "txt_A";
            this.txt_A.ReadOnly = true;
            this.txt_A.Size = new System.Drawing.Size(100, 31);
            this.txt_A.TabIndex = 17;
            this.txt_A.Text = "0";
            // 
            // lbl_assets
            // 
            this.lbl_assets.AutoSize = true;
            this.lbl_assets.Font = new System.Drawing.Font("新細明體", 12F);
            this.lbl_assets.Location = new System.Drawing.Point(12, 296);
            this.lbl_assets.Name = "lbl_assets";
            this.lbl_assets.Size = new System.Drawing.Size(49, 20);
            this.lbl_assets.TabIndex = 18;
            this.lbl_assets.Text = "資產";
            // 
            // lbl_Liabilities
            // 
            this.lbl_Liabilities.AutoSize = true;
            this.lbl_Liabilities.Font = new System.Drawing.Font("新細明體", 12F);
            this.lbl_Liabilities.Location = new System.Drawing.Point(173, 297);
            this.lbl_Liabilities.Name = "lbl_Liabilities";
            this.lbl_Liabilities.Size = new System.Drawing.Size(69, 20);
            this.lbl_Liabilities.TabIndex = 19;
            this.lbl_Liabilities.Text = "－負債";
            // 
            // txt_L
            // 
            this.txt_L.Font = new System.Drawing.Font("新細明體", 12F);
            this.txt_L.Location = new System.Drawing.Point(248, 292);
            this.txt_L.Name = "txt_L";
            this.txt_L.ReadOnly = true;
            this.txt_L.Size = new System.Drawing.Size(100, 31);
            this.txt_L.TabIndex = 20;
            this.txt_L.Text = "0";
            // 
            // lbl_net
            // 
            this.lbl_net.AutoSize = true;
            this.lbl_net.Font = new System.Drawing.Font("新細明體", 12F);
            this.lbl_net.Location = new System.Drawing.Point(354, 297);
            this.lbl_net.Name = "lbl_net";
            this.lbl_net.Size = new System.Drawing.Size(69, 20);
            this.lbl_net.TabIndex = 21;
            this.lbl_net.Text = "－淨值";
            // 
            // txt_N
            // 
            this.txt_N.Font = new System.Drawing.Font("新細明體", 12F);
            this.txt_N.Location = new System.Drawing.Point(429, 292);
            this.txt_N.Name = "txt_N";
            this.txt_N.ReadOnly = true;
            this.txt_N.Size = new System.Drawing.Size(100, 31);
            this.txt_N.TabIndex = 22;
            this.txt_N.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F);
            this.label7.Location = new System.Drawing.Point(535, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "＝";
            // 
            // txt_bal
            // 
            this.txt_bal.Font = new System.Drawing.Font("新細明體", 12F);
            this.txt_bal.Location = new System.Drawing.Point(570, 292);
            this.txt_bal.Name = "txt_bal";
            this.txt_bal.ReadOnly = true;
            this.txt_bal.Size = new System.Drawing.Size(100, 31);
            this.txt_bal.TabIndex = 24;
            this.txt_bal.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_startday);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox2.Location = new System.Drawing.Point(609, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 65);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "帳務起算日期";
            // 
            // dtp_startday
            // 
            this.dtp_startday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_startday.Location = new System.Drawing.Point(3, 27);
            this.dtp_startday.Name = "dtp_startday";
            this.dtp_startday.Size = new System.Drawing.Size(178, 31);
            this.dtp_startday.TabIndex = 0;
            this.dtp_startday.ValueChanged += new System.EventHandler(this.dtp_startday_ValueChanged);
            // 
            // Form_firstUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_bal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_N);
            this.Controls.Add(this.lbl_net);
            this.Controls.Add(this.txt_L);
            this.Controls.Add(this.lbl_Liabilities);
            this.Controls.Add(this.lbl_assets);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_finish);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_firstUse";
            this.Text = "初次使用設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_firstUse_FormClosing);
            this.Load += new System.EventHandler(this.Form_firstUse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NewSub)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.DataGridView dgv_NewSub;
        private System.Windows.Forms.Button btn_delsub;
        private System.Windows.Forms.Button btn_addsub;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.Label lbl_assets;
        private System.Windows.Forms.Label lbl_Liabilities;
        private System.Windows.Forms.TextBox txt_L;
        private System.Windows.Forms.Label lbl_net;
        private System.Windows.Forms.TextBox txt_N;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bal;
        private System.Windows.Forms.Button btn_balance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_startday;
    }
}