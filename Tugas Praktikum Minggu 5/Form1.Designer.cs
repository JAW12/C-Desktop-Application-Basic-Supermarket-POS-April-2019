namespace Tugas_Praktikum_Minggu_5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoadPegawai = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLoadBarang = new System.Windows.Forms.Button();
            this.btnLoadMember = new System.Windows.Forms.Button();
            this.btnLoadSemua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.SystemColors.Control;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(256, 61);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(217, 69);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "LOGIN";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(107, 203);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(186, 38);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username :";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(335, 205);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(318, 38);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(335, 274);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(318, 38);
            this.tbPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(107, 272);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(180, 38);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password :";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(284, 373);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(168, 69);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLoadPegawai
            // 
            this.btnLoadPegawai.Location = new System.Drawing.Point(604, 48);
            this.btnLoadPegawai.Name = "btnLoadPegawai";
            this.btnLoadPegawai.Size = new System.Drawing.Size(150, 30);
            this.btnLoadPegawai.TabIndex = 6;
            this.btnLoadPegawai.Text = "Load XML Pegawai";
            this.btnLoadPegawai.UseVisualStyleBackColor = true;
            this.btnLoadPegawai.Click += new System.EventHandler(this.btnLoadPegawai_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLoadBarang
            // 
            this.btnLoadBarang.Location = new System.Drawing.Point(604, 12);
            this.btnLoadBarang.Name = "btnLoadBarang";
            this.btnLoadBarang.Size = new System.Drawing.Size(150, 30);
            this.btnLoadBarang.TabIndex = 6;
            this.btnLoadBarang.Text = "Load XML Barang";
            this.btnLoadBarang.UseVisualStyleBackColor = true;
            this.btnLoadBarang.Click += new System.EventHandler(this.btnLoadBarang_Click);
            // 
            // btnLoadMember
            // 
            this.btnLoadMember.Location = new System.Drawing.Point(604, 84);
            this.btnLoadMember.Name = "btnLoadMember";
            this.btnLoadMember.Size = new System.Drawing.Size(150, 30);
            this.btnLoadMember.TabIndex = 6;
            this.btnLoadMember.Text = "Load XML Member";
            this.btnLoadMember.UseVisualStyleBackColor = true;
            this.btnLoadMember.Click += new System.EventHandler(this.btnLoadMember_Click);
            // 
            // btnLoadSemua
            // 
            this.btnLoadSemua.Location = new System.Drawing.Point(604, 120);
            this.btnLoadSemua.Name = "btnLoadSemua";
            this.btnLoadSemua.Size = new System.Drawing.Size(150, 30);
            this.btnLoadSemua.TabIndex = 6;
            this.btnLoadSemua.Text = "Load XML Semua";
            this.btnLoadSemua.UseVisualStyleBackColor = true;
            this.btnLoadSemua.Click += new System.EventHandler(this.btnLoadSemua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(766, 536);
            this.Controls.Add(this.btnLoadSemua);
            this.Controls.Add(this.btnLoadMember);
            this.Controls.Add(this.btnLoadBarang);
            this.Controls.Add(this.btnLoadPegawai);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoadPegawai;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLoadBarang;
        private System.Windows.Forms.Button btnLoadMember;
        private System.Windows.Forms.Button btnLoadSemua;
    }
}

