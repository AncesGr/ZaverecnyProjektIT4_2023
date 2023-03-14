namespace Zaverecny_projekt_Greplova
{
    partial class AdminUserEdit
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
            this.lblAdmEditName = new System.Windows.Forms.Label();
            this.txtAdmEditName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmEditPassword = new System.Windows.Forms.Button();
            this.btnAdmEditOK = new System.Windows.Forms.Button();
            this.cmbEditRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAdmEditName
            // 
            this.lblAdmEditName.AutoSize = true;
            this.lblAdmEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmEditName.Location = new System.Drawing.Point(12, 20);
            this.lblAdmEditName.Name = "lblAdmEditName";
            this.lblAdmEditName.Size = new System.Drawing.Size(107, 25);
            this.lblAdmEditName.TabIndex = 0;
            this.lblAdmEditName.Text = "User name";
            // 
            // txtAdmEditName
            // 
            this.txtAdmEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdmEditName.Location = new System.Drawing.Point(17, 48);
            this.txtAdmEditName.Name = "txtAdmEditName";
            this.txtAdmEditName.Size = new System.Drawing.Size(196, 30);
            this.txtAdmEditName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role";
            // 
            // btnAdmEditPassword
            // 
            this.btnAdmEditPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmEditPassword.ForeColor = System.Drawing.Color.Black;
            this.btnAdmEditPassword.Location = new System.Drawing.Point(17, 197);
            this.btnAdmEditPassword.Name = "btnAdmEditPassword";
            this.btnAdmEditPassword.Size = new System.Drawing.Size(196, 36);
            this.btnAdmEditPassword.TabIndex = 4;
            this.btnAdmEditPassword.Text = "Reset password";
            this.btnAdmEditPassword.UseVisualStyleBackColor = true;
            this.btnAdmEditPassword.Click += new System.EventHandler(this.btnAdmEditPassword_Click);
            // 
            // btnAdmEditOK
            // 
            this.btnAdmEditOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmEditOK.Location = new System.Drawing.Point(236, 197);
            this.btnAdmEditOK.Name = "btnAdmEditOK";
            this.btnAdmEditOK.Size = new System.Drawing.Size(84, 36);
            this.btnAdmEditOK.TabIndex = 5;
            this.btnAdmEditOK.Text = "OK";
            this.btnAdmEditOK.UseVisualStyleBackColor = true;
            this.btnAdmEditOK.Click += new System.EventHandler(this.btnAdmEditOK_Click);
            // 
            // cmbEditRole
            // 
            this.cmbEditRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbEditRole.FormattingEnabled = true;
            this.cmbEditRole.Location = new System.Drawing.Point(17, 145);
            this.cmbEditRole.Name = "cmbEditRole";
            this.cmbEditRole.Size = new System.Drawing.Size(196, 33);
            this.cmbEditRole.TabIndex = 6;
            // 
            // AdminUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 257);
            this.Controls.Add(this.cmbEditRole);
            this.Controls.Add(this.btnAdmEditOK);
            this.Controls.Add(this.btnAdmEditPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdmEditName);
            this.Controls.Add(this.lblAdmEditName);
            this.Name = "AdminUserEdit";
            this.Text = "AdminUserEdit";
            this.Load += new System.EventHandler(this.AdminUserEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmEditName;
        private System.Windows.Forms.TextBox txtAdmEditName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmEditPassword;
        private System.Windows.Forms.Button btnAdmEditOK;
        private System.Windows.Forms.ComboBox cmbEditRole;
    }
}