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
    public partial class AdminEmployeeForm : Form
    {
        SqlRepository sqlRepository;
        public AdminEmployeeForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void AdminEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var employees = sqlRepository.GetEmployees();
            lwAdmEmployeeEdit.Items.Clear();
            foreach (var employee in employees)
            {
                lwAdmEmployeeEdit.Items.Add(new ListViewItem(new string[] { employee.FirstName, employee.LastName, employee.Id.ToString(), Convert.ToString(employee.BirthDate.ToString("d")), employee.Email.ToString(), string.Format("{0:### ### ###}", long.Parse(employee.Phone)) }));
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (lwAdmEmployeeEdit.SelectedItems.Count > 0)
            {
                AdminEmployeeEdit adminEmployeeEdit = new AdminEmployeeEdit(Convert.ToInt32(lwAdmEmployeeEdit.SelectedItems[0].SubItems[2].Text),this);
                adminEmployeeEdit.ShowDialog();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AdminEmployeeAdd adminEmployeeAdd = new AdminEmployeeAdd(this);
            adminEmployeeAdd.ShowDialog();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (lwAdmEmployeeEdit.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteEmployee(Convert.ToInt32(lwAdmEmployeeEdit.SelectedItems[0].SubItems[2].Text));
                LoadData();
                MessageBox.Show("Employee is deleted");
            }
            else
            {
                MessageBox.Show("No employee was selected!");
            }
        }
    }
}
