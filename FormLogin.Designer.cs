namespace PRAKTIKUM_DESKTOP_XII_242507007_DIMASGHIFARI
{
    partial class FormLogin
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
            this.textuser = new System.Windows.Forms.TextBox();
            this.labeluser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeljudul = new System.Windows.Forms.Label();
            this.labelpw = new System.Windows.Forms.Label();
            this.textpw = new System.Windows.Forms.TextBox();
            this.butlogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(20, 99);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(192, 20);
            this.textuser.TabIndex = 0;
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.Location = new System.Drawing.Point(16, 72);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(97, 24);
            this.labeluser.TabIndex = 1;
            this.labeluser.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.butlogin);
            this.panel1.Controls.Add(this.textpw);
            this.panel1.Controls.Add(this.labelpw);
            this.panel1.Controls.Add(this.labeljudul);
            this.panel1.Controls.Add(this.textuser);
            this.panel1.Controls.Add(this.labeluser);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 305);
            this.panel1.TabIndex = 2;
            // 
            // labeljudul
            // 
            this.labeljudul.AutoSize = true;
            this.labeljudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljudul.ForeColor = System.Drawing.SystemColors.Control;
            this.labeljudul.Location = new System.Drawing.Point(74, 12);
            this.labeljudul.Name = "labeljudul";
            this.labeljudul.Size = new System.Drawing.Size(92, 29);
            this.labeljudul.TabIndex = 2;
            this.labeljudul.Text = "LOGIN";
            // 
            // labelpw
            // 
            this.labelpw.AutoSize = true;
            this.labelpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpw.Location = new System.Drawing.Point(16, 141);
            this.labelpw.Name = "labelpw";
            this.labelpw.Size = new System.Drawing.Size(92, 24);
            this.labelpw.TabIndex = 3;
            this.labelpw.Text = "Password";
            // 
            // textpw
            // 
            this.textpw.Location = new System.Drawing.Point(20, 168);
            this.textpw.Name = "textpw";
            this.textpw.Size = new System.Drawing.Size(192, 20);
            this.textpw.TabIndex = 4;
            // 
            // butlogin
            // 
            this.butlogin.Location = new System.Drawing.Point(20, 215);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(75, 23);
            this.butlogin.TabIndex = 3;
            this.butlogin.Text = "MASUK";
            this.butlogin.UseVisualStyleBackColor = true;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(152, 215);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Daftar";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelpw;
        private System.Windows.Forms.Label labeljudul;
        private System.Windows.Forms.Button butlogin;
        private System.Windows.Forms.TextBox textpw;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

