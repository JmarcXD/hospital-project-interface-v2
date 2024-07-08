namespace hospital_project_interface_v2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.listDoctorsButton = new System.Windows.Forms.Button();
            this.listPersonsOfHospitalButton = new System.Windows.Forms.Button();
            this.listPatientsOfDoctorButton = new System.Windows.Forms.Button();
            this.registerPatientButton = new System.Windows.Forms.Button();
            this.registerDoctorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.registerAdminButton = new System.Windows.Forms.Button();
            this.ucDisplayListDoctorsOfHospital1 = new hospital_project_interface_v2.UCDisplayListDoctorsOfHospital();
            this.ucRegisterPatientForm1 = new hospital_project_interface_v2.UCRegisterPatientForm();
            this.ucRegisterDoctorForm1 = new hospital_project_interface_v2.UCRegisterDoctorForm();
            this.ucRegisterAdminForm1 = new hospital_project_interface_v2.UCRegisterAdminForm();
            this.ucDisplayListPeopleOfHospital1 = new hospital_project_interface_v2.UCDisplayListPeopleOfHospital();
            this.ucDisplayListPatientsOfDoctor1 = new hospital_project_interface_v2.UCDisplayListPatientsOfDoctor();
            this.ucdDeleteAPatientOfHospital1 = new hospital_project_interface_v2.UCDDeleteAPatientOfHospital();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.deletePatientButton);
            this.panel1.Controls.Add(this.listDoctorsButton);
            this.panel1.Controls.Add(this.listPersonsOfHospitalButton);
            this.panel1.Controls.Add(this.listPatientsOfDoctorButton);
            this.panel1.Controls.Add(this.registerPatientButton);
            this.panel1.Controls.Add(this.registerDoctorButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.registerAdminButton);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 437);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(18, 373);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 35);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.Location = new System.Drawing.Point(18, 325);
            this.deletePatientButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(115, 35);
            this.deletePatientButton.TabIndex = 7;
            this.deletePatientButton.Text = "Eliminar un Paciente";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            this.deletePatientButton.Click += new System.EventHandler(this.deletePatientButton_Click);
            // 
            // listDoctorsButton
            // 
            this.listDoctorsButton.Location = new System.Drawing.Point(18, 281);
            this.listDoctorsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listDoctorsButton.Name = "listDoctorsButton";
            this.listDoctorsButton.Size = new System.Drawing.Size(115, 35);
            this.listDoctorsButton.TabIndex = 6;
            this.listDoctorsButton.Text = "Lista Médicos";
            this.listDoctorsButton.UseVisualStyleBackColor = true;
            this.listDoctorsButton.Click += new System.EventHandler(this.listDoctorsButton_Click);
            // 
            // listPersonsOfHospitalButton
            // 
            this.listPersonsOfHospitalButton.Location = new System.Drawing.Point(18, 235);
            this.listPersonsOfHospitalButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listPersonsOfHospitalButton.Name = "listPersonsOfHospitalButton";
            this.listPersonsOfHospitalButton.Size = new System.Drawing.Size(115, 35);
            this.listPersonsOfHospitalButton.TabIndex = 5;
            this.listPersonsOfHospitalButton.Text = "Lista Persona del Hospital";
            this.listPersonsOfHospitalButton.UseVisualStyleBackColor = true;
            this.listPersonsOfHospitalButton.Click += new System.EventHandler(this.listPersonsOfHospitalButton_Click);
            // 
            // listPatientsOfDoctorButton
            // 
            this.listPatientsOfDoctorButton.Location = new System.Drawing.Point(18, 187);
            this.listPatientsOfDoctorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listPatientsOfDoctorButton.Name = "listPatientsOfDoctorButton";
            this.listPatientsOfDoctorButton.Size = new System.Drawing.Size(115, 35);
            this.listPatientsOfDoctorButton.TabIndex = 4;
            this.listPatientsOfDoctorButton.Text = "Lista Pacientes de un Médico";
            this.listPatientsOfDoctorButton.UseVisualStyleBackColor = true;
            this.listPatientsOfDoctorButton.Click += new System.EventHandler(this.listPatientsOfDoctorButton_Click);
            // 
            // registerPatientButton
            // 
            this.registerPatientButton.Location = new System.Drawing.Point(18, 140);
            this.registerPatientButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerPatientButton.Name = "registerPatientButton";
            this.registerPatientButton.Size = new System.Drawing.Size(115, 35);
            this.registerPatientButton.TabIndex = 3;
            this.registerPatientButton.Text = "Alta Paciente";
            this.registerPatientButton.UseVisualStyleBackColor = true;
            this.registerPatientButton.Click += new System.EventHandler(this.registerPatientButton_Click);
            // 
            // registerDoctorButton
            // 
            this.registerDoctorButton.Location = new System.Drawing.Point(18, 96);
            this.registerDoctorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerDoctorButton.Name = "registerDoctorButton";
            this.registerDoctorButton.Size = new System.Drawing.Size(115, 35);
            this.registerDoctorButton.TabIndex = 2;
            this.registerDoctorButton.Text = "Alta Médico";
            this.registerDoctorButton.UseVisualStyleBackColor = true;
            this.registerDoctorButton.Click += new System.EventHandler(this.registerDoctorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital";
            // 
            // registerAdminButton
            // 
            this.registerAdminButton.Location = new System.Drawing.Point(18, 51);
            this.registerAdminButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerAdminButton.Name = "registerAdminButton";
            this.registerAdminButton.Size = new System.Drawing.Size(115, 35);
            this.registerAdminButton.TabIndex = 0;
            this.registerAdminButton.Text = "Alta Administrador";
            this.registerAdminButton.UseVisualStyleBackColor = true;
            this.registerAdminButton.Click += new System.EventHandler(this.registerAdminButton_Click);
            // 
            // ucDisplayListDoctorsOfHospital1
            // 
            this.ucDisplayListDoctorsOfHospital1.hospital = null;
            this.ucDisplayListDoctorsOfHospital1.Location = new System.Drawing.Point(142, 1);
            this.ucDisplayListDoctorsOfHospital1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ucDisplayListDoctorsOfHospital1.Name = "ucDisplayListDoctorsOfHospital1";
            this.ucDisplayListDoctorsOfHospital1.Size = new System.Drawing.Size(372, 435);
            this.ucDisplayListDoctorsOfHospital1.TabIndex = 11;
            // 
            // ucRegisterPatientForm1
            // 
            this.ucRegisterPatientForm1.hospital = null;
            this.ucRegisterPatientForm1.Location = new System.Drawing.Point(148, 6);
            this.ucRegisterPatientForm1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ucRegisterPatientForm1.Name = "ucRegisterPatientForm1";
            this.ucRegisterPatientForm1.Size = new System.Drawing.Size(440, 424);
            this.ucRegisterPatientForm1.TabIndex = 10;
            // 
            // ucRegisterDoctorForm1
            // 
            this.ucRegisterDoctorForm1.hospital = null;
            this.ucRegisterDoctorForm1.Location = new System.Drawing.Point(148, 6);
            this.ucRegisterDoctorForm1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ucRegisterDoctorForm1.Name = "ucRegisterDoctorForm1";
            this.ucRegisterDoctorForm1.Size = new System.Drawing.Size(440, 424);
            this.ucRegisterDoctorForm1.TabIndex = 9;
            // 
            // ucRegisterAdminForm1
            // 
            this.ucRegisterAdminForm1.hospital = null;
            this.ucRegisterAdminForm1.Location = new System.Drawing.Point(148, -1);
            this.ucRegisterAdminForm1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ucRegisterAdminForm1.Name = "ucRegisterAdminForm1";
            this.ucRegisterAdminForm1.Size = new System.Drawing.Size(440, 431);
            this.ucRegisterAdminForm1.TabIndex = 1;
            // 
            // ucDisplayListPeopleOfHospital1
            // 
            this.ucDisplayListPeopleOfHospital1.hospital = null;
            this.ucDisplayListPeopleOfHospital1.Location = new System.Drawing.Point(142, 2);
            this.ucDisplayListPeopleOfHospital1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ucDisplayListPeopleOfHospital1.Name = "ucDisplayListPeopleOfHospital1";
            this.ucDisplayListPeopleOfHospital1.Size = new System.Drawing.Size(372, 428);
            this.ucDisplayListPeopleOfHospital1.TabIndex = 12;
            // 
            // ucDisplayListPatientsOfDoctor1
            // 
            this.ucDisplayListPatientsOfDoctor1.hospital = null;
            this.ucDisplayListPatientsOfDoctor1.Location = new System.Drawing.Point(142, 2);
            this.ucDisplayListPatientsOfDoctor1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ucDisplayListPatientsOfDoctor1.Name = "ucDisplayListPatientsOfDoctor1";
            this.ucDisplayListPatientsOfDoctor1.Size = new System.Drawing.Size(372, 428);
            this.ucDisplayListPatientsOfDoctor1.TabIndex = 13;
            // 
            // ucdDeleteAPatientOfHospital1
            // 
            this.ucdDeleteAPatientOfHospital1.hospital = null;
            this.ucdDeleteAPatientOfHospital1.Location = new System.Drawing.Point(148, 6);
            this.ucdDeleteAPatientOfHospital1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ucdDeleteAPatientOfHospital1.Name = "ucdDeleteAPatientOfHospital1";
            this.ucdDeleteAPatientOfHospital1.Size = new System.Drawing.Size(379, 424);
            this.ucdDeleteAPatientOfHospital1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 437);
            this.Controls.Add(this.ucdDeleteAPatientOfHospital1);
            this.Controls.Add(this.ucDisplayListPatientsOfDoctor1);
            this.Controls.Add(this.ucDisplayListPeopleOfHospital1);
            this.Controls.Add(this.ucDisplayListDoctorsOfHospital1);
            this.Controls.Add(this.ucRegisterPatientForm1);
            this.Controls.Add(this.ucRegisterDoctorForm1);
            this.Controls.Add(this.ucRegisterAdminForm1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button registerPatientButton;
        private System.Windows.Forms.Button registerDoctorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerAdminButton;
        private System.Windows.Forms.Button listPersonsOfHospitalButton;
        private System.Windows.Forms.Button listPatientsOfDoctorButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button deletePatientButton;
        private System.Windows.Forms.Button listDoctorsButton;
        private UCRegisterAdminForm ucRegisterAdminForm1;
        private UCRegisterDoctorForm ucRegisterDoctorForm1;
        private UCRegisterPatientForm ucRegisterPatientForm1;
        private UCDisplayListDoctorsOfHospital ucDisplayListDoctorsOfHospital1;
        private UCDisplayListPeopleOfHospital ucDisplayListPeopleOfHospital1;
        private UCDisplayListPatientsOfDoctor ucDisplayListPatientsOfDoctor1;
        private UCDDeleteAPatientOfHospital ucdDeleteAPatientOfHospital1;
    }
}

