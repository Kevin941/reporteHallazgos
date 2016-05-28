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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBoxContraseña.Text == "JaglHall")||(textBoxContraseña.Text == "conker"))
            {
                formAdministrador ventanaAdministracion = new formAdministrador();
                ventanaAdministracion.Show();
                this.Hide();
                this.Dispose(); 
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
                return; 
            }


        }
    }
}
