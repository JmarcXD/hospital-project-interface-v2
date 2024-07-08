using System;
using System.Windows.Forms;

namespace hospital_project_interface_v2
{
    public partial class UCDisplayListPeopleOfHospital : UserControl
    {
        public Hospital hospital {  get; set; }
        public UCDisplayListPeopleOfHospital()
        {
            InitializeComponent();
            InitializeListViewColumns();
            this.Load += new EventHandler(UCDisplayListPersonsOfHospital_Load);
        }

        private void InitializeListViewColumns()
        {
            listPersonsLV.View = View.Details; // Modo de detalles
            listPersonsLV.Columns.Add("Identificación", 150);
            listPersonsLV.Columns.Add("Nombre", 150);
            listPersonsLV.Columns.Add("Apellido", 100);
            listPersonsLV.Columns.Add("Edad", 100);
        }

        private void UCDisplayListPersonsOfHospital_Load(object sender, EventArgs e)
        {
            if (this.hospital != null)
            {
                foreach (Person d in this.hospital.ListPersons)
                {
                    ListViewItem item = new ListViewItem(d.Identification);
                    item.SubItems.Add(d.Name);
                    item.SubItems.Add(d.LastName);
                    item.SubItems.Add(d.Age.ToString());
                    this.listPersonsLV.Items.Add(item);
                }
            }
        }
    }
}
