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
            this.lwAdmUserEdit = new System.Windows.Forms.ListView();
            this.chEmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lwAdmUserEdit
            // 
            this.lwAdmUserEdit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmployeeName,
            this.chUserName});
            this.lwAdmUserEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lwAdmUserEdit.FullRowSelect = true;
            this.lwAdmUserEdit.GridLines = true;
            this.lwAdmUserEdit.HideSelection = false;
            this.lwAdmUserEdit.Location = new System.Drawing.Point(0, 0);
            this.lwAdmUserEdit.Name = "lwAdmUserEdit";
            this.lwAdmUserEdit.Size = new System.Drawing.Size(263, 450);
            this.lwAdmUserEdit.TabIndex = 0;
            this.lwAdmUserEdit.UseCompatibleStateImageBehavior = false;
            this.lwAdmUserEdit.View = System.Windows.Forms.View.Details;
            // 
            // chEmployeeName
            // 
            this.chEmployeeName.Text = "Employee name";
            this.chEmployeeName.Width = 130;
            // 
            // chUserName
            // 
            this.chUserName.Text = "User name";
            this.chUserName.Width = 130;
            // 
            // AdminUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lwAdmUserEdit);
            this.Name = "AdminUserEdit";
            this.Text = "Edit users";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwAdmUserEdit;
        private System.Windows.Forms.ColumnHeader chEmployeeName;
        private System.Windows.Forms.ColumnHeader chUserName;
    }
}