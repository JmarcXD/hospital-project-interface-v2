using System.Windows.Forms;

namespace hospital_project_interface_v2
{
    public partial class UCRegisterAdminForm : UserControl
    {
        public Hospital hospital {  get; set; }
        public UCRegisterAdminForm()
        {
            InitializeComponent();
        }

        private void registerNewAdmin_Click(object sender, System.EventArgs e)
        {
            if (this.adminIdentificationTB.Text == "")
                MessageBox.Show("Introduce la identificación del Admin");
            else if (this.nameAdminTB.Text == "")
                MessageBox.Show("Introduce el nombre del Admin");
            else if (this.lastNameAdminTB.Text == "")
                MessageBox.Show("Introduce el apellido del Admin");
            else
            {
                this.hospital.RegisterAAdministrative(new Administrative(this.adminIdentificationTB.Text,
                                                                         this.nameAdminTB.Text,
                                                                         this.lastNameAdminTB.Text, 
                                                                         ((int)this.ageAdminUD.Value)));
                MessageBox.Show("Se ha registrado correctamente");
            }
        }
    }
}
