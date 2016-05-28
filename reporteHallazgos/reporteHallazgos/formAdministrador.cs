using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reporteHallazgos
{
    public partial class formAdministrador : Form
    {
        public formAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAdministrareEmpleados ventanaPuestos = new formAdministrareEmpleados("puestos");
            ventanaPuestos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formHistorial ventanaHistorial = new formHistorial();
            ventanaHistorial.Show(); 
        }

        private void buttonAdministrarSupervisores_Click(object sender, EventArgs e)
        {
            formAdministrareEmpleados ventanaSupervisores = new formAdministrareEmpleados("supervisores");
            ventanaSupervisores.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formAdministrareEmpleados ventanaPuestos = new formAdministrareEmpleados("operadores");
            ventanaPuestos.Show();
        }

        private void buttonInspectores_Click(object sender, EventArgs e)
        {
            formAdministrareEmpleados ventanaPuestos = new formAdministrareEmpleados("inspectores");
            ventanaPuestos.Show();
        }

        private void buttonAdministrarResponsables_Click(object sender, EventArgs e)
        {
            formAdministrareEmpleados ventanaResponsables = new formAdministrareEmpleados("responsables");
            ventanaResponsables.Show();
        }

        private void buttonAdministrarAyudantes_Click(object sender, EventArgs e)
        {
            formAdministrareEmpleados ventanaAyudantes = new formAdministrareEmpleados("ayudantes");
            ventanaAyudantes.Show();
        }

        private void buttonIdentificadoPor_Click(object sender, EventArgs e)
        {
            formAdministrareEmpleados ventanaIdentificadoPor = new formAdministrareEmpleados("identificadoPor");
            ventanaIdentificadoPor.Show();
        }


    }
}
