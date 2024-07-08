namespace hospital_project_interface_v2
{
    partial class UCDisplayListPatientsOfDoctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.listPatientsOfDoctorLV = new System.Windows.Forms.ListView();
            this.listDoctorCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista Pacientes de un Médico";
            // 
            // listPatientsOfDoctorLV
            // 
            this.listPatientsOfDoctorLV.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.listPatientsOfDoctorLV.HideSelection = false;
            this.listPatientsOfDoctorLV.Location = new System.Drawing.Point(27, 185);
            this.listPatientsOfDoctorLV.Name = "listPatientsOfDoctorLV";
            this.listPatientsOfDoctorLV.Size = new System.Drawing.Size(596, 611);
            this.listPatientsOfDoctorLV.TabIndex = 2;
            this.listPatientsOfDoctorLV.UseCompatibleStateImageBehavior = false;
            this.listPatientsOfDoctorLV.View = System.Windows.Forms.View.Details;
            // 
            // listDoctorCB
            // 
            this.listDoctorCB.FormattingEnabled = true;
            this.listDoctorCB.Location = new System.Drawing.Point(32, 129);
            this.listDoctorCB.Name = "listDoctorCB";
            this.listDoctorCB.Size = new System.Drawing.Size(581, 33);
            this.listDoctorCB.TabIndex = 4;
            this.listDoctorCB.SelectedIndexChanged += new System.EventHandler(this.listDoctorCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Médico";
            // 
            // UCDisplayListPatientsOfDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listDoctorCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPatientsOfDoctorLV);
            this.Name = "UCDisplayListPatientsOfDoctor";
            this.Size = new System.Drawing.Size(743, 839);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listPatientsOfDoctorLV;
        private System.Windows.Forms.ComboBox listDoctorCB;
        private System.Windows.Forms.Label label2;
    }
}
