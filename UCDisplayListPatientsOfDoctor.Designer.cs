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
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista Pacientes de un Médico";
            // 
            // listPatientsOfDoctorLV
            // 
            this.listPatientsOfDoctorLV.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.listPatientsOfDoctorLV.HideSelection = false;
            this.listPatientsOfDoctorLV.Location = new System.Drawing.Point(14, 96);
            this.listPatientsOfDoctorLV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listPatientsOfDoctorLV.Name = "listPatientsOfDoctorLV";
            this.listPatientsOfDoctorLV.Size = new System.Drawing.Size(300, 320);
            this.listPatientsOfDoctorLV.TabIndex = 2;
            this.listPatientsOfDoctorLV.UseCompatibleStateImageBehavior = false;
            this.listPatientsOfDoctorLV.View = System.Windows.Forms.View.Details;
            // 
            // listDoctorCB
            // 
            this.listDoctorCB.FormattingEnabled = true;
            this.listDoctorCB.Location = new System.Drawing.Point(16, 67);
            this.listDoctorCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listDoctorCB.Name = "listDoctorCB";
            this.listDoctorCB.Size = new System.Drawing.Size(292, 21);
            this.listDoctorCB.TabIndex = 4;
            this.listDoctorCB.SelectedIndexChanged += new System.EventHandler(this.listDoctorCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Médico";
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.BackColor = System.Drawing.Color.Red;
            this.closeWindowButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeWindowButton.Location = new System.Drawing.Point(333, 16);
            this.closeWindowButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(19, 20);
            this.closeWindowButton.TabIndex = 6;
            this.closeWindowButton.Text = "X";
            this.closeWindowButton.UseVisualStyleBackColor = false;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // UCDisplayListPatientsOfDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listDoctorCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPatientsOfDoctorLV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCDisplayListPatientsOfDoctor";
            this.Size = new System.Drawing.Size(372, 436);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listPatientsOfDoctorLV;
        private System.Windows.Forms.ComboBox listDoctorCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeWindowButton;
    }
}
