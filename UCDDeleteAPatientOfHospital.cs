using System;
using System.Windows.Forms;

namespace hospital_project_interface_v2
{
    public partial class UCDDeleteAPatientOfHospital : UserControl
    {
        public Hospital hospital { get; set; }
        public UCDDeleteAPatientOfHospital()
        {
            InitializeComponent();
            this.Load += new EventHandler(UCRegisterPatienttForm_Load);
        }

        private void UCRegisterPatienttForm_Load(object sender, EventArgs e)
        {
            if (this.hospital != null)
            {
                foreach (Patient d in this.hospital.ListPatients)
                {
                    this.listPatientsCB.Items.Add(d.Identification);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listPatientsCB.Text != "")
            {
                Patient patientToDelete = this.hospital.ListPatients.Find(p => p.Identification == this.listPatientsCB.Text);
                this.hospital.DeleteAPatientByObject(patientToDelete);
                MessageBox.Show("Se ha eliminado correctamente");
                this.listPatientsCB.Items.Clear();
            }
        }
    }
}
