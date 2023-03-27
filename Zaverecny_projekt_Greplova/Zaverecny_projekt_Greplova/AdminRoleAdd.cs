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
    public partial class AdminRoleAdd : Form
    {
        SqlRepository sqlRepository;
        public AdminRolesForm AdminRolesForm { get; set; }
        public AdminRoleAdd(AdminRolesForm adminRolesForm)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            AdminRolesForm = adminRolesForm;   
        }

        private void btnAdmRoleAddOK_Click(object sender, EventArgs e)
        {
            if (txtAdmRoleAddName.Text != "")
            {
                sqlRepository.AddRole(txtAdmRoleAddName.Text);
                AdminRolesForm.LoadData();
                Close();
            }
            else
            {
                MessageBox.Show("You have not entered a name for the new role");
            }
        }
    }
}
