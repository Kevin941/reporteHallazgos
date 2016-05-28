using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel; 

using System.Windows.Forms;
using System.Data.OleDb; //Pendiente descargar: https://www.microsoft.com/es-mx/download/confirmation.aspx?id=39358 
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Drawing.Printing;

namespace reporteHallazgos
{
    
    public partial class formCapturaDeDatos : Form
    {
        public classHistorial registroHistorial = new classHistorial(); 
        public string [] arregloLotes;
        public empleado[] arregloEnterado;
        public string[] responsables;
        public string[] operadores;
        public string[] ayudantes;
        public string[] supervisores;
        public string[] inspectores;
        public string[] identificadoPor;
        
        public string connectionStringEspecificaciones = "";        
        public System.Data.DataTable tablaEspecificaciones = new System.Data.DataTable();        
        public bool enImpresion = false; 
        
        public Dictionary<string, string> pathsDictionary = new Dictionary<string, string>();
        public bool pathsCargados; 
	


        public formCapturaDeDatos()
        {
            InitializeComponent();
        }

        public void cargarTodo()
        {
            this.cargarPaths();
            this.cargarAyudantes();
            this.cargarBaseDeDatos();
            this.cargarEnterado();
            this.cargarIdentificadoPor();
            this.cargarInspectores();
            this.cargarResponsables(); 
        }

