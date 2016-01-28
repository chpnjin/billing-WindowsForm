namespace 記帳程式_家用版
{
    partial class Form_PL
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
            this.lv_profit = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_loss = new System.Windows.Forms.ListView();
            this.btn_printout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_year = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_year)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_profit);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox1.Location = new System.Drawing.Point(15, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "收入";
            // 
            // lv_profit
            // 
            this.lv_profit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_profit.Font = new System.Drawing.Font("新細明體", 9F);
            this.lv_profit.Location = new System.Drawing.Point(3, 27);
            this.lv_profit.Name = "lv_profit";
            this.lv_profit.Size = new System.Drawing.Size(319, 180);
            this.lv_profit.TabIndex = 0;
            this.lv_profit.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_loss);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox2.Location = new System.Drawing.Point(18, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "支出";
            // 
            // lv_loss
            // 
            this.lv_loss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_loss.Font = new System.Drawing.Font("新細明體", 9F);
            this.lv_loss.Location = new System.Drawing.Point(3, 27);
            this.lv_loss.Name = "lv_loss";
            this.lv_loss.Size = new System.Drawing.Size(316, 180);
            this.lv_loss.TabIndex = 1;
            this.lv_loss.UseCompatibleStateImageBehavior = false;
            // 
            // btn_printout
            // 
            this.btn_printout.Location = new System.Drawing.Point(267, 540);
            this.btn_printout.Name = "btn_printout";
            this.btn_printout.Size = new System.Drawing.Size(75, 31);
            this.btn_printout.TabIndex = 4;
            this.btn_printout.Text = "列印報表";
            this.btn_printout.UseVisualStyleBackColor = true;
            this.btn_printout.Click += new System.EventHandler(this.btn_printout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(162, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "淨所得";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("新細明體", 12F);
            this.txt_total.Location = new System.Drawing.Point(237, 503);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(100, 31);
            this.txt_total.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_show);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nud_year);
            this.groupBox3.Location = new System.Drawing.Point(15, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 52);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "年份選擇";
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("新細明體", 9F);
            this.btn_show.Location = new System.Drawing.Point(237, 18);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(79, 25);
            this.btn_show.TabIndex = 8;
            this.btn_show.Text = "顯示結果";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9F);
            this.label2.Location = new System.Drawing.Point(115, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "年";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9F);
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "西元";
            // 
            // nud_year
            // 
            this.nud_year.Font = new System.Drawing.Font("新細明體", 9F);
            this.nud_year.Location = new System.Drawing.Point(49, 19);
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
            this.nud_year.Size = new System.Drawing.Size(60, 25);
            this.nud_year.TabIndex = 4;
            this.nud_year.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_printout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_PL";
            this.Text = "損益表";
            this.Load += new System.EventHandler(this.Form_PL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_profit;
        private System.Windows.Forms.ListView lv_loss;
        private System.Windows.Forms.Button btn_printout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_year;
        private System.Windows.Forms.Button btn_show;
    }
}