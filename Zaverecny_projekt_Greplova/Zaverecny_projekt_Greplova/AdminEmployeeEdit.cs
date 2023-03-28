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
        public AdminEmployeeEdit(int idEmployee)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            IdEmployee = idEmployee;
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
    }
}
