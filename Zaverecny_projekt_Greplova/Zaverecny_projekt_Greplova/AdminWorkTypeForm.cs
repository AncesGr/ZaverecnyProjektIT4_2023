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
    public partial class AdminWorkTypeForm : Form
    {
        SqlRepository sqlRepository;
        public AdminWorkTypeForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void AdminWorkTypeForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var workTypes = sqlRepository.GetWorkTypes();
            lvAdmWorkTypeForm.Items.Clear();
            foreach (var workType in workTypes)
            {
                lvAdmWorkTypeForm.Items.Add(new ListViewItem(new string[] { workType.Name, workType.Id.ToString(), workType.Description }));
            }
        }

        private void btnEditWorkType_Click(object sender, EventArgs e)
        {
            if (lvAdmWorkTypeForm.SelectedItems.Count > 0)
            {
                AdminWorkTypeEdit adminWorkTypeEdit = new AdminWorkTypeEdit(Convert.ToInt32(lvAdmWorkTypeForm.SelectedItems[0].SubItems[1].Text), this);
                adminWorkTypeEdit.ShowDialog();
            }
        }

        private void btnAddWorkType_Click(object sender, EventArgs e)
        {
            AdminWorkTypeAdd adminWrokTypeAdd = new AdminWorkTypeAdd(this);
            adminWrokTypeAdd.ShowDialog();
        }

        private void btnDeleteWorkType_Click(object sender, EventArgs e)
        {
            if (lvAdmWorkTypeForm.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteWorkType(Convert.ToInt32(lvAdmWorkTypeForm.SelectedItems[0].SubItems[1].Text));
                LoadData();
            }
        }
    }
}
