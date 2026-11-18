namespace PRAKTIKUM_DESKTOP_XII_242507007_DIMASGHIFARI
{
    partial class FormRegister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.butdaftar = new System.Windows.Forms.Button();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textpw = new System.Windows.Forms.TextBox();
            this.labelpw = new System.Windows.Forms.Label();
            this.labeljudul = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.labeluser = new System.Windows.Forms.Label();
            this.textkonfirpw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textnamapetugas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbshift = new System.Windows.Forms.ComboBox();
            this.labelshift = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cmbshift);
            this.panel1.Controls.Add(this.labelshift);
            this.panel1.Controls.Add(this.textnamapetugas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textkonfirpw);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.butdaftar);
            this.panel1.Controls.Add(this.cmbrole);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textpw);
            this.panel1.Controls.Add(this.labelpw);
            this.panel1.Controls.Add(this.labeljudul);
            this.panel1.Controls.Add(this.textuser);
            this.panel1.Controls.Add(this.labeluser);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 426);
            this.panel1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(147, 387);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 20);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // butdaftar
            // 
            this.butdaftar.Location = new System.Drawing.Point(20, 387);
            this.butdaftar.Name = "butdaftar";
            this.butdaftar.Size = new System.Drawing.Size(75, 33);
            this.butdaftar.TabIndex = 3;
            this.butdaftar.Text = "DAFTAR";
            this.butdaftar.UseVisualStyleBackColor = true;
            this.butdaftar.Click += new System.EventHandler(this.butdaftar_Click);
            // 
            // cmbrole
            // 
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Items.AddRange(new object[] {
            "Apoteker",
            "Asisten Apoteker",
            "Kasir Apoteker"});
            this.cmbrole.Location = new System.Drawing.Point(20, 335);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(192, 21);
            this.cmbrole.TabIndex = 13;
            this.cmbrole.SelectedIndexChanged += new System.EventHandler(this.cmbrole_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Role";
            // 
            // textpw
            // 
            this.textpw.Location = new System.Drawing.Point(20, 123);
            this.textpw.Name = "textpw";
            this.textpw.PasswordChar = '*';
            this.textpw.Size = new System.Drawing.Size(192, 20);
            this.textpw.TabIndex = 4;
            // 
            // labelpw
            // 
            this.labelpw.AutoSize = true;
            this.labelpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpw.Location = new System.Drawing.Point(16, 96);
            this.labelpw.Name = "labelpw";
            this.labelpw.Size = new System.Drawing.Size(92, 24);
            this.labelpw.TabIndex = 3;
            this.labelpw.Text = "Password";
            // 
            // labeljudul
            // 
            this.labeljudul.AutoSize = true;
            this.labeljudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljudul.ForeColor = System.Drawing.SystemColors.Control;
            this.labeljudul.Location = new System.Drawing.Point(39, 16);
            this.labeljudul.Name = "labeljudul";
            this.labeljudul.Size = new System.Drawing.Size(191, 29);
            this.labeljudul.TabIndex = 2;
            this.labeljudul.Text = "DAFTAR AKUN";
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(20, 71);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(192, 20);
            this.textuser.TabIndex = 0;
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.Location = new System.Drawing.Point(16, 44);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(97, 24);
            this.labeluser.TabIndex = 1;
            this.labeluser.Text = "Username";
            // 
            // textkonfirpw
            // 
            this.textkonfirpw.Location = new System.Drawing.Point(20, 174);
            this.textkonfirpw.Name = "textkonfirpw";
            this.textkonfirpw.PasswordChar = '*';
            this.textkonfirpw.Size = new System.Drawing.Size(192, 20);
            this.textkonfirpw.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Konfirmasi Password";
            // 
            // textnamapetugas
            // 
            this.textnamapetugas.Location = new System.Drawing.Point(20, 225);
            this.textnamapetugas.Name = "textnamapetugas";
            this.textnamapetugas.Size = new System.Drawing.Size(192, 20);
            this.textnamapetugas.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nama Petugas";
            // 
            // cmbshift
            // 
            this.cmbshift.FormattingEnabled = true;
            this.cmbshift.Items.AddRange(new object[] {
            "Pagi",
            "Siang",
            "malam"});
            this.cmbshift.Location = new System.Drawing.Point(20, 279);
            this.cmbshift.Name = "cmbshift";
            this.cmbshift.Size = new System.Drawing.Size(192, 21);
            this.cmbshift.TabIndex = 19;
            // 
            // labelshift
            // 
            this.labelshift.AutoSize = true;
            this.labelshift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelshift.Location = new System.Drawing.Point(16, 252);
            this.labelshift.Name = "labelshift";
            this.labelshift.Size = new System.Drawing.Size(45, 24);
            this.labelshift.TabIndex = 18;
            this.labelshift.Text = "Shift";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butdaftar;
        private System.Windows.Forms.TextBox textpw;
        private System.Windows.Forms.Label labelpw;
        private System.Windows.Forms.Label labeljudul;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textkonfirpw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textnamapetugas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbshift;
        private System.Windows.Forms.Label labelshift;
    }
}