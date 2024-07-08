using System;
using System.Windows.Forms;

namespace hospital_project_interface_v2
{
    public partial class UCDisplayListDoctorsOfHospital : UserControl
    {
        public Hospital hospital { get; set; }
        public UCDisplayListDoctorsOfHospital()
        {
            InitializeComponent();
            InitializeListViewColumns();
            this.Load += new EventHandler(UCDisplayListDoctorsOfHospital_Load);
        }

        private void InitializeListViewColumns()
        {
            listDoctorsLV.View = View.Details; // Modo de detalles
            listDoctorsLV.Columns.Add("Identificación", 150);
            listDoctorsLV.Columns.Add("Nombre", 150);
            listDoctorsLV.Columns.Add("Apellido", 100);
            listDoctorsLV.Columns.Add("Edad", 100);
        }

        private void UCDisplayListDoctorsOfHospital_Load(object sender, EventArgs e)
        {
            if (this.hospital != null)
            {
                foreach (Doctor d in this.hospital.ListDoctors)
                {
                    ListViewItem item = new ListViewItem(d.Identification);
                    item.SubItems.Add(d.Name);
                    item.SubItems.Add(d.LastName);
                    item.SubItems.Add(d.Age.ToString());
                    this.listDoctorsLV.Items.Add(item);
                }
            }
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
