namespace PRAKTIKUM_DESKTOP_XII_242507007_DIMASGHIFARI
{
    partial class formDashboard
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
            this.labelnama = new System.Windows.Forms.Label();
            this.labeljabaan = new System.Windows.Forms.Label();
            this.labelshift = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butlogout = new System.Windows.Forms.Button();
            this.labelmunculnama = new System.Windows.Forms.Label();
            this.labelmunculjabatan = new System.Windows.Forms.Label();
            this.labelmunculshift = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnama.Location = new System.Drawing.Point(3, 11);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(202, 29);
            this.labelnama.TabIndex = 0;
            this.labelnama.Text = "Nama Lengkap :";
            // 
            // labeljabaan
            // 
            this.labeljabaan.AutoSize = true;
            this.labeljabaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljabaan.Location = new System.Drawing.Point(3, 58);
            this.labeljabaan.Name = "labeljabaan";
            this.labeljabaan.Size = new System.Drawing.Size(118, 29);
            this.labeljabaan.TabIndex = 1;
            this.labeljabaan.Text = "Jabatan :";
            // 
            // labelshift
            // 
            this.labelshift.AutoSize = true;
            this.labelshift.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelshift.Location = new System.Drawing.Point(3, 106);
            this.labelshift.Name = "labelshift";
            this.labelshift.Size = new System.Drawing.Size(79, 29);
            this.labelshift.TabIndex = 2;
            this.labelshift.Text = "Shift :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelmunculshift);
            this.panel1.Controls.Add(this.labelmunculjabatan);
            this.panel1.Controls.Add(this.labelmunculnama);
            this.panel1.Controls.Add(this.butlogout);
            this.panel1.Controls.Add(this.labelnama);
            this.panel1.Controls.Add(this.labelshift);
            this.panel1.Controls.Add(this.labeljabaan);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 183);
            this.panel1.TabIndex = 3;
            // 
            // butlogout
            // 
            this.butlogout.Location = new System.Drawing.Point(329, 148);
            this.butlogout.Name = "butlogout";
            this.butlogout.Size = new System.Drawing.Size(75, 23);
            this.butlogout.TabIndex = 4;
            this.butlogout.Text = "Logout";
            this.butlogout.UseVisualStyleBackColor = true;
            this.butlogout.Click += new System.EventHandler(this.butlogout_Click);
            // 
            // labelmunculnama
            // 
            this.labelmunculnama.AutoSize = true;
            this.labelmunculnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmunculnama.Location = new System.Drawing.Point(203, 15);
            this.labelmunculnama.Name = "labelmunculnama";
            this.labelmunculnama.Size = new System.Drawing.Size(163, 25);
            this.labelmunculnama.TabIndex = 4;
            this.labelmunculnama.Text = "Nama Lengkap ";
            // 
            // labelmunculjabatan
            // 
            this.labelmunculjabatan.AutoSize = true;
            this.labelmunculjabatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmunculjabatan.Location = new System.Drawing.Point(127, 62);
            this.labelmunculjabatan.Name = "labelmunculjabatan";
            this.labelmunculjabatan.Size = new System.Drawing.Size(89, 25);
            this.labelmunculjabatan.TabIndex = 5;
            this.labelmunculjabatan.Text = "Jabatan";
            // 
            // labelmunculshift
            // 
            this.labelmunculshift.AutoSize = true;
            this.labelmunculshift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmunculshift.Location = new System.Drawing.Point(88, 110);
            this.labelmunculshift.Name = "labelmunculshift";
            this.labelmunculshift.Size = new System.Drawing.Size(55, 25);
            this.labelmunculshift.TabIndex = 6;
            this.labelmunculshift.Text = "Shift";
            // 
            // formDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 215);
            this.Controls.Add(this.panel1);
            this.Name = "formDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDashboard";
            this.Load += new System.EventHandler(this.formDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label labeljabaan;
        private System.Windows.Forms.Label labelshift;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelmunculshift;
        private System.Windows.Forms.Label labelmunculjabatan;
        private System.Windows.Forms.Label labelmunculnama;
        private System.Windows.Forms.Button butlogout;
    }
}