using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaverecny_projekt_Greplova
{
    public partial class MainForm : Form
    {
        public User User { get; set; }
        public Form FormLogin { get; set; } 
        public MainForm( User user, Form form)
        {
            InitializeComponent();
            User = user;
            FormLogin = form;
            
        }

        private void btnAdmUser_Click(object sender, EventArgs e)
        {
            AdminUserForm adminUserEdit = new AdminUserForm();
            adminUserEdit.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin.Close();
        }

        private void btnAdmRole_Click(object sender, EventArgs e)
        {
            AdminRolesForm adminRolesForm = new AdminRolesForm();
            adminRolesForm.ShowDialog();
        }
    }
}
