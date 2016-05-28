namespace reporteHallazgos
{
    partial class formAdministrareEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdministrareEmpleados));
            this.dataGridPuestos = new System.Windows.Forms.DataGridView();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPuestos
            // 
            this.dataGridPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPuestos.Location = new System.Drawing.Point(12, 12);
            this.dataGridPuestos.Name = "dataGridPuestos";
            this.dataGridPuestos.Size = new System.Drawing.Size(839, 407);
            this.dataGridPuestos.TabIndex = 0;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonGuardar.Location = new System.Drawing.Point(12, 425);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(839, 59);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // formAdministrareEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 496);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridPuestos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAdministrareEmpleados";
            this.Text = "Administrar";
            this.Load += new System.EventHandler(this.formAdministrarPuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPuestos;
        private System.Windows.Forms.Button buttonGuardar;
    }
}