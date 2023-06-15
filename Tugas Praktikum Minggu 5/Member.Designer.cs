namespace Tugas_Praktikum_Minggu_5
{
    partial class Member
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
            this.gbCart = new System.Windows.Forms.GroupBox();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.cbNama = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPoin = new System.Windows.Forms.Label();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            this.gbData.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCart
            // 
            this.gbCart.Controls.Add(this.lbCart);
            this.gbCart.Controls.Add(this.btnAdd);
            this.gbCart.Controls.Add(this.nudJumlah);
            this.gbCart.Controls.Add(this.cbNama);
            this.gbCart.Controls.Add(this.label4);
            this.gbCart.Controls.Add(this.label3);
            this.gbCart.Controls.Add(this.lblHarga);
            this.gbCart.Controls.Add(this.label2);
            this.gbCart.Controls.Add(this.label1);
            this.gbCart.Location = new System.Drawing.Point(13, 13);
            this.gbCart.Name = "gbCart";
            this.gbCart.Size = new System.Drawing.Size(489, 523);
            this.gbCart.TabIndex = 0;
            this.gbCart.TabStop = false;
            this.gbCart.Text = "Cart";
            // 
            // lbCart
            // 
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 16;
            this.lbCart.Location = new System.Drawing.Point(119, 211);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(348, 292);
            this.lbCart.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 51);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(119, 98);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(174, 22);
            this.nudJumlah.TabIndex = 2;
            // 
            // cbNama
            // 
            this.cbNama.FormattingEnabled = true;
            this.cbNama.Location = new System.Drawing.Point(119, 24);
            this.cbNama.Name = "cbNama";
            this.cbNama.Size = new System.Drawing.Size(174, 24);
            this.cbNama.TabIndex = 1;
            this.cbNama.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "In Cart : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jumlah : ";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(121, 63);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(38, 17);
            this.lblHarga.TabIndex = 0;
            this.lblHarga.Text = "Rp 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Harga Barang : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang : ";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.btnEdit);
            this.gbData.Controls.Add(this.label8);
            this.gbData.Controls.Add(this.label7);
            this.gbData.Controls.Add(this.label6);
            this.gbData.Controls.Add(this.lblPoin);
            this.gbData.Controls.Add(this.lblJenis);
            this.gbData.Controls.Add(this.lblAlamat);
            this.gbData.Controls.Add(this.lblNama);
            this.gbData.Controls.Add(this.label5);
            this.gbData.Location = new System.Drawing.Point(541, 13);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(344, 235);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data Diri";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(102, 185);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 34);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Poin : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Jenis : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Alamat : ";
            // 
            // lblPoin
            // 
            this.lblPoin.AutoSize = true;
            this.lblPoin.Location = new System.Drawing.Point(99, 141);
            this.lblPoin.Name = "lblPoin";
            this.lblPoin.Size = new System.Drawing.Size(13, 17);
            this.lblPoin.TabIndex = 0;
            this.lblPoin.Text = "-";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(99, 98);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(13, 17);
            this.lblJenis.TabIndex = 0;
            this.lblJenis.Text = "-";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(99, 63);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(13, 17);
            this.lblAlamat.TabIndex = 0;
            this.lblAlamat.Text = "-";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(99, 27);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(13, 17);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nama :";
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.tbAlamat);
            this.gbEdit.Controls.Add(this.tbPassword);
            this.gbEdit.Controls.Add(this.tbNama);
            this.gbEdit.Controls.Add(this.label12);
            this.gbEdit.Controls.Add(this.label11);
            this.gbEdit.Controls.Add(this.label10);
            this.gbEdit.Controls.Add(this.lblUsername);
            this.gbEdit.Controls.Add(this.label9);
            this.gbEdit.Controls.Add(this.btnUpdate);
            this.gbEdit.Location = new System.Drawing.Point(541, 268);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(344, 268);
            this.gbEdit.TabIndex = 6;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Edit";
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(112, 166);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(202, 22);
            this.tbAlamat.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(112, 120);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(202, 22);
            this.tbPassword.TabIndex = 7;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(112, 77);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(202, 22);
            this.tbNama.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Alamat : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Password : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nama : ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(109, 38);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(13, 17);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Username : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(102, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 34);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 548);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbCart);
            this.Name = "Member";
            this.Text = "Member";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Member_FormClosed);
            this.Load += new System.EventHandler(this.Member_Load);
            this.gbCart.ResumeLayout(false);
            this.gbCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNama;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPoin;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbPassword;
    }
}