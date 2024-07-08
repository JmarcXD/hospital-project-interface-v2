using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace hospital_project_interface_v2
{
    public partial class UCDisplayListPatientsOfDoctor : UserControl
    {
        public Hospital hospital { get; set; }
        public UCDisplayListPatientsOfDoctor()
        {
            InitializeComponent();
            InitializeListViewColumns();
            this.Load += new EventHandler(ListDoctors_Load);
        }

        private void InitializeListViewColumns()
        {
            listPatientsOfDoctorLV.View = View.Details; // Modo de detalles
            listPatientsOfDoctorLV.Columns.Add("Identificación", 150);
            listPatientsOfDoctorLV.Columns.Add("Nombre", 150);
            listPatientsOfDoctorLV.Columns.Add("Apellido", 100);
            listPatientsOfDoctorLV.Columns.Add("Edad", 100);
        }



        private void ListDoctors_Load(object sender, EventArgs e)
        {
            if (this.hospital != null)
            {
                foreach (Doctor d in this.hospital.ListDoctors)
                {
                    this.listDoctorCB.Items.Add(d.Identification);
                }
            }
        }

        private void listDoctorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listPatientsOfDoctorLV.Items.Clear();
            List<Patient> patients = this.hospital.ListDoctors
                                        .Find(d => d.Identification == this.listDoctorCB.Text).ListPatients;

            foreach (Patient p in patients)
            {
                ListViewItem item = new ListViewItem(p.Identification);
                item.SubItems.Add(p.Name);
                item.SubItems.Add(p.LastName);
                item.SubItems.Add(p.Age.ToString());
                this.listPatientsOfDoctorLV.Items.Add(item);
            }
        }
    }
}