        public void cargarArchivosDeTexto()
        {
            this.cargarPaths();
            this.cargarAyudantes();            
            this.cargarEnterado();
            this.cargarIdentificadoPor();
            this.cargarInspectores();
            this.cargarResponsables();
            this.cargarSupervisores();
            this.cargarOperadores();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pantallaPrincipal_Load(object sender, EventArgs e)
        {
            //Obtenemos la localización del archivo de especificaciones.

            
            cargarResponsables();
            cargarEnterado();
            cargarOperadores();
            cargarInspectores();
            cargarSupervisores();
            cargarAyudantes(); 


        }

        

        private void cargarOperadores()
        {
                   
        
            try
            {
                comboBoxOperadorEnTurno.Items.Clear();
                operadores = System.IO.File.ReadAllLines(pathsDictionary["operadores"]);
                //operadores = System.IO.File.ReadAllLines(@"" + System.Windows.Forms.Application.StartupPath + "\\operadores.txt");
                for (int x = 0; x < operadores.Length; x++)
                {
                    comboBoxOperadorEnTurno.Items.Add(operadores[x]);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el archivo de operadores");
            }
        }

        public void cargarAyudantes()
        {


            try
            {

                comboBoxAyudanteEnTurno.Items.Clear();

                ayudantes = System.IO.File.ReadAllLines(pathsDictionary["ayudantes"]);
                for (int x = 0; x < ayudantes.Length; x++)
                {
                    comboBoxAyudanteEnTurno.Items.Add(ayudantes[x]);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el archivo de ayudantes");
            }
        }

        public void cargarInspectores()
        {


            try
            {
                comboBoxInspectorDeCalidadEnTurno.Items.Clear(); 
                inspectores = System.IO.File.ReadAllLines(pathsDictionary["inspectores"]);
                for (int x = 0; x < inspectores.Length; x++)
                {
                    comboBoxInspectorDeCalidadEnTurno.Items.Add(inspectores[x]);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el archivo de inspectores");
            }
        }

        private void cargarSupervisores()
        {


            try
            {

                comboBoxSupervisorEnTurno.Items.Clear();
                supervisores = System.IO.File.ReadAllLines(pathsDictionary["supervisores"]);
                for (int x = 0; x < supervisores.Length; x++)
                {
                    comboBoxSupervisorEnTurno.Items.Add(supervisores[x]);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el archivo de supervisores");
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
                    pathsDictionary.Add("historial", lines[9]);
                    getTablaEspecificaciones();
                    registroHistorial.setStringBD(lines[9]);                     
                    pathsCargados = true;
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la base de datos");
                return;
            }
            
        }

        public void cargarBaseDeDatos()
        {
            try
            {
                getTablaEspecificaciones();
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la base de datos");
                return;
            }
        }

        public void cargarResponsables()
        {
            try
            {
                comboBoxResponsables.Items.Clear(); 
                
                responsables = System.IO.File.ReadAllLines(pathsDictionary["responsables"]);
                for (int x = 0; x < responsables.Length; x++)
                {
                    comboBoxResponsables.Items.Add(responsables[x]);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el archivo de responsables");
            }
        }

        public void cargarIdentificadoPor()
        {
            try
            {
                comboBoxIdentificadoPor.Items.Clear();                 
                identificadoPor = System.IO.File.ReadAllLines(pathsDictionary["identificadoPor"]);
                for (int x = 0; x < identificadoPor.Length; x++)
                {
                    comboBoxIdentificadoPor.Items.Add(identificadoPor[x]);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el archivo de identificadoPor");
            }
        }

        public void getConnectionStringEspecificaciones()
        {
            //connectionStringEspecificaciones = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.pathArchivoExcelOrigenEspecificaciones + "; Extended Properties=" + "\"" + "Excel 12.0 Macro;HDR=YES;IMEX=1" + "\"" + ";";
            //connectionStringEspecificaciones = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.pathArchivoExcelOrigenEspecificaciones + "; Extended Properties=" + "\"" + "Excel 12.0 Macro;HDR=YES;IMEX=1;" + "\"" + ";";
            connectionStringEspecificaciones = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.pathsDictionary["especificaciones"]  +"; Extended Properties=\"Excel 8.0;HDR=YES\"";
            //MessageBox.Show(connectionStringEspecificaciones); 
            return;
        }

        private void getTablaEspecificaciones()
        {
            try
            {
                OleDbConnection conexion = new OleDbConnection();
                this.getConnectionStringEspecificaciones();
                conexion.ConnectionString = this.connectionStringEspecificaciones;
                OleDbCommand comando = new OleDbCommand();
                //F1 es el nombre de la primera columna del archivo
                //comando.CommandText = "Select * from [Hoja de Especificaciones grales$];";
                comando.CommandText = "Select " +
                "[Generales] AS `cliente`, " +
                "[Generales1] AS `material`, " +
                "[Generales2] AS `calibre`, " +
                "[Generales3] AS `color`, " +
                "[Generales4] AS `corte`, " +
                "[Generales6] AS `perfil`, " +
                "[F1] AS `clave` " +             
                "from [Hoja de Especificaciones grales$];";
                // MessageBox.Show(comando.CommandText); 
                //comando.CommandText = "Select * from [Hoja de Especificaciones grales$A3] where NOT 'F1' = '';"; 
                comando.Connection = conexion;
                DataSet setDatos = new DataSet();
                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(setDatos);
                tablaEspecificaciones = setDatos.Tables[0];
                



            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());                
            }

        }

        private void buttonCapturarLotes_Click(object sender, EventArgs e)
        {

            try
            {
                if (int.Parse(textBoxCantidadDeLotes.Text) < 1)
                {
                    MessageBox.Show("Ingresa un número mayor a 0 para la cantidad de lotes");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor introduce un número entero para el número de lotes.");
                return;
            }
            


            formCapturaLotes ventanaCapturaDeLotes = new formCapturaLotes(int.Parse(textBoxCantidadDeLotes.Text), textBoxPrefijo.Text);
            ventanaCapturaDeLotes.ShowDialog();
            
            if (ventanaCapturaDeLotes.arregloDeLotes == null)
            {
                MessageBox.Show("Se canceló la captura de lotes.");
                return; 
            }
            else
            {
                //Copiar aqui los lotes capturados. 
                arregloLotes = new string[ventanaCapturaDeLotes.arregloDeLotes.Length];
                for (int x = 0; x < ventanaCapturaDeLotes.arregloDeLotes.Length; x++ )
                {
                    arregloLotes[x] = ventanaCapturaDeLotes.arregloDeLotes[x]; 
                }
            }
            MessageBox.Show(ventanaCapturaDeLotes.cadena); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ajustar el texto de los productos. 
            //Esconder el botón de administración. 

            
            if (!validacionDeDatos())
            {
                return; 
            }

            generarObjetoHistorial();
            registroHistorial.insertRecord(); 
            guardarResponsables();
            cargarResponsables();
            guardarIdentificadoPor();
            cargarIdentificadoPor();
            guardarAyudantes();
            cargarAyudantes(); 
            cargarIdentificadoPor();

            
            

            imprimeDesdeExcel(); 
        }

        private void guardarAyudantes()
        {

            if ((comboBoxAyudanteEnTurno.Text == null) || (comboBoxAyudanteEnTurno.Text == ""))
                return;

            using (StreamWriter newTask = new StreamWriter(pathsDictionary["ayudantes"], false, Encoding.UTF8))
            {
                
                bool contiene = false;
                if (ayudantes != null)
                {
                    if (ayudantes.Length > 0)
                    {
                        for (int x = 0; x < ayudantes.Length; x++)
                        {
                            if (ayudantes[x] == comboBoxAyudanteEnTurno.Text)
                            {
                                contiene = true;
                                break;
                            }
                        }
                    }
                }




                if (!contiene)
                {
                    string[] ayudantesTemporal = new string[ayudantes.Length + 1];
                    for (int x = 0; x < ayudantes.Length; x++)
                    {
                        ayudantesTemporal[x] = ayudantes[x];

                    }

                    ayudantesTemporal[ayudantesTemporal.Length - 1] = comboBoxAyudanteEnTurno.Text;

                    Array.Sort<string>(ayudantesTemporal);
                    //Solo se agregan los responsables arreglo 
                    for (int x = 0; x < ayudantesTemporal.Length; x++)
                    {
                        newTask.WriteLine(ayudantesTemporal[x]);

                    }
                }
                else
                {
                    //Ordenamos el arreglo albéticamente
                    Array.Sort<string>(ayudantes);
                    //Solo se agregan los del arreglo 
                    for (int x = 0; x < ayudantes.Length; x++)
                    {
                        newTask.WriteLine(ayudantes[x]);

                    }
                }
            }
        }

        private void generarObjetoHistorial()
        {

            registroHistorial.turno = comboBoxTurno.Text;
            registroHistorial.lotes = "";

            registroHistorial.identificadoPor = comboBoxIdentificadoPor.Text;
            registroHistorial.catidadLotes = textBoxCantidadDeLotes.Text;
            if (arregloLotes != null)
            {
                for (int x = 0; x < arregloLotes.Length; x++)
                {
                    if (x != 0)
                    {
                        registroHistorial.lotes += ", " + arregloLotes[x].ToString();
                    }
                    else
                    {
                        registroHistorial.lotes += arregloLotes[x].ToString();
                    }
                }
            }
            registroHistorial.fecha = dateTimePickerFecha.Text; 
            registroHistorial.pedido = textBoxPedido.Text;
            registroHistorial.responsable = comboBoxResponsables.Text;
            registroHistorial.cantidadInicial = textBoxCantidadInicial.Text;
            registroHistorial.unidadInicial = comboBoxUnidadesInicial.Text;
            registroHistorial.cantidadFinal = textBoxCantidadFinal.Text;
            registroHistorial.unidadFinal = comboBoxUnidadesFinal.Text;
            registroHistorial.disposicion = comboBoxDisposicion.Text;
            registroHistorial.clave = textBoxClave.Text;
            registroHistorial.cliente = textBoxCliente.Text;
            registroHistorial.calibre = textBoxCalibre.Text;
            registroHistorial.material = textBoxMaterial.Text;
            registroHistorial.color = textBoxColor.Text;
            registroHistorial.perfil = textBoxPerfil.Text; 
            
            registroHistorial.corte = textBoxCorte.Text; 
            registroHistorial.descripcion = richTextBoxDescripcion.Text;
            registroHistorial.inspeccionesRealizadas = richTextBoxInspeccionesRealizadas.Text; 

            registroHistorial.probableCausa = richTextBoxCausa.Text;
            registroHistorial.observaciones = richTextBoxObservaciones.Text;
            registroHistorial.enterado = comboBoxEnterado.SelectedItem.ToString();
            registroHistorial.ayudanteEnTurno = comboBoxAyudanteEnTurno.Text; 

            if (comboBoxInspectorDeCalidadEnTurno.SelectedItem == null)
                registroHistorial.inspectorDeCalidadEnTurno = "";             
            else
                registroHistorial.inspectorDeCalidadEnTurno = comboBoxInspectorDeCalidadEnTurno.SelectedItem.ToString();
            
            
            
            if (comboBoxOperadorEnTurno.SelectedItem == null)
                registroHistorial.operadorEnTurno = "";
            else
                registroHistorial.operadorEnTurno = comboBoxOperadorEnTurno.SelectedItem.ToString();

            if (comboBoxSupervisorEnTurno.SelectedItem == null)
                registroHistorial.supervisorEnTurno = "";
            else
                registroHistorial.supervisorEnTurno = comboBoxSupervisorEnTurno.SelectedItem.ToString();




        }

        private bool validacionDeDatos()
        {
            /*
             * a)	Fecha 
b)	turno
c)	identificado por 
d)	Responsable 
e)	Cantidad 
f)	Unidad disposición 
g)	Descripción 
h)	Probable causa
            
             * */
            
            if(comboBoxTurno.SelectedItem==null)
            {
                MessageBox.Show("Por favor seleciona un turno");
                return false; 
            }

            if ((comboBoxEnterado.SelectedItem == null))  
            {
                MessageBox.Show("Por favor llena el campo \"Enterado\"");
                return false; 
            }


            if ((comboBoxResponsables.Text == "") || (comboBoxResponsables.Text == null))
            {
                comboBoxResponsables.Text = ""; 
                
            }



            if (textBoxCantidadInicial.Text != "")
            {
                


                try
                {
                    double.Parse(textBoxCantidadInicial.Text);
                }
                catch
                {
                    MessageBox.Show("Introduce un número para la cantidad inicial");
                    return false;
                }
            }

            if (textBoxCantidadInicial.Text != "")
            {
                try
                {
                    double.Parse(textBoxCantidadFinal.Text);
                }
                catch
                {
                    MessageBox.Show("Introduce un número para la cantidad final");
                    return false;
                }
            }

            if ((comboBoxUnidadesInicial.SelectedItem == null)&&(textBoxCantidadInicial.Text != ""))
            {
                MessageBox.Show("Por favor seleciona una unidad inicial");
                return false;
            }

            if ((comboBoxUnidadesFinal.SelectedItem == null) && (textBoxCantidadFinal.Text != ""))
            {
                MessageBox.Show("Por favor seleciona una unidad final");
                return false;
            }

            if (comboBoxDisposicion.SelectedItem == null)
            {
                comboBoxDisposicion.Text = "";
                
            }

            if (richTextBoxDescripcion.Text == "")
            {
                MessageBox.Show("Por favor introduce una descripción");
                return false;
            }

            if (richTextBoxCausa.Text == "")
            {
                MessageBox.Show("Por favor introduce una probable causa");
                return false;
            }

            
            
            
            

           
            return true; 
        }

        public void cargarEnterado()
        {

            //88 
            //75
            string[] temp; 
            try
            {

                comboBoxEnterado.Items.Clear();
                temp = System.IO.File.ReadAllLines(pathsDictionary["enterado"]);
                arregloEnterado = new empleado[temp.Length]; 

                for (int x = 0; x < temp.Length; x++)
                {
                    arregloEnterado[x] = new empleado(); 
                    string[] datosSplit = temp[x].Split('|');
                    string nombre = datosSplit[0];
                    string puesto = datosSplit[1];
                    arregloEnterado[x].nombre = nombre;
                    arregloEnterado[x].puesto = puesto; 
                    comboBoxEnterado.Items.Add(nombre);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el archivo de configuración (Identificado por)");
            }
        }

        

        private void guardarResponsables()
        {
            if ((comboBoxResponsables.Text == null) || (comboBoxResponsables.Text == ""))
                return; 
            
            using (StreamWriter newTask = new StreamWriter(pathsDictionary["responsables"], false, Encoding.UTF8))
            {
                bool contiene = false;
                if (responsables != null)
                {
                    if (responsables.Length > 0)
                    {
                        for (int x = 0; x < responsables.Length; x++)
                        {
                            if (responsables[x] == comboBoxResponsables.Text)
                            {
                                contiene = true;
                                break;
                            }
                        }
                    }
                }
            
               


                if (!contiene)
                {
                    string []responsablesTemporal = new string[responsables.Length+1];
                    for (int x = 0; x < responsables.Length; x++)
                    {
                        responsablesTemporal[x] = responsables[x]; 

                    }

                    responsablesTemporal[responsablesTemporal.Length - 1] = comboBoxResponsables.Text;

                    Array.Sort<string>(responsablesTemporal);
                    //Solo se agregan los responsables arreglo 
                    for (int x = 0; x < responsablesTemporal.Length; x++)
                    {
                        newTask.WriteLine(responsablesTemporal[x]);

                    }                    
                }
                else
                {
                    //Ordenamos el arreglo albéticamente
                    Array.Sort<string>(responsables);
                    //Solo se agregan los del arreglo 
                    for (int x = 0; x < responsables.Length; x++)
                    {
                        newTask.WriteLine(responsables[x]);

                    }
                }

            }
        }


        private void guardarIdentificadoPor()
        {

            if ((comboBoxIdentificadoPor.Text == null) || (comboBoxIdentificadoPor.Text == ""))
                return;

            using (StreamWriter newTask = new StreamWriter(pathsDictionary["identificadoPor"], false, Encoding.UTF8))
            {
                bool contiene = false;
                if (identificadoPor != null)
                {
                    if (identificadoPor.Length > 0)
                    {
                        for (int x = 0; x < identificadoPor.Length; x++)
                        {
                            if (identificadoPor[x] == comboBoxIdentificadoPor.Text)
                            {
                                contiene = true;
                                break;
                            }
                        }
                    }
                }




                if (!contiene)
                {
                    string[] identificadoPorTemporal = new string[identificadoPor.Length + 1];
                    for (int x = 0; x < identificadoPor.Length; x++)
                    {
                        identificadoPorTemporal[x] = identificadoPor[x];

                    }

                    identificadoPorTemporal[identificadoPorTemporal.Length - 1] = comboBoxIdentificadoPor.Text;

                    Array.Sort<string>(identificadoPorTemporal);
                    //Solo se agregan los responsables arreglo 
                    for (int x = 0; x < identificadoPorTemporal.Length; x++)
                    {
                        newTask.WriteLine(identificadoPorTemporal[x]);

                    }
                }
                else
                {
                    //Ordenamos el arreglo albéticamente
                    Array.Sort<string>(identificadoPor);
                    //Solo se agregan los del arreglo 
                    for (int x = 0; x < identificadoPor.Length; x++)
                    {
                        newTask.WriteLine(identificadoPor[x]);

                    }
                }
            }
        }

        private void imprimeDesdeExcel()
        {
            enImpresion = true; 
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(pathPlantillaReporte, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, false, Microsoft.Office.Interop.Excel.XlCorruptLoad.xlNormalLoad);
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(pathsDictionary["plantillaHallazgos"]);
            Microsoft.Office.Interop.Excel.Sheets sheets = xlWorkBook.Worksheets;
            Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlApp.ActiveSheet;
            xlApp.Visible = true;
            xlWorkBook.Saved = true;
            object misValue = System.Reflection.Missing.Value;

           
           
            
            //Modificamos los valores del excel 
            xlWorkSheet.Cells[3, 3] = dateTimePickerFecha.Text;
            //Renglon 3 columna 7
            xlWorkSheet.Cells[3, 7] = registroHistorial.turno;
            xlWorkSheet.Cells[4, 5] = registroHistorial.identificadoPor;
            xlWorkSheet.Cells[5, 3] = registroHistorial.cliente;
            xlWorkSheet.Cells[5, 8] = registroHistorial.pedido;
            xlWorkSheet.Cells[6, 5] = registroHistorial.responsable;
            xlWorkSheet.Cells[7, 4] = registroHistorial.supervisorEnTurno;
            xlWorkSheet.Cells[7, 8] = registroHistorial.operadorEnTurno;
            xlWorkSheet.Cells[8, 5] = registroHistorial.inspectorDeCalidadEnTurno;
            xlWorkSheet.Cells[8, 8] = registroHistorial.ayudanteEnTurno;


            xlWorkSheet.Cells[10, 3] = registroHistorial.material;
            xlWorkSheet.Cells[11, 3] = registroHistorial.calibre;
            xlWorkSheet.Cells[12, 3] = registroHistorial.color;
            xlWorkSheet.Cells[13, 3] = registroHistorial.perfil;

            xlWorkSheet.Cells[10, 7] = registroHistorial.corte;
            xlWorkSheet.Cells[11, 7] = registroHistorial.lotes;
            
            
            
            //xlWorkSheet.Rows("9:9").EntireRow.AutoFit
            xlWorkSheet.Cells[12, 7] = registroHistorial.cantidadInicial;
            xlWorkSheet.Cells[12, 9] = registroHistorial.unidadInicial;

            xlWorkSheet.Cells[13, 7] = registroHistorial.cantidadFinal;
            xlWorkSheet.Cells[13, 9] = registroHistorial.unidadFinal;

            xlWorkSheet.Cells[15, 5] = registroHistorial.disposicion;

            xlWorkSheet.Cells[17, 1] = registroHistorial.descripcion;
            xlWorkSheet.Cells[19, 1] = registroHistorial.inspeccionesRealizadas;


            xlWorkSheet.Cells[21, 1] = registroHistorial.probableCausa;
            xlWorkSheet.Cells[23, 1] = registroHistorial.observaciones;

            xlWorkSheet.Cells[25, 1] = registroHistorial.enterado;


            /*
            int indice = 0; 
            for (int x = 0; x < arregloEnterado.Length; x++ )
            {
                if (arregloEnterado[x].nombre == comboBoxIdentificadoPor.Text)
                {
                    indice = x;
                    break; 
                }
            }
            */
            xlWorkSheet.Cells[26, 1] = arregloEnterado[comboBoxEnterado.SelectedIndex].puesto;

            xlWorkSheet.Cells[25, 8] = "Mauro Corona Martínez";
            xlWorkSheet.Cells[26, 8] = "Jefe de Control de Calidad";
            Excel.Range aRange = xlWorkSheet.get_Range("A11", "Z23");
            aRange.Rows.AutoFit();
            xlApp.DisplayAlerts = false;
            xlWorkBook.Save(); 
            xlApp.Dialogs[Excel.XlBuiltInDialog.xlDialogPrintPreview].Show();
            //xlWorkBook.PrintPreview();
            //xlWorkBook.PrintPreview(true); 

            //Cerramos la aplicación
            xlWorkBook.Close(false, misValue, misValue);
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            enImpresion = false; 

            
        }

        private void imprimePreviewDeCSharp()
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintDocument printDocument1 = new PrintDocument();
            
            printDocument1.PrintPage += new PrintPageEventHandler(OnPrintDocument);
            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.Document.DocumentName = pathsDictionary["plantillaHallazgos"];
            printPreviewDialog1.ShowDialog();
            try
            {
                printDocument1.Print();
            }
            catch
            {
                MessageBox.Show("Yazıcı çıktısı alınamıyor...");
            }
            finally
            {
                printDocument1.Dispose();
            }
        }

private  void OnPrintDocument(object sender, PrintPageEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(pathPlantillaReporte, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, false, Microsoft.Office.Interop.Excel.XlCorruptLoad.xlNormalLoad);
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(pathsDictionary["plantillaHallazgos"]);
            Microsoft.Office.Interop.Excel.Sheets sheets = xlWorkBook.Worksheets;
            Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlApp.ActiveSheet;
            xlApp.Visible = true;
            object misValue = System.Reflection.Missing.Value;

    
            xlApp.Sheets.PrintPreview(true);
            xlApp.Sheets._PrintOut(1, true, 1, false, true, true, false);//How can work this??
            
            
        }

        private void buttonBuscarDatos_Click(object sender, EventArgs e)
        {

            obtieneDatosDeProducto(); 

            
            
        }

        private bool obtieneDatosDeProducto()
        {
            if ((textBoxClave.Text == "") || (textBoxClave.Text == null))
            {
                MessageBox.Show("Introduce una clave de producto");
                return false;
            }

            try
            {

                

                System.Data.DataTable foundRowsTable = new System.Data.DataTable();
                DataRow[] foundRows;

                foundRowsTable = new System.Data.DataTable();
                foundRowsTable = tablaEspecificaciones.Clone();

                foundRows = tablaEspecificaciones.Select("clave like " + "'" + textBoxClave.Text + "' AND clave not like '%OBSOLETO%'");
                foreach (DataRow row in foundRows)
                {
                    foundRowsTable.ImportRow(row);
                }
                if (foundRowsTable.Rows.Count == 1)
                {
                    textBoxClave.Text = foundRowsTable.Rows[0]["clave"].ToString();
                    textBoxCliente.Text = foundRowsTable.Rows[0]["cliente"].ToString();
                    textBoxCalibre.Text= foundRowsTable.Rows[0]["calibre"].ToString();
                    textBoxMaterial.Text= foundRowsTable.Rows[0]["material"].ToString();
                    textBoxColor.Text = foundRowsTable.Rows[0]["color"].ToString();
                    textBoxPerfil.Text= foundRowsTable.Rows[0]["perfil"].ToString();
                    textBoxCorte.Text= foundRowsTable.Rows[0]["corte"].ToString();
                    return true; 
                }
                else
                {
                    MessageBox.Show("Clave no encontrada"); 
                    return false; 
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false; 
            }
        }

        private void checkBoxCausaDesconocida_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCausaDesconocida.Checked == true)
            {
                richTextBoxCausa.Text = "Causa desconocida";
                richTextBoxCausa.Enabled = false; 
            }
            if (checkBoxCausaDesconocida.Checked == false)
            {
                richTextBoxCausa.Text = "";
                richTextBoxCausa.Enabled = true;
            }
        }

        private void formCapturaDeDatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (enImpresion)
            {
                MessageBox.Show("No puedes cerrar la aplicación mientras se esta imprimiendo");
                return; 
            }
        }
        public class empleado
        {
            public string nombre;
            public string puesto;
        }

        private void formCapturaDeDatos_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
            e.Cancel = true;
            limpiarFormulario(); 
            this.Hide(); 
            
        }

        private void limpiarFormulario()
        {
            registroHistorial = new classHistorial(); 
            comboBoxTurno.SelectedItem = null;
            comboBoxInspectorDeCalidadEnTurno.SelectedItem = null;
            comboBoxOperadorEnTurno.SelectedItem = null;
            comboBoxSupervisorEnTurno.SelectedItem = null;
            comboBoxUnidadesFinal.SelectedItem = null;
            comboBoxIdentificadoPor.Text = "";
            comboBoxAyudanteEnTurno.Text = "";
            comboBoxResponsables.Text = "";
            textBoxCantidadFinal.Text = "";
            richTextBoxInspeccionesRealizadas.Text = "";
            comboBoxDisposicion.SelectedItem = null; 
            

            
            comboBoxEnterado.SelectedItem = null;
            textBoxCantidadDeLotes.Text = "";
            arregloLotes = null;
            textBoxPrefijo.Text = "";
            comboBoxResponsables.SelectedItem = null;
            textBoxPedido.Text = "PMM "; 
            textBoxCantidadInicial.Text = "";
            comboBoxDisposicion.Text = "";
            comboBoxUnidadesInicial.SelectedItem = null;
            textBoxClave.Text = "";
            textBoxCliente.Text = "";
            textBoxCalibre.Text = "";
            textBoxMaterial.Text = "";
            textBoxColor.Text = "";
            textBoxPerfil.Text = "";
            textBoxCorte.Text = "";
            checkBoxCausaDesconocida.Checked = false;
            richTextBoxObservaciones.Text = "";
            richTextBoxCausa.Text = "";
            richTextBoxDescripcion.Text = "";
            comboBoxResponsables.SelectedItem = null; 




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("El indice es: " + comboBoxEnterado.SelectedIndex); 
        }

        private void formCapturaDeDatos_Click(object sender, EventArgs e)
        {
            dateTimePickerFecha.Focus(); 
            //MessageBox.Show("Me hiciste click"); 
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_MouseCaptureChanged(object sender, EventArgs e)
        {
            dateTimePickerFecha.Focus(); 
        }

        private void groupBox3_MouseCaptureChanged(object sender, EventArgs e)
        {
            dateTimePickerFecha.Focus(); 
        }

        private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            dateTimePickerFecha.Focus(); 
        }

        private void textBoxClave_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                obtieneDatosDeProducto(); 

                
                
            }
        }

        
    }
}
