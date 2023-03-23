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
    public partial class AdminUserForm : Form
    {
        SqlRepository sqlRepository;
        public AdminUserForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void AdminUserEdit_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            lwAdmUserEdit.Items.Clear();
            var listUsers = sqlRepository.GetUsers();
            foreach (var user in listUsers)
            {
                Employee employee = sqlRepository.GetEmployee(user.IdEmployee);
                var role = sqlRepository.GetRole(user.Role);
                lwAdmUserEdit.Items.Add(new ListViewItem(new string[] { employee.FirstName + " " + employee.LastName, user.Name, Convert.ToString(user.Id), Convert.ToString(role.Name) }));
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(lwAdmUserEdit.SelectedItems[0].SubItems[2].Text);
            AdminUserEdit adminUserEdit = new AdminUserEdit(id,this);
            adminUserEdit.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm;
            addUserForm = new AddUserForm();
            addUserForm.ShowDialog();

        }
    }
}
