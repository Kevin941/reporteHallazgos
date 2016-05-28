using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reporteHallazgos
{
    public partial class formAdministrareEmpleados : Form
    {
        string tipoEmpleado;
        public Dictionary<string, string> pathsDictionary = new Dictionary<string, string>();
        public bool pathsCargados = false; 
        public formAdministrareEmpleados(string tipoEmpleado)
        {
            this.tipoEmpleado = tipoEmpleado; 
            InitializeComponent();
        }

        

        private void formAdministrarPuestos_Load(object sender, EventArgs e)
        {
            cargarPaths(); 
            switch (tipoEmpleado)
            {
                case "puestos":
                    mostrarConfiguracionPuestos(); 
                    break; 
                case "supervisores":
                    mostrarConfiguracionSupervisores();
                    break;
                case "inspectores":
                    mostrarConfiguracionInspectores();
                    break;
                case "operadores":
                    mostrarConfiguracionOperadores();
                    break;
                case "ayudantes":
                    mostrarConfiguracionAyudantes();
                    break;
                case "identificadoPor":
                    mostrarConfiguracionIdentificadoPor();
                    break;
                case "responsables":
                    mostrarConfiguracionResponsables();
                    break; 

            }
            

        }

        public void cargarPaths()
        {

            try
            {
                if (!pathsCargados)
                {
                    string[] lines = System.IO.File.ReadAllLines(@"" + System.Windows.Forms.Application.StartupPath + "\\paths.txt");
                    pathsDictionary.Add("especificaciones", lines[0]);
                    pathsDictionary.Add("plantillaHallazgos", lines[1]);
                    pathsDictionary.Add("ayudantes", lines[2]);
                    pathsDictionary.Add("enterado", lines[3]);
                    pathsDictionary.Add("identificadoPor", lines[4]);
                    pathsDictionary.Add("inspectores", lines[5]);
                    pathsDictionary.Add("responsables", lines[6]);
                    pathsDictionary.Add("operadores", lines[7]);
                    pathsDictionary.Add("supervisores", lines[8]);
                    pathsCargados = true;
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la base de datos");
                return;
            }

        }
       
        private void mostrarConfiguracionPuestos()
        {
            this.Text = "Administrador de puestos"; 
            dataGridPuestos.Columns.Add("nombre", "Nombre");
            dataGridPuestos.Columns.Add("puesto", "Puesto");
            this.dataGridPuestos.DefaultCellStyle.Font = new Font("Tahoma", 13);
            this.dataGridPuestos.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 13);
            string[] lines = new string[1];
            lines[0] = "Nombre|Puesto";
            try
            {
                //Leemos el archivo de configuracion 
                lines = System.IO.File.ReadAllLines(pathsDictionary["enterado"]);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la configuración actual. Se realizará una nueva configuración.");
            }

            string[] nombres = new string[lines.Length];
            string[] puestos = new string[lines.Length];
            Array.Sort<string>(lines);


            for (int x = 0; x < lines.Length; x++)
            {
                string[] datosSplit = lines[x].Split('|');
                string nombre = datosSplit[0];
                string puesto = datosSplit[1];

                dataGridPuestos.Rows.Add(nombre, puesto);
            }

            autosizeGrid();
        }

        private void mostrarConfiguracionSupervisores()
        {
            this.Text = "Administrador de supervisores";
            dataGridPuestos.Columns.Add("nombre", "Nombre del supervisor");
            
            this.dataGridPuestos.DefaultCellStyle.Font = new Font("Tahoma", 13);
            this.dataGridPuestos.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 13);
            string[] lines = new string[1];
            lines[0] = "Nombre";
            try
            {
                //Leemos el archivo de configuracion 
                lines = System.IO.File.ReadAllLines(pathsDictionary["supervisores"]);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la configuración actual. Se realizará una nueva configuración.");
            }

            
            Array.Sort<string>(lines);

            for (int x = 0; x < lines.Length; x++)
            {
                dataGridPuestos.Rows.Add(lines[x]);
            }

            autosizeGrid();
        }

        private void mostrarConfiguracionOperadores()
        {
            this.Text = "Administrador de operadores";
            dataGridPuestos.Columns.Add("nombre", "Nombre del operador");

            this.dataGridPuestos.DefaultCellStyle.Font = new Font("Tahoma", 13);
            this.dataGridPuestos.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 13);
            string[] lines = new string[1];
            lines[0] = "Nombre";
            try
            {
                //Leemos el archivo de configuracion 
                lines = System.IO.File.ReadAllLines(pathsDictionary["operadores"]);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la configuración actual. Se realizará una nueva configuración.");
            }


            Array.Sort<string>(lines);

            for (int x = 0; x < lines.Length; x++)
            {
                dataGridPuestos.Rows.Add(lines[x]);
            }

            autosizeGrid();
        }

        private void mostrarConfiguracionAyudantes()
        {
            this.Text = "Administrador de Ayudantes";
            dataGridPuestos.Columns.Add("nombre", "Nombre del ayudante");

            this.dataGridPuestos.DefaultCellStyle.Font = new Font("Tahoma", 13);
            this.dataGridPuestos.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 13);
            string[] lines = new string[1];
            lines[0] = "Nombre";
            try
            {
                //Leemos el archivo de configuracion 
                lines = System.IO.File.ReadAllLines(pathsDictionary["ayudantes"]);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la configuración actual. Se realizará una nueva configuración.");
            }


            Array.Sort<string>(lines);

            for (int x = 0; x < lines.Length; x++)
            {
                dataGridPuestos.Rows.Add(lines[x]);
            }

            autosizeGrid();
        }

        private void mostrarConfiguracionIdentificadoPor()
        {
            this.Text = "Administrador de \"Identificado por\"";
            dataGridPuestos.Columns.Add("nombre", "Nombre de empleado");

            this.dataGridPuestos.DefaultCellStyle.Font = new Font("Tahoma", 13);
            this.dataGridPuestos.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 13);
            string[] lines = new string[1];
            lines[0] = "Nombre";
            try
            {
                //Leemos el archivo de configuracion 
                lines = System.IO.File.ReadAllLines(pathsDictionary["identificadoPor"]);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la configuración actual. Se realizará una nueva configuración.");
            }


            Array.Sort<string>(lines);

            for (int x = 0; x < lines.Length; x++)
            {
                dataGridPuestos.Rows.Add(lines[x]);
            }

            autosizeGrid();
        }

        private void mostrarConfiguracionResponsables()
        {
            this.Text = "Administrador de operadores";
            dataGridPuestos.Columns.Add("nombre", "Nombre del responsable");

            this.dataGridPuestos.DefaultCellStyle.Font = new Font("Tahoma", 13);
            this.dataGridPuestos.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 13);
            string[] lines = new string[1];
            lines[0] = "Nombre";
            try
            {
                //Leemos el archivo de configuracion 
                lines = System.IO.File.ReadAllLines(pathsDictionary["responsables"]);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la configuración actual. Se realizará una nueva configuración.");
            }


            Array.Sort<string>(lines);

            for (int x = 0; x < lines.Length; x++)
            {
                dataGridPuestos.Rows.Add(lines[x]);
            }

            autosizeGrid();
        }

        private void mostrarConfiguracionInspectores()
        {
            this.Text = "Administrador de puestos";
            dataGridPuestos.Columns.Add("nombre", "Nombre del inspector");

            this.dataGridPuestos.DefaultCellStyle.Font = new Font("Tahoma", 13);
            this.dataGridPuestos.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 13);
            string[] lines = new string[1];
            lines[0] = "Nombre";
            try
            {
                //Leemos el archivo de configuracion 
                lines = System.IO.File.ReadAllLines(pathsDictionary["inspectores"]);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la configuración actual. Se realizará una nueva configuración.");
            }


            Array.Sort<string>(lines);

            for (int x = 0; x < lines.Length; x++)
            {
                dataGridPuestos.Rows.Add(lines[x]);
            }

            autosizeGrid();
        }



        private void autosizeGrid()
        {

            
            dataGridPuestos.AllowUserToResizeColumns = true;

            dataGridPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPuestos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

        private void generarArchivoDeConfiguracionPuestos()
        {
            string[] lines = new string[dataGridPuestos.Rows.Count];
             
            //Se pone false para indicar que se sobreescribira el archivo en caso de existir
            using (StreamWriter escritor = new StreamWriter(pathsDictionary["enterado"], false))
            {
                for (int x = 0; x < dataGridPuestos.Rows.Count; x++)
                {
                    if ((dataGridPuestos.Rows[x].Cells[0].Value == null) || (dataGridPuestos.Rows[x].Cells[1].Value == null))
                    {
                        break; 
                    }
                    lines[x] = dataGridPuestos.Rows[x].Cells[0].Value.ToString() + "|" + dataGridPuestos.Rows[x].Cells[1].Value.ToString();                    
                }

                Array.Sort<string>(lines);
                for (int x = 0; x < lines.Length; x++)
                {
                    if ((lines[x] != "")&&(lines[x] != null))
                    {
                        escritor.WriteLine(lines[x]);
                    }
                }
            }

            
        }


        private void generarArchivoDeConfiguracionSupervisores()
        {
            string[] lines = new string[dataGridPuestos.Rows.Count];

            //Se pone false para indicar que se sobreescribira el archivo en caso de existir
            using (StreamWriter escritor = new StreamWriter(pathsDictionary["supervisores"], false))
            {
                for (int x = 0; x < dataGridPuestos.Rows.Count; x++)
                {
                    if ((dataGridPuestos.Rows[x].Cells[0].Value == null))
                    {
                        break;
                    }
                    lines[x] = dataGridPuestos.Rows[x].Cells[0].Value.ToString();
                }

                Array.Sort<string>(lines);
                for (int x = 0; x < lines.Length; x++)
                {
                    if ((lines[x] != "") && (lines[x] != null))
                    {
                        escritor.WriteLine(lines[x]);
                    }
                }
            }


        }

        private void generarArchivoDeConfiguracionInspectores()
        {
            string[] lines = new string[dataGridPuestos.Rows.Count];

            //Se pone false para indicar que se sobreescribira el archivo en caso de existir
            using (StreamWriter escritor = new StreamWriter(pathsDictionary["inspectores"], false))
            {
                for (int x = 0; x < dataGridPuestos.Rows.Count; x++)
                {
                    if ((dataGridPuestos.Rows[x].Cells[0].Value == null))
                    {
                        break;
                    }
                    lines[x] = dataGridPuestos.Rows[x].Cells[0].Value.ToString();
                }

                Array.Sort<string>(lines);
                for (int x = 0; x < lines.Length; x++)
                {
                    if ((lines[x] != "") && (lines[x] != null))
                    {
                        escritor.WriteLine(lines[x]);
                    }
                }
            }


        }

        private void generarArchivoDeConfiguracionOperadores()
        {
            string[] lines = new string[dataGridPuestos.Rows.Count];

            //Se pone false para indicar que se sobreescribira el archivo en caso de existir
            using (StreamWriter escritor = new StreamWriter(pathsDictionary["operadores"], false))
            {
                for (int x = 0; x < dataGridPuestos.Rows.Count; x++)
                {
                    if ((dataGridPuestos.Rows[x].Cells[0].Value == null))
                    {
                        break;
                    }
                    lines[x] = dataGridPuestos.Rows[x].Cells[0].Value.ToString();
                }

                Array.Sort<string>(lines);
                for (int x = 0; x < lines.Length; x++)
                {
                    if ((lines[x] != "") && (lines[x] != null))
                    {
                        escritor.WriteLine(lines[x]);
                    }
                }
            }


        }
        private void generarArchivoDeConfiguracionIdentificadoPor()
        {
            string[] lines = new string[dataGridPuestos.Rows.Count];

            //Se pone false para indicar que se sobreescribira el archivo en caso de existir
            using (StreamWriter escritor = new StreamWriter(pathsDictionary["identificadoPor"], false))
            {
                for (int x = 0; x < dataGridPuestos.Rows.Count; x++)
                {
                    if ((dataGridPuestos.Rows[x].Cells[0].Value == null))
                    {
                        break;
                    }
                    lines[x] = dataGridPuestos.Rows[x].Cells[0].Value.ToString();
                }

                Array.Sort<string>(lines);
                for (int x = 0; x < lines.Length; x++)
                {
                    if ((lines[x] != "") && (lines[x] != null))
                    {
                        escritor.WriteLine(lines[x]);
                    }
                }
            }


        }
        private void generarArchivoDeConfiguracionAyudantes()
        {
            string[] lines = new string[dataGridPuestos.Rows.Count];

            //Se pone false para indicar que se sobreescribira el archivo en caso de existir
            using (StreamWriter escritor = new StreamWriter(pathsDictionary["ayudantes"], false))
            {
                for (int x = 0; x < dataGridPuestos.Rows.Count; x++)
                {
                    if ((dataGridPuestos.Rows[x].Cells[0].Value == null))
                    {
                        break;
                    }
                    lines[x] = dataGridPuestos.Rows[x].Cells[0].Value.ToString();
                }

                Array.Sort<string>(lines);
                for (int x = 0; x < lines.Length; x++)
                {
                    if ((lines[x] != "") && (lines[x] != null))
                    {
                        escritor.WriteLine(lines[x]);
                    }
                }
            }


        }
        private void generarArchivoDeConfiguracionResponsables()
        {
            string[] lines = new string[dataGridPuestos.Rows.Count];

            //Se pone false para indicar que se sobreescribira el archivo en caso de existir
            using (StreamWriter escritor = new StreamWriter(pathsDictionary["responsables"], false))
            {
                for (int x = 0; x < dataGridPuestos.Rows.Count; x++)
                {
                    if ((dataGridPuestos.Rows[x].Cells[0].Value == null))
                    {
                        break;
                    }
                    lines[x] = dataGridPuestos.Rows[x].Cells[0].Value.ToString();
                }

                Array.Sort<string>(lines);
                for (int x = 0; x < lines.Length; x++)
                {
                    if ((lines[x] != "") && (lines[x] != null))
                    {
                        escritor.WriteLine(lines[x]);
                    }
                }
            }


        }


        private void buttonGuardarConfiguracion_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            switch (tipoEmpleado)
            {
                case "puestos":
                    guardarPuestos(); 
                    break;
                case "supervisores":
                    guardarSupervisores(); 
                    break;
                case "inspectores":
                    guardarInspectores(); 
                    break;
                case "operadores":
                    guardarOperadores(); 
                    break;
                case "identificadoPor":
                    guardarIdentificadoPor();
                    break;
                case "ayudantes":
                    guardarAyudantes();
                    break;
                case "responsables":
                    guardarResponsables();
                    break;
            } 
            
        }

        private void guardarIdentificadoPor()
        {
            try
            {
                generarArchivoDeConfiguracionIdentificadoPor();
                MessageBox.Show("Configuración guardada");
                this.Hide();
                this.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
        private void guardarAyudantes()
        {
            try
            {
                generarArchivoDeConfiguracionAyudantes();
                MessageBox.Show("Configuración guardada");
                this.Hide();
                this.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
        private void guardarResponsables()
        {
            try
            {
                generarArchivoDeConfiguracionResponsables();
                MessageBox.Show("Configuración guardada");
                this.Hide();
                this.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
        private void guardarOperadores()
        {
            try
            {
                generarArchivoDeConfiguracionOperadores();
                MessageBox.Show("Configuración guardada");
                this.Hide();
                this.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }


        private void guardarInspectores()
        {
            try
            {
                generarArchivoDeConfiguracionInspectores();
                MessageBox.Show("Configuración guardada");
                this.Hide();
                this.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void guardarSupervisores()
        {
            try
            {
                generarArchivoDeConfiguracionSupervisores();
                MessageBox.Show("Configuración guardada");
                this.Hide();
                this.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void guardarPuestos()
        {
            try
            {
                generarArchivoDeConfiguracionPuestos();
                MessageBox.Show("Configuración guardada");
                this.Hide();
                this.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}
