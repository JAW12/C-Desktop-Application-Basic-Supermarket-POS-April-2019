namespace Tugas_Praktikum_Minggu_5
{
    partial class Input_Penjualan
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.lbBarang = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDiskon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSedia = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barang :";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(103, 10);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(138, 24);
            this.cbCustomer.TabIndex = 1;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // lbBarang
            // 
            this.lbBarang.FormattingEnabled = true;
            this.lbBarang.ItemHeight = 16;
            this.lbBarang.Location = new System.Drawing.Point(103, 54);
            this.lbBarang.Name = "lbBarang";
            this.lbBarang.Size = new System.Drawing.Size(307, 228);
            this.lbBarang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Diskon :";
            // 
            // lblDiskon
            // 
            this.lblDiskon.AutoSize = true;
            this.lblDiskon.Location = new System.Drawing.Point(100, 296);
            this.lblDiskon.Name = "lblDiskon";
            this.lblDiskon.Size = new System.Drawing.Size(13, 17);
            this.lblDiskon.TabIndex = 0;
            this.lblDiskon.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "TOTAL :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(100, 332);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 17);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "-";
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(103, 362);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(138, 43);
            this.btnBayar.TabIndex = 7;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Barang Sedia : ";
            // 
            // lbSedia
            // 
            this.lbSedia.FormattingEnabled = true;
            this.lbSedia.ItemHeight = 16;
            this.lbSedia.Location = new System.Drawing.Point(540, 13);
            this.lbSedia.Name = "lbSedia";
            this.lbSedia.Size = new System.Drawing.Size(307, 228);
            this.lbSedia.TabIndex = 8;
            // 
            // Input_Penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 417);
            this.Controls.Add(this.lbSedia);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.lbBarang);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDiskon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Input_Penjualan";
            this.Text = "Input_Penjualan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Input_Penjualan_FormClosed);
            this.Load += new System.EventHandler(this.Input_Penjualan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ListBox lbBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDiskon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbSedia;
    }
}