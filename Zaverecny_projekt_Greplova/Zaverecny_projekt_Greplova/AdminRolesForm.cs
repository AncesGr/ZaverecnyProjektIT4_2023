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
    public partial class AdminRolesForm : Form
    {
        SqlRepository sqlRepository;
        public AdminRolesForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void AdminRolesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            lwAdmRolesEdit.Items.Clear();
            var roles = sqlRepository.GetRoles();
            foreach (var role in roles)
            {
                lwAdmRolesEdit.Items.Add(new ListViewItem(new string[] { role.Name, role.Id.ToString()  }));
            }
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            if (lwAdmRolesEdit.SelectedItems.Count > 0)
            {
                AdminRoleEdit adminRoleEdit = new AdminRoleEdit(Convert.ToInt32(lwAdmRolesEdit.SelectedItems[0].SubItems[1].Text), this);
                adminRoleEdit.ShowDialog();
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            AdminRoleAdd adminRoleAdd = new AdminRoleAdd(this);
            adminRoleAdd.ShowDialog();
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (lwAdmRolesEdit.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteRole(Convert.ToInt32(lwAdmRolesEdit.SelectedItems[0].SubItems[1].Text));
                LoadData();
            }
            else
            {
                MessageBox.Show("You havent selected a role");
            }
        }
    }
}
