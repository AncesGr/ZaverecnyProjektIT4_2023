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
    public partial class AdminEmployeeEdit : Form
    {
        SqlRepository sqlRepository;
        public int IdEmployee { get; set; }
        public AdminEmployeeForm AdminEmployeeForm { get; set; }
        public AdminEmployeeEdit(int idEmployee, AdminEmployeeForm adminEmployeeForm)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            IdEmployee = idEmployee;
            AdminEmployeeForm = adminEmployeeForm;
        }

        private void AdminEmployeeEdit_Load(object sender, EventArgs e)
        {
            var employee = sqlRepository.GetEmployee(IdEmployee);
            if (employee != null)
            {
                txtAdmEmployeeEditName.Text = employee.FirstName;
                txtAdmEmployeeEditLastname.Text = employee.LastName;
                txtAdmEmployeeEditEmail.Text = employee.Email;
                txtAdmEmployeeEditPhone.Text = employee.Phone;
            }
        }

        private void btnAdminEmployeeEditOK_Click(object sender, EventArgs e)
        {
            if (txtAdmEmployeeEditEmail.Text != "" && txtAdmEmployeeEditName.Text != "" && txtAdmEmployeeEditLastname.Text != "" && txtAdmEmployeeEditPhone.Text != "")
            {
                sqlRepository.UpdateEmployee(IdEmployee, txtAdmEmployeeEditName.Text, txtAdmEmployeeEditLastname.Text, dtpAdmEmployeeEditBirthdate.Value, txtAdmEmployeeEditEmail.Text, txtAdmEmployeeEditPhone.Text);
                AdminEmployeeForm.LoadData();   
                Close();
            }
            else
            {
                MessageBox.Show("Not all fields are filled in");
            }
        }
    }
}
