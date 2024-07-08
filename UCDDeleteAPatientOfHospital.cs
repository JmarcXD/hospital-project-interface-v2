using System;
using System.Collections.Generic;
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
                List<ComboBoxItem> patiensItems = new List<ComboBoxItem>();
                foreach (Patient d in this.hospital.ListPatients)
                {
                    patiensItems.Add(new ComboBoxItem(d.Identification, $"{d.Name} {d.LastName}"));
                }

                this.listPatientsCB.DataSource = patiensItems;
                this.listPatientsCB.DisplayMember = "Text";
                this.listPatientsCB.ValueMember = "Value";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listPatientsCB.Text != "")
            {
                ComboBoxItem patientSelected = (ComboBoxItem)this.listPatientsCB.SelectedItem;

                Patient patientToDelete = this.hospital.ListPatients
                    .Find(p => p.Identification == patientSelected.Value);

                this.hospital.DeleteAPatientByObject(patientToDelete);
                MessageBox.Show("Se ha eliminado correctamente");
                this.Visible = false;
            }
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
