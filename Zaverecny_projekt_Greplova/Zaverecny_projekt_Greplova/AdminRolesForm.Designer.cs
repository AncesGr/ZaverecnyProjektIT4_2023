namespace Zaverecny_projekt_Greplova
{
    partial class AdminRolesForm
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
            this.lwAdmRolesEdit = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnEditRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lwAdmRolesEdit
            // 
            this.lwAdmRolesEdit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chId});
            this.lwAdmRolesEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lwAdmRolesEdit.FullRowSelect = true;
            this.lwAdmRolesEdit.GridLines = true;
            this.lwAdmRolesEdit.HideSelection = false;
            this.lwAdmRolesEdit.Location = new System.Drawing.Point(0, 0);
            this.lwAdmRolesEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lwAdmRolesEdit.MinimumSize = new System.Drawing.Size(212, 324);
            this.lwAdmRolesEdit.Name = "lwAdmRolesEdit";
            this.lwAdmRolesEdit.Size = new System.Drawing.Size(212, 324);
            this.lwAdmRolesEdit.TabIndex = 1;
            this.lwAdmRolesEdit.UseCompatibleStateImageBehavior = false;
            this.lwAdmRolesEdit.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.DisplayIndex = 1;
            this.chName.Text = "Název";
            this.chName.Width = 100;
            // 
            // chId
            // 
            this.chId.DisplayIndex = 0;
            this.chId.Text = "Id";
            this.chId.Width = 50;
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteRole.Location = new System.Drawing.Point(222, 124);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(89, 36);
            this.btnDeleteRole.TabIndex = 6;
            this.btnDeleteRole.Text = "Delete";
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddRole.Location = new System.Drawing.Point(222, 68);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(89, 36);
            this.btnAddRole.TabIndex = 5;
            this.btnAddRole.Text = "Add";
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnEditRole
            // 
            this.btnEditRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditRole.Location = new System.Drawing.Point(222, 12);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(89, 36);
            this.btnEditRole.TabIndex = 4;
            this.btnEditRole.Text = "Edit";
            this.btnEditRole.UseVisualStyleBackColor = false;
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click);
            // 
            // AdminRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 324);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.btnEditRole);
            this.Controls.Add(this.lwAdmRolesEdit);
            this.Name = "AdminRolesForm";
            this.Text = "Role";
            this.Load += new System.EventHandler(this.AdminRolesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwAdmRolesEdit;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnEditRole;
    }
}