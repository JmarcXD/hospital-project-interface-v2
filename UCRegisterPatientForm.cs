using System;
using System.Windows.Forms;

namespace hospital_project_interface_v2
{
    public partial class UCRegisterPatientForm : UserControl
    {
        public Hospital hospital { get; set; }
        public UCRegisterPatientForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(UCRegisterPatienttForm_Load);
        }

        private void UCRegisterPatienttForm_Load(object sender, EventArgs e)
        {
            if (this.hospital != null)
            {
                foreach (Doctor d in this.hospital.ListDoctors)
                {
                    this.listDoctorsCB.Items.Add(d.Identification);
                }
            }
        }

        private void registerNewDoctor_Click(object sender, System.EventArgs e)
        {
            if (this.patientIdentificationTB.Text == "")
                MessageBox.Show("Introduce la identificación del Paciente");
            else if (this.patientNameTB.Text == "")
                MessageBox.Show("Introduce el nombre del Paciente");
            else if (this.patientLastNameTB.Text == "")
                MessageBox.Show("Introduce el apellido del Paciente");
            else if (this.listDoctorsCB.Text == "")
                MessageBox.Show("Selecciona al Médico");
            else
            {
                Doctor doctorAssigned = this.hospital.ListDoctors.Find(d => d.Identification == this.listDoctorsCB.Text);
                this.hospital.RegisterAPatient(new Patient(doctorAssigned,
                                                           this.patientIdentificationTB.Text,
                                                           this.patientNameTB.Text,
                                                           this.patientLastNameTB.Text,
                                                           (int)this.patientAgeUD.Value));
                MessageBox.Show("Se ha registrado correctamente");
            }

        }

    }
}
