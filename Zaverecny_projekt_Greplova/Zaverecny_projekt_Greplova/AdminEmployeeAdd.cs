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
    public partial class AdminEmployeeAdd : Form
    {
        SqlRepository sqlRepository;
        public AdminEmployeeForm AdminEmployeeForm { get; set; }
        public AdminEmployeeAdd(AdminEmployeeForm adminEmployeeForm)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            AdminEmployeeForm = adminEmployeeForm;
        }

        private void AdminEmployeeAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminEmployeeAddOK_Click(object sender, EventArgs e)
        {
            if (txtAdmEmployeeAddEmail.Text != "" && txtAdmEmployeeAddLastname.Text != "" && txtAdmEmployeeAddName.Text != "" && txtAdmEmployeeAddPhone.Text != "")
            {
                sqlRepository.AddEmployee(txtAdmEmployeeAddName.Text, txtAdmEmployeeAddLastname.Text, dtpAdmEmployeeAddBirthdate.Value, txtAdmEmployeeAddEmail.Text, txtAdmEmployeeAddPhone.Text);
                AdminEmployeeForm.LoadData();
                MessageBox.Show("Employee is add");
                Close();
            }
            else
            {
                MessageBox.Show("Not all fields are filled in");
            }
        }
    }
}
