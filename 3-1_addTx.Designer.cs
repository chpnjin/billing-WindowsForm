namespace 記帳程式_家用版
{
    partial class form_addTx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_addTx));
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Txdate = new System.Windows.Forms.DateTimePicker();
            this.grp_Dr = new System.Windows.Forms.GroupBox();
            this.dgv_D = new System.Windows.Forms.DataGridView();
            this.btn_Dupdate = new System.Windows.Forms.Button();
            this.txt_Dremark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Ddel = new System.Windows.Forms.Button();
            this.btn_Dadd = new System.Windows.Forms.Button();
            this.nud_D = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Dsub = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grp_Cr = new System.Windows.Forms.GroupBox();
            this.dgv_C = new System.Windows.Forms.DataGridView();
            this.btn_Cupdate = new System.Windows.Forms.Button();
            this.txt_Cremark = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Cdel = new System.Windows.Forms.Button();
            this.btn_Cadd = new System.Windows.Forms.Button();
            this.nud_C = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Csub = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bal_D = new System.Windows.Forms.TextBox();
            this.txt_bal_C = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_SelDate = new System.Windows.Forms.Button();
            this.btn_toDatabase = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_lot = new System.Windows.Forms.TextBox();
            this.grp_Dr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_D)).BeginInit();
            this.grp_Cr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_C)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "交易日期";
            // 
            // dtp_Txdate
            // 
            this.dtp_Txdate.Location = new System.Drawing.Point(85, 13);
            this.dtp_Txdate.Name = "dtp_Txdate";
            this.dtp_Txdate.Size = new System.Drawing.Size(146, 25);
            this.dtp_Txdate.TabIndex = 1;
            // 
            // grp_Dr
            // 
            this.grp_Dr.Controls.Add(this.dgv_D);
            this.grp_Dr.Controls.Add(this.btn_Dupdate);
            this.grp_Dr.Controls.Add(this.txt_Dremark);
            this.grp_Dr.Controls.Add(this.label9);
            this.grp_Dr.Controls.Add(this.btn_Ddel);
            this.grp_Dr.Controls.Add(this.btn_Dadd);
            this.grp_Dr.Controls.Add(this.nud_D);
            this.grp_Dr.Controls.Add(this.label3);
            this.grp_Dr.Controls.Add(this.cbo_Dsub);
            this.grp_Dr.Controls.Add(this.label2);
            this.grp_Dr.Enabled = false;
            this.grp_Dr.Font = new System.Drawing.Font("新細明體", 12F);
            this.grp_Dr.Location = new System.Drawing.Point(15, 44);
            this.grp_Dr.Name = "grp_Dr";
            this.grp_Dr.Size = new System.Drawing.Size(400, 375);
            this.grp_Dr.TabIndex = 2;
            this.grp_Dr.TabStop = false;
            this.grp_Dr.Text = "借方";
            // 
            // dgv_D
            // 
            this.dgv_D.AllowUserToAddRows = false;
            this.dgv_D.AllowUserToDeleteRows = false;
            this.dgv_D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_D.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_D.Location = new System.Drawing.Point(3, 122);
            this.dgv_D.MultiSelect = false;
            this.dgv_D.Name = "dgv_D";
            this.dgv_D.ReadOnly = true;
            this.dgv_D.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgv_D.RowTemplate.Height = 27;
            this.dgv_D.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_D.Size = new System.Drawing.Size(394, 250);
            this.dgv_D.TabIndex = 10;
            // 
            // btn_Dupdate
            // 
            this.btn_Dupdate.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_Dupdate.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dupdate.Image")));
            this.btn_Dupdate.Location = new System.Drawing.Point(369, 60);
            this.btn_Dupdate.Name = "btn_Dupdate";
            this.btn_Dupdate.Size = new System.Drawing.Size(25, 25);
            this.btn_Dupdate.TabIndex = 9;
            this.btn_Dupdate.UseVisualStyleBackColor = true;
            this.btn_Dupdate.Click += new System.EventHandler(this.btn_Dupdate_Click);
            // 
            // txt_Dremark
            // 
            this.txt_Dremark.Font = new System.Drawing.Font("新細明體", 9F);
            this.txt_Dremark.Location = new System.Drawing.Point(50, 91);
            this.txt_Dremark.Name = "txt_Dremark";
            this.txt_Dremark.Size = new System.Drawing.Size(313, 25);
            this.txt_Dremark.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 9F);
            this.label9.Location = new System.Drawing.Point(6, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "備註";
            // 
            // btn_Ddel
            // 
            this.btn_Ddel.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_Ddel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ddel.Image")));
            this.btn_Ddel.Location = new System.Drawing.Point(369, 91);
            this.btn_Ddel.Name = "btn_Ddel";
            this.btn_Ddel.Size = new System.Drawing.Size(25, 25);
            this.btn_Ddel.TabIndex = 6;
            this.btn_Ddel.UseVisualStyleBackColor = true;
            this.btn_Ddel.Click += new System.EventHandler(this.btn_Ddel_Click);
            // 
            // btn_Dadd
            // 
            this.btn_Dadd.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_Dadd.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dadd.Image")));
            this.btn_Dadd.Location = new System.Drawing.Point(369, 25);
            this.btn_Dadd.Name = "btn_Dadd";
            this.btn_Dadd.Size = new System.Drawing.Size(25, 25);
            this.btn_Dadd.TabIndex = 5;
            this.btn_Dadd.UseVisualStyleBackColor = true;
            this.btn_Dadd.Click += new System.EventHandler(this.btn_Dadd_Click);
            // 
            // nud_D
            // 
            this.nud_D.Font = new System.Drawing.Font("新細明體", 9F);
            this.nud_D.Location = new System.Drawing.Point(50, 60);
            this.nud_D.Name = "nud_D";
            this.nud_D.Size = new System.Drawing.Size(313, 25);
            this.nud_D.TabIndex = 3;
            this.nud_D.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9F);
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "金額";
            // 
            // cbo_Dsub
            // 
            this.cbo_Dsub.Font = new System.Drawing.Font("新細明體", 9F);
            this.cbo_Dsub.FormattingEnabled = true;
            this.cbo_Dsub.Location = new System.Drawing.Point(50, 27);
            this.cbo_Dsub.Name = "cbo_Dsub";
            this.cbo_Dsub.Size = new System.Drawing.Size(313, 23);
            this.cbo_Dsub.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9F);
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "科目";
            // 
            // grp_Cr
            // 
            this.grp_Cr.Controls.Add(this.dgv_C);
            this.grp_Cr.Controls.Add(this.btn_Cupdate);
            this.grp_Cr.Controls.Add(this.txt_Cremark);
            this.grp_Cr.Controls.Add(this.label10);
            this.grp_Cr.Controls.Add(this.btn_Cdel);
            this.grp_Cr.Controls.Add(this.btn_Cadd);
            this.grp_Cr.Controls.Add(this.nud_C);
            this.grp_Cr.Controls.Add(this.label4);
            this.grp_Cr.Controls.Add(this.cbo_Csub);
            this.grp_Cr.Controls.Add(this.label5);
            this.grp_Cr.Enabled = false;
            this.grp_Cr.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grp_Cr.Location = new System.Drawing.Point(421, 44);
            this.grp_Cr.Name = "grp_Cr";
            this.grp_Cr.Size = new System.Drawing.Size(400, 375);
            this.grp_Cr.TabIndex = 3;
            this.grp_Cr.TabStop = false;
            this.grp_Cr.Text = "貸方";
            // 
            // dgv_C
            // 
            this.dgv_C.AllowUserToAddRows = false;
            this.dgv_C.AllowUserToDeleteRows = false;
            this.dgv_C.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_C.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_C.Location = new System.Drawing.Point(3, 122);
            this.dgv_C.MultiSelect = false;
            this.dgv_C.Name = "dgv_C";
            this.dgv_C.ReadOnly = true;
            this.dgv_C.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgv_C.RowTemplate.Height = 27;
            this.dgv_C.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_C.Size = new System.Drawing.Size(394, 250);
            this.dgv_C.TabIndex = 11;
            // 
            // btn_Cupdate
            // 
            this.btn_Cupdate.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_Cupdate.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cupdate.Image")));
            this.btn_Cupdate.Location = new System.Drawing.Point(369, 61);
            this.btn_Cupdate.Name = "btn_Cupdate";
            this.btn_Cupdate.Size = new System.Drawing.Size(25, 25);
            this.btn_Cupdate.TabIndex = 10;
            this.btn_Cupdate.UseVisualStyleBackColor = true;
            this.btn_Cupdate.Click += new System.EventHandler(this.btn_Cupdate_Click);
            // 
            // txt_Cremark
            // 
            this.txt_Cremark.Font = new System.Drawing.Font("新細明體", 9F);
            this.txt_Cremark.Location = new System.Drawing.Point(50, 91);
            this.txt_Cremark.Name = "txt_Cremark";
            this.txt_Cremark.Size = new System.Drawing.Size(313, 25);
            this.txt_Cremark.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 9F);
            this.label10.Location = new System.Drawing.Point(7, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "備註";
            // 
            // btn_Cdel
            // 
            this.btn_Cdel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cdel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cdel.Image")));
            this.btn_Cdel.Location = new System.Drawing.Point(369, 92);
            this.btn_Cdel.Name = "btn_Cdel";
            this.btn_Cdel.Size = new System.Drawing.Size(25, 25);
            this.btn_Cdel.TabIndex = 6;
            this.btn_Cdel.UseVisualStyleBackColor = true;
            this.btn_Cdel.Click += new System.EventHandler(this.btn_Cdel_Click);
            // 
            // btn_Cadd
            // 
            this.btn_Cadd.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cadd.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cadd.Image")));
            this.btn_Cadd.Location = new System.Drawing.Point(369, 30);
            this.btn_Cadd.Name = "btn_Cadd";
            this.btn_Cadd.Size = new System.Drawing.Size(25, 25);
            this.btn_Cadd.TabIndex = 5;
            this.btn_Cadd.UseVisualStyleBackColor = true;
            this.btn_Cadd.Click += new System.EventHandler(this.btn_Cadd_Click);
            // 
            // nud_C
            // 
            this.nud_C.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nud_C.Location = new System.Drawing.Point(50, 60);
            this.nud_C.Name = "nud_C";
            this.nud_C.Size = new System.Drawing.Size(313, 25);
            this.nud_C.TabIndex = 3;
            this.nud_C.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(7, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "金額";
            // 
            // cbo_Csub
            // 
            this.cbo_Csub.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbo_Csub.FormattingEnabled = true;
            this.cbo_Csub.Location = new System.Drawing.Point(50, 30);
            this.cbo_Csub.Name = "cbo_Csub";
            this.cbo_Csub.Size = new System.Drawing.Size(313, 23);
            this.cbo_Csub.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(7, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "科目";
            // 
            // txt_bal_D
            // 
            this.txt_bal_D.Font = new System.Drawing.Font("新細明體", 16F);
            this.txt_bal_D.Location = new System.Drawing.Point(65, 434);
            this.txt_bal_D.Name = "txt_bal_D";
            this.txt_bal_D.ReadOnly = true;
            this.txt_bal_D.Size = new System.Drawing.Size(140, 39);
            this.txt_bal_D.TabIndex = 4;
            this.txt_bal_D.TextChanged += new System.EventHandler(this.txt_bal_D_TextChanged);
            // 
            // txt_bal_C
            // 
            this.txt_bal_C.Font = new System.Drawing.Font("新細明體", 16F);
            this.txt_bal_C.Location = new System.Drawing.Point(299, 434);
            this.txt_bal_C.Name = "txt_bal_C";
            this.txt_bal_C.ReadOnly = true;
            this.txt_bal_C.Size = new System.Drawing.Size(140, 39);
            this.txt_bal_C.TabIndex = 5;
            this.txt_bal_C.TextChanged += new System.EventHandler(this.txt_bal_D_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 20F);
            this.label6.Location = new System.Drawing.Point(10, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = "借";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 20F);
            this.label7.Location = new System.Drawing.Point(210, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 34);
            this.label7.TabIndex = 7;
            this.label7.Text = "－貸";
            // 
            // btn_SelDate
            // 
            this.btn_SelDate.Location = new System.Drawing.Point(237, 15);
            this.btn_SelDate.Name = "btn_SelDate";
            this.btn_SelDate.Size = new System.Drawing.Size(49, 23);
            this.btn_SelDate.TabIndex = 9;
            this.btn_SelDate.Text = "確定";
            this.btn_SelDate.UseVisualStyleBackColor = true;
            this.btn_SelDate.Click += new System.EventHandler(this.btn_SelDate_Click);
            // 
            // btn_toDatabase
            // 
            this.btn_toDatabase.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_toDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btn_toDatabase.Image")));
            this.btn_toDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_toDatabase.Location = new System.Drawing.Point(625, 422);
            this.btn_toDatabase.Name = "btn_toDatabase";
            this.btn_toDatabase.Size = new System.Drawing.Size(196, 57);
            this.btn_toDatabase.TabIndex = 8;
            this.btn_toDatabase.Text = "新增完成";
            this.btn_toDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_toDatabase.UseVisualStyleBackColor = true;
            this.btn_toDatabase.Click += new System.EventHandler(this.btn_toDatabase_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 20F);
            this.label8.Location = new System.Drawing.Point(445, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 34);
            this.label8.TabIndex = 10;
            this.label8.Text = "=";
            // 
            // txt_balance
            // 
            this.txt_balance.Font = new System.Drawing.Font("新細明體", 16F);
            this.txt_balance.Location = new System.Drawing.Point(484, 431);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.ReadOnly = true;
            this.txt_balance.Size = new System.Drawing.Size(118, 39);
            this.txt_balance.TabIndex = 11;
            this.txt_balance.TextChanged += new System.EventHandler(this.txt_balance_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "批次";
            // 
            // txt_lot
            // 
            this.txt_lot.Enabled = false;
            this.txt_lot.Location = new System.Drawing.Point(348, 13);
            this.txt_lot.Name = "txt_lot";
            this.txt_lot.Size = new System.Drawing.Size(42, 25);
            this.txt_lot.TabIndex = 13;
            // 
            // form_addTx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 490);
            this.Controls.Add(this.txt_lot);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_SelDate);
            this.Controls.Add(this.btn_toDatabase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_bal_C);
            this.Controls.Add(this.txt_bal_D);
            this.Controls.Add(this.grp_Cr);
            this.Controls.Add(this.grp_Dr);
            this.Controls.Add(this.dtp_Txdate);
            this.Controls.Add(this.label1);
            this.Name = "form_addTx";
            this.Text = "新增交易";
            this.Load += new System.EventHandler(this.form_addTx_Load);
            this.grp_Dr.ResumeLayout(false);
            this.grp_Dr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_D)).EndInit();
            this.grp_Cr.ResumeLayout(false);
            this.grp_Cr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_C)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Txdate;
        private System.Windows.Forms.GroupBox grp_Dr;
        private System.Windows.Forms.Button btn_Ddel;
        private System.Windows.Forms.Button btn_Dadd;
        private System.Windows.Forms.NumericUpDown nud_D;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Dsub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grp_Cr;
        private System.Windows.Forms.Button btn_Cdel;
        private System.Windows.Forms.Button btn_Cadd;
        private System.Windows.Forms.NumericUpDown nud_C;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Csub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bal_D;
        private System.Windows.Forms.TextBox txt_bal_C;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_toDatabase;
        private System.Windows.Forms.Button btn_SelDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.TextBox txt_Dremark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Cremark;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Dupdate;
        private System.Windows.Forms.Button btn_Cupdate;
        private System.Windows.Forms.DataGridView dgv_D;
        private System.Windows.Forms.DataGridView dgv_C;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_lot;
    }
}