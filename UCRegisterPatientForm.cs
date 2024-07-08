using System;
using System.Collections.Generic;
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
                List<ComboBoxItem> doctorsItems = new List<ComboBoxItem>();

                foreach (Doctor d in this.hospital.ListDoctors)
                {
                    doctorsItems.Add(new ComboBoxItem(d.Identification, $"{d.Name} {d.LastName}"));
                }

                this.listDoctorsCB.DataSource = doctorsItems;
                this.listDoctorsCB.DisplayMember = "Text";
                this.listDoctorsCB.ValueMember = "Value";
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
                ComboBoxItem doctorSelected = (ComboBoxItem)this.listDoctorsCB.SelectedItem;

                Doctor doctorAssigned = this.hospital.ListDoctors.Find(d => d.Identification == doctorSelected.Value);
                this.hospital.RegisterAPatient(new Patient(doctorAssigned,
                                                           this.patientIdentificationTB.Text,
                                                           this.patientNameTB.Text,
                                                           this.patientLastNameTB.Text,
                                                           (int)this.patientAgeUD.Value));
                MessageBox.Show("Se ha registrado correctamente");
                this.Visible = false;
            }

        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
