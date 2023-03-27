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
    public partial class AddUserForm : Form
    {
        SqlRepository sqlRepository;
        public AddUserForm(AdminUserForm adminUserForm)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            AdminUserForm = adminUserForm;
        }
        
        private AdminUserForm AdminUserForm { get; set; }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            var employees = sqlRepository.GetEmployees();
            var roles = sqlRepository.GetRoles();
            cmbAddEmployee.Items.Clear();
            foreach (var employee  in employees)
            {
                cmbAddEmployee.Items.Add(employee.Id + " / " + employee.LastName + " " + employee.FirstName);    
            }
            cmbAddRole.Items.Clear();
            foreach (var role in roles)
            {
                cmbAddRole.Items.Add(role.Name);
            }
        }

        private void btnAddUserForm_Click(object sender, EventArgs e)
        {
            if (txtAddUserName.Text != " " && cmbAddEmployee.Text != " " && cmbAddRole.Text != " " )
            {
                var idEmployee = cmbAddEmployee.Text.Split('/');
                var newUser = new User(txtAddUserName.Text);
                newUser.ResetPassword();
                var role = sqlRepository.GetRole(cmbAddRole.Text);
                sqlRepository.AddUser(txtAddUserName.Text,Convert.ToInt32(idEmployee[0].Trim()), newUser.PasswordHash, newUser.PasswordSalt, role.Id);
                AdminUserForm.LoadData();
                this.Close();
                MessageBox.Show("The user has been successfully added");
            }
            else
            {
                MessageBox.Show("Not all fields are filled");
            }
        }
    }
}
