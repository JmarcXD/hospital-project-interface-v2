using System;
using System.Windows.Forms;

namespace hospital_project_interface_v2
{
    public partial class Form1 : Form
    {
        private Hospital hospitalEsplai {  get; set; }
        public Form1()
        {
            InitializeComponent();
            HideUsersControls();
            this.hospitalEsplai = new Hospital("Hospital Fundación Esplai");
            this.ucRegisterDoctorForm1.hospital = this.hospitalEsplai;
            this.ucRegisterAdminForm1.hospital = this.hospitalEsplai;
            this.ucRegisterPatientForm1.hospital = this.hospitalEsplai;
            this.ucDisplayListDoctorsOfHospital1.hospital = this.hospitalEsplai;
            this.ucDisplayListPeopleOfHospital1.hospital = this.hospitalEsplai;
            this.ucDisplayListPatientsOfDoctor1.hospital = this.hospitalEsplai;
            this.ucdDeleteAPatientOfHospital1.hospital = this.hospitalEsplai;
        }

        private void HideUsersControls()
        {
            foreach (Control c in this.Controls)
            {
                if (c is UserControl)
                    c.Visible = false;
            }
        }

        private void registerAdminButton_Click(object sender, EventArgs e)
        {
            HideUsersControls();
            this.ucRegisterAdminForm1.Show();
        }


        private void registerDoctorButton_Click(object sender, EventArgs e)
        {
            HideUsersControls();
            this.ucRegisterDoctorForm1.Show();
        }

        private void registerPatientButton_Click(object sender, EventArgs e)
        {
            HideUsersControls();
            this.ucRegisterPatientForm1.Show();
        }

        private void listPatientsOfDoctorButton_Click(object sender, EventArgs e)
        {
            HideUsersControls();
            this.ucDisplayListPatientsOfDoctor1.Show();
        }

        private void listPersonsOfHospitalButton_Click(object sender, EventArgs e)
        {
            HideUsersControls();
            this.ucDisplayListPeopleOfHospital1.Show();
        }

        private void listDoctorsButton_Click(object sender, EventArgs e)
        {
            HideUsersControls();
            this.ucDisplayListDoctorsOfHospital1.Show();
           
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            HideUsersControls();
            this.ucdDeleteAPatientOfHospital1.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
