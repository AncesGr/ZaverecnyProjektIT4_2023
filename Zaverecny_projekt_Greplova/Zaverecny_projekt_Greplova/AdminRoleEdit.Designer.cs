namespace Zaverecny_projekt_Greplova
{
    partial class AdminRoleEdit
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
            this.txtAdmRoleEditName = new System.Windows.Forms.TextBox();
            this.lblAdmRoleEditName = new System.Windows.Forms.Label();
            this.btnAdmRoleEditOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdmRoleEditName
            // 
            this.txtAdmRoleEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdmRoleEditName.Location = new System.Drawing.Point(12, 54);
            this.txtAdmRoleEditName.Name = "txtAdmRoleEditName";
            this.txtAdmRoleEditName.Size = new System.Drawing.Size(237, 30);
            this.txtAdmRoleEditName.TabIndex = 4;
            // 
            // lblAdmRoleEditName
            // 
            this.lblAdmRoleEditName.AutoSize = true;
            this.lblAdmRoleEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmRoleEditName.Location = new System.Drawing.Point(12, 25);
            this.lblAdmRoleEditName.Name = "lblAdmRoleEditName";
            this.lblAdmRoleEditName.Size = new System.Drawing.Size(105, 25);
            this.lblAdmRoleEditName.TabIndex = 3;
            this.lblAdmRoleEditName.Text = "Role name";
            // 
            // btnAdmRoleEditOK
            // 
            this.btnAdmRoleEditOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdmRoleEditOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmRoleEditOK.Location = new System.Drawing.Point(160, 112);
            this.btnAdmRoleEditOK.Name = "btnAdmRoleEditOK";
            this.btnAdmRoleEditOK.Size = new System.Drawing.Size(89, 36);
            this.btnAdmRoleEditOK.TabIndex = 7;
            this.btnAdmRoleEditOK.Text = "OK";
            this.btnAdmRoleEditOK.UseVisualStyleBackColor = false;
            this.btnAdmRoleEditOK.Click += new System.EventHandler(this.btnAdmRoleEditOK_Click);
            // 
            // AdminRoleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 172);
            this.Controls.Add(this.btnAdmRoleEditOK);
            this.Controls.Add(this.txtAdmRoleEditName);
            this.Controls.Add(this.lblAdmRoleEditName);
            this.Name = "AdminRoleEdit";
            this.Text = "Role Edit";
            this.Load += new System.EventHandler(this.AdminRoleEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAdmRoleEditName;
        private System.Windows.Forms.Label lblAdmRoleEditName;
        private System.Windows.Forms.Button btnAdmRoleEditOK;
    }
}