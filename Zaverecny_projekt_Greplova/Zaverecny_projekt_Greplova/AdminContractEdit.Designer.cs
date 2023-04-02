namespace Zaverecny_projekt_Greplova
{
    partial class AdminContractEdit
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
            this.btnAdmContractEditOK = new System.Windows.Forms.Button();
            this.txtAdmContractEditDescription = new System.Windows.Forms.RichTextBox();
            this.lblAdmContractEditDescription = new System.Windows.Forms.Label();
            this.txtAdmContractEditName = new System.Windows.Forms.TextBox();
            this.lblAdmContractEditName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmContractEditOK
            // 
            this.btnAdmContractEditOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdmContractEditOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmContractEditOK.Location = new System.Drawing.Point(245, 199);
            this.btnAdmContractEditOK.Name = "btnAdmContractEditOK";
            this.btnAdmContractEditOK.Size = new System.Drawing.Size(94, 42);
            this.btnAdmContractEditOK.TabIndex = 10;
            this.btnAdmContractEditOK.Text = "OK";
            this.btnAdmContractEditOK.UseVisualStyleBackColor = false;
            this.btnAdmContractEditOK.Click += new System.EventHandler(this.btnAdmContractEditOK_Click);
            // 
            // txtAdmContractEditDescription
            // 
            this.txtAdmContractEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdmContractEditDescription.Location = new System.Drawing.Point(28, 125);
            this.txtAdmContractEditDescription.Name = "txtAdmContractEditDescription";
            this.txtAdmContractEditDescription.Size = new System.Drawing.Size(311, 54);
            this.txtAdmContractEditDescription.TabIndex = 9;
            this.txtAdmContractEditDescription.Text = "";
            // 
            // lblAdmContractEditDescription
            // 
            this.lblAdmContractEditDescription.AutoSize = true;
            this.lblAdmContractEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmContractEditDescription.Location = new System.Drawing.Point(25, 95);
            this.lblAdmContractEditDescription.Name = "lblAdmContractEditDescription";
            this.lblAdmContractEditDescription.Size = new System.Drawing.Size(185, 25);
            this.lblAdmContractEditDescription.TabIndex = 8;
            this.lblAdmContractEditDescription.Text = "Contract description";
            // 
            // txtAdmContractEditName
            // 
            this.txtAdmContractEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdmContractEditName.Location = new System.Drawing.Point(28, 56);
            this.txtAdmContractEditName.Name = "txtAdmContractEditName";
            this.txtAdmContractEditName.Size = new System.Drawing.Size(311, 30);
            this.txtAdmContractEditName.TabIndex = 7;
            // 
            // lblAdmContractEditName
            // 
            this.lblAdmContractEditName.AutoSize = true;
            this.lblAdmContractEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmContractEditName.Location = new System.Drawing.Point(25, 27);
            this.lblAdmContractEditName.Name = "lblAdmContractEditName";
            this.lblAdmContractEditName.Size = new System.Drawing.Size(143, 25);
            this.lblAdmContractEditName.TabIndex = 6;
            this.lblAdmContractEditName.Text = "Contract Name";
            // 
            // AdminContractEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 267);
            this.Controls.Add(this.btnAdmContractEditOK);
            this.Controls.Add(this.txtAdmContractEditDescription);
            this.Controls.Add(this.lblAdmContractEditDescription);
            this.Controls.Add(this.txtAdmContractEditName);
            this.Controls.Add(this.lblAdmContractEditName);
            this.Name = "AdminContractEdit";
            this.Text = "Contract Edit";
            this.Load += new System.EventHandler(this.AdminContractEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmContractEditOK;
        private System.Windows.Forms.RichTextBox txtAdmContractEditDescription;
        private System.Windows.Forms.Label lblAdmContractEditDescription;
        private System.Windows.Forms.TextBox txtAdmContractEditName;
        private System.Windows.Forms.Label lblAdmContractEditName;
    }
}