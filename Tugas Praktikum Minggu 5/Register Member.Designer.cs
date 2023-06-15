namespace Tugas_Praktikum_Minggu_5
{
    partial class Register_Member
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.rbBronze = new System.Windows.Forms.RadioButton();
            this.rbSilver = new System.Windows.Forms.RadioButton();
            this.rbGold = new System.Windows.Forms.RadioButton();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMember = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbInput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(145, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 43);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(132, 67);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(178, 22);
            this.tbUsername.TabIndex = 2;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(132, 36);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(178, 22);
            this.tbNama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Lengkap :";
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.rbBronze);
            this.gbInput.Controls.Add(this.rbSilver);
            this.gbInput.Controls.Add(this.rbGold);
            this.gbInput.Controls.Add(this.tbAlamat);
            this.gbInput.Controls.Add(this.label5);
            this.gbInput.Controls.Add(this.label4);
            this.gbInput.Controls.Add(this.tbPassword);
            this.gbInput.Controls.Add(this.label3);
            this.gbInput.Controls.Add(this.btnAdd);
            this.gbInput.Controls.Add(this.tbUsername);
            this.gbInput.Controls.Add(this.tbNama);
            this.gbInput.Controls.Add(this.label2);
            this.gbInput.Controls.Add(this.label1);
            this.gbInput.Location = new System.Drawing.Point(12, 12);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(338, 303);
            this.gbInput.TabIndex = 9;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input Member";
            // 
            // rbBronze
            // 
            this.rbBronze.AutoSize = true;
            this.rbBronze.Location = new System.Drawing.Point(132, 222);
            this.rbBronze.Name = "rbBronze";
            this.rbBronze.Size = new System.Drawing.Size(74, 21);
            this.rbBronze.TabIndex = 12;
            this.rbBronze.TabStop = true;
            this.rbBronze.Text = "Bronze";
            this.rbBronze.UseVisualStyleBackColor = true;
            // 
            // rbSilver
            // 
            this.rbSilver.AutoSize = true;
            this.rbSilver.Location = new System.Drawing.Point(132, 192);
            this.rbSilver.Name = "rbSilver";
            this.rbSilver.Size = new System.Drawing.Size(64, 21);
            this.rbSilver.TabIndex = 12;
            this.rbSilver.TabStop = true;
            this.rbSilver.Text = "Silver";
            this.rbSilver.UseVisualStyleBackColor = true;
            // 
            // rbGold
            // 
            this.rbGold.AutoSize = true;
            this.rbGold.Location = new System.Drawing.Point(132, 162);
            this.rbGold.Name = "rbGold";
            this.rbGold.Size = new System.Drawing.Size(59, 21);
            this.rbGold.TabIndex = 12;
            this.rbGold.TabStop = true;
            this.rbGold.Text = "Gold";
            this.rbGold.UseVisualStyleBackColor = true;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(132, 129);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(178, 22);
            this.tbAlamat.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jenis : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alamat : ";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(132, 98);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(178, 22);
            this.tbPassword.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblJenis);
            this.groupBox2.Controls.Add(this.lblAlamat);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblUsername);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblNama);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbMember);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(375, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 408);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Member";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(143, 175);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(13, 17);
            this.lblJenis.TabIndex = 8;
            this.lblJenis.Text = "-";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(143, 140);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(13, 17);
            this.lblAlamat.TabIndex = 8;
            this.lblAlamat.Text = "-";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(143, 106);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(13, 17);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Jenis : ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(143, 71);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(13, 17);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Alamat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Username :";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(143, 36);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(13, 17);
            this.lblNama.TabIndex = 6;
            this.lblNama.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nama Lengkap : ";
            // 
            // lbMember
            // 
            this.lbMember.FormattingEnabled = true;
            this.lbMember.ItemHeight = 16;
            this.lbMember.Location = new System.Drawing.Point(146, 210);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(295, 180);
            this.lbMember.TabIndex = 5;
            this.lbMember.Click += new System.EventHandler(this.lbMember_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "List Member : ";
            // 
            // Register_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbInput);
            this.Name = "Register_Member";
            this.Text = "Register_Member";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_Member_FormClosed);
            this.Load += new System.EventHandler(this.Register_Member_Load);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbBronze;
        private System.Windows.Forms.RadioButton rbSilver;
        private System.Windows.Forms.RadioButton rbGold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbMember;
        private System.Windows.Forms.Label label11;
    }
}