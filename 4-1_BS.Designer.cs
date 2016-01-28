namespace 記帳程式_家用版
{
    partial class Form_BS
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
            this.lv_Assets = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_Liabilities = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_Net = new System.Windows.Forms.ListView();
            this.btn_printout = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_year = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_year)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_Assets);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "資產";
            // 
            // lv_Assets
            // 
            this.lv_Assets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Assets.Font = new System.Drawing.Font("新細明體", 9F);
            this.lv_Assets.Location = new System.Drawing.Point(3, 27);
            this.lv_Assets.Name = "lv_Assets";
            this.lv_Assets.Size = new System.Drawing.Size(222, 344);
            this.lv_Assets.TabIndex = 0;
            this.lv_Assets.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_Liabilities);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox2.Location = new System.Drawing.Point(250, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "負債";
            // 
            // lv_Liabilities
            // 
            this.lv_Liabilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Liabilities.Font = new System.Drawing.Font("新細明體", 9F);
            this.lv_Liabilities.Location = new System.Drawing.Point(3, 27);
            this.lv_Liabilities.Name = "lv_Liabilities";
            this.lv_Liabilities.Size = new System.Drawing.Size(225, 152);
            this.lv_Liabilities.TabIndex = 0;
            this.lv_Liabilities.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lv_Net);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox3.Location = new System.Drawing.Point(250, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 186);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "淨值";
            // 
            // lv_Net
            // 
            this.lv_Net.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Net.Font = new System.Drawing.Font("新細明體", 9F);
            this.lv_Net.Location = new System.Drawing.Point(3, 27);
            this.lv_Net.Name = "lv_Net";
            this.lv_Net.Size = new System.Drawing.Size(225, 156);
            this.lv_Net.TabIndex = 0;
            this.lv_Net.UseCompatibleStateImageBehavior = false;
            // 
            // btn_printout
            // 
            this.btn_printout.Location = new System.Drawing.Point(406, 473);
            this.btn_printout.Name = "btn_printout";
            this.btn_printout.Size = new System.Drawing.Size(75, 31);
            this.btn_printout.TabIndex = 3;
            this.btn_printout.Text = "列印報表";
            this.btn_printout.UseVisualStyleBackColor = true;
            this.btn_printout.Click += new System.EventHandler(this.btn_printout_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_show);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.nud_year);
            this.groupBox4.Location = new System.Drawing.Point(12, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(469, 73);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "選擇年分";
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_show.Location = new System.Drawing.Point(363, 26);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(100, 29);
            this.btn_show.TabIndex = 4;
            this.btn_show.Text = "顯示結果";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(175, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "年";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "西元";
            // 
            // nud_year
            // 
            this.nud_year.Font = new System.Drawing.Font("新細明體", 12F);
            this.nud_year.Location = new System.Drawing.Point(85, 24);
            this.nud_year.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_year.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_year.Name = "nud_year";
            this.nud_year.Size = new System.Drawing.Size(75, 31);
            this.nud_year.TabIndex = 0;
            this.nud_year.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form_BS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 516);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_printout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_BS";
            this.Text = "資產負債表";
            this.Load += new System.EventHandler(this.Form_BS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_year)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lv_Assets;
        private System.Windows.Forms.ListView lv_Liabilities;
        private System.Windows.Forms.ListView lv_Net;
        private System.Windows.Forms.Button btn_printout;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_year;
    }
}