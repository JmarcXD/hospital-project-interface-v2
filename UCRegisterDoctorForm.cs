using System;
using System.Windows.Forms;

namespace hospital_project_interface_v2
{
    public partial class UCRegisterDoctorForm : UserControl
    {
        public Hospital hospital {  get; set; }
        public UCRegisterDoctorForm()
        {
            InitializeComponent();
        }

        private void registerNewDoctor_Click(object sender, System.EventArgs e)
        {
            if (this.doctorIdentificationTB.Text == "")
                MessageBox.Show("Introduce la identificación del Médico");
            else if (this.doctorNameTB.Text == "")
                MessageBox.Show("Introduce el nombre del Médico");
            else if (this.doctorLastNameTB.Text == "")
                MessageBox.Show("Introduce el apellido del Médico");
            else
            {
                this.hospital.RegisterADoctor(new Doctor(this.doctorIdentificationTB.Text,
                                                         this.doctorNameTB.Text,
                                                         this.doctorLastNameTB.Text,
                                                         ((int)this.doctorAgeUD.Value)));
                MessageBox.Show("Se ha registrado correctamente");
            }
        }
    }
}
