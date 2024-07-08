namespace hospital_project_interface_v2
{
    partial class UCRegisterAdminForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.adminIdentificationTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameAdminTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameAdminTB = new System.Windows.Forms.TextBox();
            this.ageAdminUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.registerNewAdmin = new System.Windows.Forms.Button();
            this.closeWindowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageAdminUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificación";
            // 
            // adminIdentificationTB
            // 
            this.adminIdentificationTB.Location = new System.Drawing.Point(22, 83);
            this.adminIdentificationTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminIdentificationTB.Name = "adminIdentificationTB";
            this.adminIdentificationTB.Size = new System.Drawing.Size(145, 20);
            this.adminIdentificationTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // nameAdminTB
            // 
            this.nameAdminTB.Location = new System.Drawing.Point(252, 83);
            this.nameAdminTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameAdminTB.Name = "nameAdminTB";
            this.nameAdminTB.Size = new System.Drawing.Size(145, 20);
            this.nameAdminTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido";
            // 
            // lastNameAdminTB
            // 
            this.lastNameAdminTB.Location = new System.Drawing.Point(22, 148);
            this.lastNameAdminTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameAdminTB.Name = "lastNameAdminTB";
            this.lastNameAdminTB.Size = new System.Drawing.Size(145, 20);
            this.lastNameAdminTB.TabIndex = 6;
            // 
            // ageAdminUD
            // 
            this.ageAdminUD.Location = new System.Drawing.Point(252, 148);
            this.ageAdminUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ageAdminUD.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageAdminUD.Name = "ageAdminUD";
            this.ageAdminUD.Size = new System.Drawing.Size(143, 20);
            this.ageAdminUD.TabIndex = 7;
            this.ageAdminUD.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edad";
            // 
            // registerNewAdmin
            // 
            this.registerNewAdmin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerNewAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerNewAdmin.Location = new System.Drawing.Point(22, 197);
            this.registerNewAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerNewAdmin.Name = "registerNewAdmin";
            this.registerNewAdmin.Size = new System.Drawing.Size(96, 40);
            this.registerNewAdmin.TabIndex = 9;
            this.registerNewAdmin.Text = "Registrar";
            this.registerNewAdmin.UseVisualStyleBackColor = false;
            this.registerNewAdmin.Click += new System.EventHandler(this.registerNewAdmin_Click);
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.BackColor = System.Drawing.Color.Red;
            this.closeWindowButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeWindowButton.Location = new System.Drawing.Point(378, 15);
            this.closeWindowButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(19, 20);
            this.closeWindowButton.TabIndex = 10;
            this.closeWindowButton.Text = "X";
            this.closeWindowButton.UseVisualStyleBackColor = false;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // UCRegisterAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.registerNewAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ageAdminUD);
            this.Controls.Add(this.lastNameAdminTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameAdminTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminIdentificationTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCRegisterAdminForm";
            this.Size = new System.Drawing.Size(471, 431);
            ((System.ComponentModel.ISupportInitialize)(this.ageAdminUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminIdentificationTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameAdminTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameAdminTB;
        private System.Windows.Forms.NumericUpDown ageAdminUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registerNewAdmin;
        private System.Windows.Forms.Button closeWindowButton;
    }
}
