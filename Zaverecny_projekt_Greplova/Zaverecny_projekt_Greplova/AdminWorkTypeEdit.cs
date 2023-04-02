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
    public partial class AdminWorkTypeEdit : Form
    {
        public int IdWorkType { get; set; }
        SqlRepository sqlRepository;
        public AdminWorkTypeForm AdminWorkTypeForm { get; set; }
        public AdminWorkTypeEdit(int idWorkType, AdminWorkTypeForm adminWorkTypeForm)
        {
            InitializeComponent();
            IdWorkType = idWorkType;
            sqlRepository = new SqlRepository();
            AdminWorkTypeForm = adminWorkTypeForm;
        }

        private void AdminWorkTypeEdit_Load(object sender, EventArgs e)
        {
            var workType = sqlRepository.GetWorkType(IdWorkType);
            if (workType != null)
            {
                txtAdmWorkTypeEditDescription.Text = workType.Description;
                txtAdmWorkTypeEditName.Text = workType.Name;
            }
        }

        private void btnAdmWorkTypeEditOK_Click(object sender, EventArgs e)
        {
            if (txtAdmWorkTypeEditName.Text != "" && txtAdmWorkTypeEditDescription.Text != "")
            {
                sqlRepository.UpdateWorkType(txtAdmWorkTypeEditName.Text, txtAdmWorkTypeEditDescription.Text, IdWorkType);
                AdminWorkTypeForm.LoadData();
                Close();
            }
        }
    }
}
