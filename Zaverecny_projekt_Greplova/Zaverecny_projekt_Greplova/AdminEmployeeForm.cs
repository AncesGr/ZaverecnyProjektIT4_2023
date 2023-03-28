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

        private void LoadData()
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
                AdminEmployeeEdit adminEmployeeEdit = new AdminEmployeeEdit(Convert.ToInt32(lwAdmEmployeeEdit.SelectedItems[0].SubItems[2].Text));
                adminEmployeeEdit.ShowDialog();
            }
        }
    }
}
