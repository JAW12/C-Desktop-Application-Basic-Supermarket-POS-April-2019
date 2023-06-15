namespace Tugas_Praktikum_Minggu_5
{
    partial class Inventory_Barang
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbJenis = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTambah = new System.Windows.Forms.GroupBox();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.cbKode = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbLihat = new System.Windows.Forms.GroupBox();
            this.lbHabis = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbList = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbInput.SuspendLayout();
            this.gbTambah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            this.gbLihat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(12, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(40, 17);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Save";
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.btnAdd);
            this.gbInput.Controls.Add(this.tbHarga);
            this.gbInput.Controls.Add(this.tbJenis);
            this.gbInput.Controls.Add(this.tbNama);
            this.gbInput.Controls.Add(this.label4);
            this.gbInput.Controls.Add(this.label3);
            this.gbInput.Controls.Add(this.label2);
            this.gbInput.Controls.Add(this.lblKode);
            this.gbInput.Controls.Add(this.label1);
            this.gbInput.Location = new System.Drawing.Point(12, 39);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(338, 204);
            this.gbInput.TabIndex = 1;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input Barang";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(153, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 43);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(127, 118);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(191, 22);
            this.tbHarga.TabIndex = 5;
            // 
            // tbJenis
            // 
            this.tbJenis.Location = new System.Drawing.Point(127, 86);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(191, 22);
            this.tbJenis.TabIndex = 4;
            this.tbJenis.TextChanged += new System.EventHandler(this.tbJenis_TextChanged);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(127, 54);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(191, 22);
            this.tbNama.TabIndex = 3;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Harga Barang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Barang :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Barang :";
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(124, 27);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(13, 17);
            this.lblKode.TabIndex = 2;
            this.lblKode.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode Barang :";
            // 
            // gbTambah
            // 
            this.gbTambah.Controls.Add(this.nudJumlah);
            this.gbTambah.Controls.Add(this.cbKode);
            this.gbTambah.Controls.Add(this.btnInsert);
            this.gbTambah.Controls.Add(this.label7);
            this.gbTambah.Controls.Add(this.label9);
            this.gbTambah.Location = new System.Drawing.Point(15, 249);
            this.gbTambah.Name = "gbTambah";
            this.gbTambah.Size = new System.Drawing.Size(338, 161);
            this.gbTambah.TabIndex = 7;
            this.gbTambah.TabStop = false;
            this.gbTambah.Text = "Tambah Barang";
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(127, 55);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(191, 22);
            this.nudJumlah.TabIndex = 8;
            // 
            // cbKode
            // 
            this.cbKode.FormattingEnabled = true;
            this.cbKode.Location = new System.Drawing.Point(127, 24);
            this.cbKode.Name = "cbKode";
            this.cbKode.Size = new System.Drawing.Size(191, 24);
            this.cbKode.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(150, 106);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(138, 43);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Jumlah :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kode Barang :";
            // 
            // gbLihat
            // 
            this.gbLihat.Controls.Add(this.lbHabis);
            this.gbLihat.Controls.Add(this.label5);
            this.gbLihat.Controls.Add(this.lbList);
            this.gbLihat.Controls.Add(this.label11);
            this.gbLihat.Location = new System.Drawing.Point(377, 39);
            this.gbLihat.Name = "gbLihat";
            this.gbLihat.Size = new System.Drawing.Size(457, 371);
            this.gbLihat.TabIndex = 7;
            this.gbLihat.TabStop = false;
            this.gbLihat.Text = "Lihat Barang";
            // 
            // lbHabis
            // 
            this.lbHabis.FormattingEnabled = true;
            this.lbHabis.ItemHeight = 16;
            this.lbHabis.Location = new System.Drawing.Point(146, 187);
            this.lbHabis.Name = "lbHabis";
            this.lbHabis.Size = new System.Drawing.Size(295, 164);
            this.lbHabis.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Barang Stok Habis :";
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 16;
            this.lbList.Location = new System.Drawing.Point(100, 27);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(341, 148);
            this.lbList.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "List Barang :";
            // 
            // Inventory_Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 421);
            this.Controls.Add(this.gbLihat);
            this.Controls.Add(this.gbTambah);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.lblJudul);
            this.Name = "Inventory_Barang";
            this.Text = "Inventory_Barang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventory_Barang_FormClosed);
            this.Load += new System.EventHandler(this.Inventory_Barang_Load);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.gbTambah.ResumeLayout(false);
            this.gbTambah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            this.gbLihat.ResumeLayout(false);
            this.gbLihat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbJenis;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbTambah;
        private System.Windows.Forms.ComboBox cbKode;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.GroupBox gbLihat;
        private System.Windows.Forms.ListBox lbHabis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.Label label11;
    }
}