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
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eliminar un Paciente";
            // 
            // listPatientsCB
            // 
            this.listPatientsCB.FormattingEnabled = true;
            this.listPatientsCB.Location = new System.Drawing.Point(43, 77);
            this.listPatientsCB.Margin = new System.Windows.Forms.Padding(2);
            this.listPatientsCB.Name = "listPatientsCB";
            this.listPatientsCB.Size = new System.Drawing.Size(184, 21);
            this.listPatientsCB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(43, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.BackColor = System.Drawing.Color.Red;
            this.closeWindowButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeWindowButton.Location = new System.Drawing.Point(329, 28);
            this.closeWindowButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(19, 20);
            this.closeWindowButton.TabIndex = 5;
            this.closeWindowButton.Text = "X";
            this.closeWindowButton.UseVisualStyleBackColor = false;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // UCDDeleteAPatientOfHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listPatientsCB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCDDeleteAPatientOfHospital";
            this.Size = new System.Drawing.Size(398, 413);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listPatientsCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeWindowButton;
    }
}
