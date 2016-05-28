using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reporteHallazgos
{
    public partial class formMenuInicial : Form
    {
        public formCapturaDeDatos ventanaCapturaDatos = new formCapturaDeDatos(); 
        public formMenuInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ventanaCapturaDatos.cargarArchivosDeTexto(); 
            ventanaCapturaDatos.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            
        }

        private void formMenuInicial_Load(object sender, EventArgs e)
        {
            ventanaCapturaDatos.cargarTodo();              
        }

        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogin ventanaLogin = new formLogin();
            ventanaLogin.Show();
        }
    }
}
