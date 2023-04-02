namespace Zaverecny_projekt_Greplova
{
    partial class AdminWorkTypeEdit
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
            this.btnAdmWorkTypeEditOK = new System.Windows.Forms.Button();
            this.txtAdmWorkTypeEditDescription = new System.Windows.Forms.RichTextBox();
            this.lblAdmWorkTypeEditDescription = new System.Windows.Forms.Label();
            this.txtAdmWorkTypeEditName = new System.Windows.Forms.TextBox();
            this.lblAdmWorkTypeEditName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmWorkTypeEditOK
            // 
            this.btnAdmWorkTypeEditOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdmWorkTypeEditOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmWorkTypeEditOK.Location = new System.Drawing.Point(242, 198);
            this.btnAdmWorkTypeEditOK.Name = "btnAdmWorkTypeEditOK";
            this.btnAdmWorkTypeEditOK.Size = new System.Drawing.Size(94, 42);
            this.btnAdmWorkTypeEditOK.TabIndex = 15;
            this.btnAdmWorkTypeEditOK.Text = "OK";
            this.btnAdmWorkTypeEditOK.UseVisualStyleBackColor = false;
            this.btnAdmWorkTypeEditOK.Click += new System.EventHandler(this.btnAdmWorkTypeEditOK_Click);
            // 
            // txtAdmWorkTypeEditDescription
            // 
            this.txtAdmWorkTypeEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdmWorkTypeEditDescription.Location = new System.Drawing.Point(25, 124);
            this.txtAdmWorkTypeEditDescription.Name = "txtAdmWorkTypeEditDescription";
            this.txtAdmWorkTypeEditDescription.Size = new System.Drawing.Size(311, 54);
            this.txtAdmWorkTypeEditDescription.TabIndex = 14;
            this.txtAdmWorkTypeEditDescription.Text = "";
            // 
            // lblAdmWorkTypeEditDescription
            // 
            this.lblAdmWorkTypeEditDescription.AutoSize = true;
            this.lblAdmWorkTypeEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmWorkTypeEditDescription.Location = new System.Drawing.Point(22, 94);
            this.lblAdmWorkTypeEditDescription.Name = "lblAdmWorkTypeEditDescription";
            this.lblAdmWorkTypeEditDescription.Size = new System.Drawing.Size(203, 25);
            this.lblAdmWorkTypeEditDescription.TabIndex = 13;
            this.lblAdmWorkTypeEditDescription.Text = "WorkType description";
            // 
            // txtAdmWorkTypeEditName
            // 
            this.txtAdmWorkTypeEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdmWorkTypeEditName.Location = new System.Drawing.Point(25, 55);
            this.txtAdmWorkTypeEditName.Name = "txtAdmWorkTypeEditName";
            this.txtAdmWorkTypeEditName.Size = new System.Drawing.Size(311, 30);
            this.txtAdmWorkTypeEditName.TabIndex = 12;
            // 
            // lblAdmWorkTypeEditName
            // 
            this.lblAdmWorkTypeEditName.AutoSize = true;
            this.lblAdmWorkTypeEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmWorkTypeEditName.Location = new System.Drawing.Point(22, 26);
            this.lblAdmWorkTypeEditName.Name = "lblAdmWorkTypeEditName";
            this.lblAdmWorkTypeEditName.Size = new System.Drawing.Size(161, 25);
            this.lblAdmWorkTypeEditName.TabIndex = 11;
            this.lblAdmWorkTypeEditName.Text = "WorkType Name";
            // 
            // AdminWorkTypeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 275);
            this.Controls.Add(this.btnAdmWorkTypeEditOK);
            this.Controls.Add(this.txtAdmWorkTypeEditDescription);
            this.Controls.Add(this.lblAdmWorkTypeEditDescription);
            this.Controls.Add(this.txtAdmWorkTypeEditName);
            this.Controls.Add(this.lblAdmWorkTypeEditName);
            this.Name = "AdminWorkTypeEdit";
            this.Text = "WorkType Edit";
            this.Load += new System.EventHandler(this.AdminWorkTypeEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmWorkTypeEditOK;
        private System.Windows.Forms.RichTextBox txtAdmWorkTypeEditDescription;
        private System.Windows.Forms.Label lblAdmWorkTypeEditDescription;
        private System.Windows.Forms.TextBox txtAdmWorkTypeEditName;
        private System.Windows.Forms.Label lblAdmWorkTypeEditName;
    }
}