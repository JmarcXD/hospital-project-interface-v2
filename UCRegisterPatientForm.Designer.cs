namespace hospital_project_interface_v2
{
    partial class UCRegisterPatientForm
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.listDoctorsCB = new System.Windows.Forms.ComboBox();
            this.registerNewDoctor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.patientAgeUD = new System.Windows.Forms.NumericUpDown();
            this.patientLastNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patientNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patientIdentificationTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientAgeUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Médico Asignado";
            // 
            // listDoctorsCB
            // 
            this.listDoctorsCB.FormattingEnabled = true;
            this.listDoctorsCB.Location = new System.Drawing.Point(62, 425);
            this.listDoctorsCB.Name = "listDoctorsCB";
            this.listDoctorsCB.Size = new System.Drawing.Size(282, 33);
            this.listDoctorsCB.TabIndex = 42;
            // 
            // registerNewDoctor
            // 
            this.registerNewDoctor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerNewDoctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerNewDoctor.Location = new System.Drawing.Point(64, 517);
            this.registerNewDoctor.Name = "registerNewDoctor";
            this.registerNewDoctor.Size = new System.Drawing.Size(193, 77);
            this.registerNewDoctor.TabIndex = 41;
            this.registerNewDoctor.Text = "Registrar";
            this.registerNewDoctor.UseVisualStyleBackColor = false;
            this.registerNewDoctor.Click += new System.EventHandler(this.registerNewDoctor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Edad";
            // 
            // patientAgeUD
            // 
            this.patientAgeUD.Location = new System.Drawing.Point(523, 310);
            this.patientAgeUD.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.patientAgeUD.Name = "patientAgeUD";
            this.patientAgeUD.Size = new System.Drawing.Size(286, 31);
            this.patientAgeUD.TabIndex = 39;
            this.patientAgeUD.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // patientLastNameTB
            // 
            this.patientLastNameTB.Location = new System.Drawing.Point(64, 310);
            this.patientLastNameTB.Name = "patientLastNameTB";
            this.patientLastNameTB.Size = new System.Drawing.Size(286, 31);
            this.patientLastNameTB.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Apellido";
            // 
            // patientNameTB
            // 
            this.patientNameTB.Location = new System.Drawing.Point(523, 184);
            this.patientNameTB.Name = "patientNameTB";
            this.patientNameTB.Size = new System.Drawing.Size(286, 31);
            this.patientNameTB.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nombre";
            // 
            // patientIdentificationTB
            // 
            this.patientIdentificationTB.Location = new System.Drawing.Point(64, 184);
            this.patientIdentificationTB.Name = "patientIdentificationTB";
            this.patientIdentificationTB.Size = new System.Drawing.Size(286, 31);
            this.patientIdentificationTB.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Identificación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 51);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nuevo Paciente";
            // 
            // UCRegisterPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listDoctorsCB);
            this.Controls.Add(this.registerNewDoctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.patientAgeUD);
            this.Controls.Add(this.patientLastNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patientNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientIdentificationTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCRegisterPatientForm";
            this.Size = new System.Drawing.Size(922, 746);
            ((System.ComponentModel.ISupportInitialize)(this.patientAgeUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox listDoctorsCB;
        private System.Windows.Forms.Button registerNewDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown patientAgeUD;
        private System.Windows.Forms.TextBox patientLastNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patientNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patientIdentificationTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
