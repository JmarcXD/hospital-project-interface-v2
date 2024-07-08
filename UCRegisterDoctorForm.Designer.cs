namespace hospital_project_interface_v2
{
    partial class UCRegisterDoctorForm
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
            this.registerNewDoctor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.doctorAgeUD = new System.Windows.Forms.NumericUpDown();
            this.doctorLastNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.doctorNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.doctorIdentificationTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeWindowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorAgeUD)).BeginInit();
            this.SuspendLayout();
            // 
            // registerNewDoctor
            // 
            this.registerNewDoctor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerNewDoctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerNewDoctor.Location = new System.Drawing.Point(27, 222);
            this.registerNewDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerNewDoctor.Name = "registerNewDoctor";
            this.registerNewDoctor.Size = new System.Drawing.Size(96, 40);
            this.registerNewDoctor.TabIndex = 19;
            this.registerNewDoctor.Text = "Registrar";
            this.registerNewDoctor.UseVisualStyleBackColor = false;
            this.registerNewDoctor.Click += new System.EventHandler(this.registerNewDoctor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Edad";
            // 
            // doctorAgeUD
            // 
            this.doctorAgeUD.Location = new System.Drawing.Point(256, 149);
            this.doctorAgeUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doctorAgeUD.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.doctorAgeUD.Name = "doctorAgeUD";
            this.doctorAgeUD.Size = new System.Drawing.Size(143, 20);
            this.doctorAgeUD.TabIndex = 17;
            this.doctorAgeUD.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // doctorLastNameTB
            // 
            this.doctorLastNameTB.Location = new System.Drawing.Point(27, 149);
            this.doctorLastNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doctorLastNameTB.Name = "doctorLastNameTB";
            this.doctorLastNameTB.Size = new System.Drawing.Size(145, 20);
            this.doctorLastNameTB.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellido";
            // 
            // doctorNameTB
            // 
            this.doctorNameTB.Location = new System.Drawing.Point(256, 84);
            this.doctorNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doctorNameTB.Name = "doctorNameTB";
            this.doctorNameTB.Size = new System.Drawing.Size(145, 20);
            this.doctorNameTB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre";
            // 
            // doctorIdentificationTB
            // 
            this.doctorIdentificationTB.Location = new System.Drawing.Point(27, 84);
            this.doctorIdentificationTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doctorIdentificationTB.Name = "doctorIdentificationTB";
            this.doctorIdentificationTB.Size = new System.Drawing.Size(145, 20);
            this.doctorIdentificationTB.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Identificación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nuevo Médico";
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.BackColor = System.Drawing.Color.Red;
            this.closeWindowButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeWindowButton.Location = new System.Drawing.Point(382, 16);
            this.closeWindowButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(19, 20);
            this.closeWindowButton.TabIndex = 20;
            this.closeWindowButton.Text = "X";
            this.closeWindowButton.UseVisualStyleBackColor = false;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // UCRegisterDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.registerNewDoctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.doctorAgeUD);
            this.Controls.Add(this.doctorLastNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doctorNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doctorIdentificationTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCRegisterDoctorForm";
            this.Size = new System.Drawing.Size(496, 410);
            ((System.ComponentModel.ISupportInitialize)(this.doctorAgeUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerNewDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown doctorAgeUD;
        private System.Windows.Forms.TextBox doctorLastNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doctorNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox doctorIdentificationTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeWindowButton;
    }
}
