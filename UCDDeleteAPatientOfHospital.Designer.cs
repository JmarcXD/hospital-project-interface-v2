namespace hospital_project_interface_v2
{
    partial class UCDDeleteAPatientOfHospital
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
            this.listPatientsCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eliminar un Paciente";
            // 
            // listPatientsCB
            // 
            this.listPatientsCB.FormattingEnabled = true;
            this.listPatientsCB.Location = new System.Drawing.Point(86, 148);
            this.listPatientsCB.Name = "listPatientsCB";
            this.listPatientsCB.Size = new System.Drawing.Size(365, 33);
            this.listPatientsCB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(86, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UCDDeleteAPatientOfHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listPatientsCB);
            this.Controls.Add(this.label1);
            this.Name = "UCDDeleteAPatientOfHospital";
            this.Size = new System.Drawing.Size(795, 795);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listPatientsCB;
        private System.Windows.Forms.Button button1;
    }
}
