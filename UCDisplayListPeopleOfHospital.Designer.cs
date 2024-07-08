namespace hospital_project_interface_v2
{
    partial class UCDisplayListPeopleOfHospital
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
            this.listPersonsLV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista Personas del Hospital";
            // 
            // listPersonsLV
            // 
            this.listPersonsLV.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.listPersonsLV.HideSelection = false;
            this.listPersonsLV.Location = new System.Drawing.Point(73, 92);
            this.listPersonsLV.Name = "listPersonsLV";
            this.listPersonsLV.Size = new System.Drawing.Size(596, 693);
            this.listPersonsLV.TabIndex = 2;
            this.listPersonsLV.UseCompatibleStateImageBehavior = false;
            this.listPersonsLV.View = System.Windows.Forms.View.Details;
            // 
            // UCDisplayListPeopleOfHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPersonsLV);
            this.Name = "UCDisplayListPeopleOfHospital";
            this.Size = new System.Drawing.Size(742, 805);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listPersonsLV;
    }
}
