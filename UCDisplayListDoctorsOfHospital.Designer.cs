namespace hospital_project_interface_v2
{
    partial class UCDisplayListDoctorsOfHospital
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
            this.listDoctorsLV = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDoctorsLV
            // 
            this.listDoctorsLV.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.listDoctorsLV.HideSelection = false;
            this.listDoctorsLV.Location = new System.Drawing.Point(32, 50);
            this.listDoctorsLV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listDoctorsLV.Name = "listDoctorsLV";
            this.listDoctorsLV.Size = new System.Drawing.Size(300, 362);
            this.listDoctorsLV.TabIndex = 0;
            this.listDoctorsLV.UseCompatibleStateImageBehavior = false;
            this.listDoctorsLV.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Médicos del Hospital";
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.BackColor = System.Drawing.Color.Red;
            this.closeWindowButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeWindowButton.Location = new System.Drawing.Point(344, 12);
            this.closeWindowButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(19, 20);
            this.closeWindowButton.TabIndex = 6;
            this.closeWindowButton.Text = "X";
            this.closeWindowButton.UseVisualStyleBackColor = false;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // UCDisplayListDoctorsOfHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDoctorsLV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCDisplayListDoctorsOfHospital";
            this.Size = new System.Drawing.Size(394, 421);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listDoctorsLV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeWindowButton;
    }
}
