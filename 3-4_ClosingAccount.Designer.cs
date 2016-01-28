namespace 記帳程式_家用版
{
    partial class Form_ClosingAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_profit = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_loss = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_closing = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_profit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loss)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "本功能會產生一批交易資料結清所有的收入與支出餘額\r\n並於計算盈虧後自動產生「保留盈餘」科目\r\n若科目已存在則計算餘額並自動加總";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_profit);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "收入";
            // 
            // dgv_profit
            // 
            this.dgv_profit.AllowUserToAddRows = false;
            this.dgv_profit.AllowUserToDeleteRows = false;
            this.dgv_profit.AllowUserToResizeColumns = false;
            this.dgv_profit.AllowUserToResizeRows = false;
            this.dgv_profit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_profit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_profit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_profit.Location = new System.Drawing.Point(3, 18);
            this.dgv_profit.Name = "dgv_profit";
            this.dgv_profit.RowHeadersVisible = false;
            this.dgv_profit.RowTemplate.Height = 27;
            this.dgv_profit.Size = new System.Drawing.Size(234, 169);
            this.dgv_profit.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_loss);
            this.groupBox2.Location = new System.Drawing.Point(258, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 190);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "支出";
            // 
            // dgv_loss
            // 
            this.dgv_loss.AllowUserToAddRows = false;
            this.dgv_loss.AllowUserToDeleteRows = false;
            this.dgv_loss.AllowUserToResizeColumns = false;
            this.dgv_loss.AllowUserToResizeRows = false;
            this.dgv_loss.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_loss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loss.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_loss.Location = new System.Drawing.Point(3, 18);
            this.dgv_loss.Name = "dgv_loss";
            this.dgv_loss.RowHeadersVisible = false;
            this.dgv_loss.RowTemplate.Height = 27;
            this.dgv_loss.Size = new System.Drawing.Size(234, 169);
            this.dgv_loss.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "損益結算：";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(87, 287);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(309, 25);
            this.txt_total.TabIndex = 4;
            // 
            // btn_closing
            // 
            this.btn_closing.Location = new System.Drawing.Point(423, 293);
            this.btn_closing.Name = "btn_closing";
            this.btn_closing.Size = new System.Drawing.Size(75, 23);
            this.btn_closing.TabIndex = 7;
            this.btn_closing.Text = "結帳確認";
            this.btn_closing.UseVisualStyleBackColor = true;
            this.btn_closing.Click += new System.EventHandler(this.btn_closing_Click);
            // 
            // Form_ClosingAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 326);
            this.Controls.Add(this.btn_closing);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_ClosingAccount";
            this.Text = "收支結清";
            this.Load += new System.EventHandler(this.Form_ClosingAccount_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_profit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_profit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_loss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_closing;
    }
}