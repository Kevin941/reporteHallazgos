using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reporteHallazgos
{
    public class classHistorial
    {
        public string pathHistorial = ""; 
        public  string fecha = "";
        public  string turno = "";
        public  string identificadoPor = "";
        public  string enterado = "";
        public  string operadorEnTurno= "";
        public  string supervisorEnTurno= "";
        public  string inspectorDeCalidadEnTurno = "";
        public string ayudanteEnTurno = "";
        public  string catidadLotes = "";
        public  string lotes = "";
        public  string pedido = "";
        public  string responsable = "";
        public  string cantidadInicial = "";
        public  string unidadInicial = "";
        public string cantidadFinal = "";
        public string unidadFinal = "";
        public  string disposicion = "";
        public  string clave = "";
        public  string cliente = "";
        public  string calibre  = "";
        public  string material = "";
        public  string color  = "";
        public string perfil = "";
        public string corte = "";

        public  string descripcion = "";
        public string inspeccionesRealizadas = "";
        public  string probableCausa = "";
        public  string observaciones = "";

        
        private string getStringConnection()
        {
            string[] lines = System.IO.File.ReadAllLines(@"" + System.Windows.Forms.Application.StartupPath + "\\paths.txt");
            this.pathHistorial = lines[9]; 
            

            string stringConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.pathHistorial;
            return stringConnection;
        }

        public void setStringBD(string path)
        {
            this.pathHistorial = path;
            return; 
        }


        
        
         
        public void insertRecord()
        {

            string query = "INSERT INTO [t_historial] (" +
                    "[fecha]," +
                    "[fechaImpresion]," +
                    "[turno]," +
                    "[identificadoPor]," +
                    "[enterado]," +
                    "[operadorEnTurno]," +
                    "[supervisorEnTurno]," +
                    "[inspectorDeCalidadEnTurno]," +
                    "[ayudanteEnTurno]," +                    
                    "[cantidadLotes]," +
                    "[lotes]," +
                    "[pedido]," +
                    "[responsable]," +
                    "[cantidadInicial]," +
                    "[unidadInicial]," +
                    "[cantidadFinal]," +
                    "[unidadFinal]," +
                    "[disposicion]," +
                    "[clave]," +
                    "[cliente]," +
                    "[calibre]," +
                    "[material]," +
                    "[color]," +
                    "[perfil]," +
                    "[corte]," +
                    "[descripcion]," +
                    "[inspeccionesRealizadas]," +            
                    "[probableCausa]," +
                    "[observaciones]) ";
            query += "VALUES(" +
                "@fecha," +
                "@fechaImpresion," +
                "@turno," +
                "@identificadoPor," +
                "@enterado," +
                "@operadorEnTurno," +
                "@supervisorEnTurno," +
                "@inspectorDeCalidadEnTurno," +
                "@ayudanteEnTurno," +
                "@catidadLotes," +
                "@lotes," +
                "@pedido," +
                "@responsable," +
                "@cantidadInicial," +
                "@unidadInicial," +
                "@cantidadFinal," +
                "@unidadFinal," +
                "@disposicion," +
                "@clave," +
                "@cliente," +
                "@calibre," +
                "@material," +
                "@color," +
                "@perfil," +
                "@corte," +
                "@descripcion," +
                "@inspeccionesRealizadas," +                
                "@probableCausa," +
                "@observaciones);";
            OleDbConnection connection = new OleDbConnection(getStringConnection());
            OleDbCommand comando = new OleDbCommand(query, connection);
            DateTime fechaActual = new DateTime();
            fechaActual = DateTime.Now;
            string dia = fechaActual.Day.ToString();
            string mes = fechaActual.Month.ToString();
            string año = fechaActual.Year.ToString();

            if (dia.Length < 2)
            {
                dia = "0" + dia;
            }
            if (mes.Length < 2)
            {
                mes = "0" + mes;
            }
            string fechaConFormato = dia + "/" + mes + "/" + año;
            comando.Parameters.Add("@fecha", OleDbType.VarChar).Value = fecha.Replace("\n", " ").ToString();
            comando.Parameters.Add("@fechaImpresion", OleDbType.VarChar).Value = fechaActual.ToString();
            comando.Parameters.Add("@turno", OleDbType.VarChar).Value = turno.Replace("\n", " ").ToString();
            comando.Parameters.Add("@identificadoPor", OleDbType.VarChar).Value = identificadoPor.Replace("\n", " ").ToString();
            comando.Parameters.Add("@enterado", OleDbType.VarChar).Value = enterado.Replace("\n", " ").ToString();
            comando.Parameters.Add("@operadorEnTurno", OleDbType.VarChar).Value = operadorEnTurno.Replace("\n", " ").ToString();
            comando.Parameters.Add("@supervisorEnTurno", OleDbType.VarChar).Value = supervisorEnTurno.Replace("\n", " ").ToString();
            comando.Parameters.Add("@inspectorDeCalidadEnTurno", OleDbType.VarChar).Value = inspectorDeCalidadEnTurno.Replace("\n", " ").ToString();
            comando.Parameters.Add("@ayudanteEnTurno", OleDbType.VarChar).Value = ayudanteEnTurno.Replace("\n", " ").ToString();            
            comando.Parameters.Add("@catidadLotes", OleDbType.VarChar).Value = catidadLotes.Replace("\n", " ").ToString();
            comando.Parameters.Add("@lotes", OleDbType.VarChar).Value = lotes.Replace("\n", " ").ToString();
            comando.Parameters.Add("@pedido", OleDbType.VarChar).Value = pedido.Replace("\n", " ").ToString();
            comando.Parameters.Add("@responsable", OleDbType.VarChar).Value = responsable.Replace("\n", " ").ToString();
            comando.Parameters.Add("@cantidadInicial", OleDbType.VarChar).Value = cantidadInicial.Replace("\n", " ").ToString();
            comando.Parameters.Add("@unidadInicial", OleDbType.VarChar).Value = unidadInicial.Replace("\n", " ").ToString();
            comando.Parameters.Add("@cantidadFinal", OleDbType.VarChar).Value = cantidadFinal.Replace("\n", " ").ToString();
            comando.Parameters.Add("@unidadFinal", OleDbType.VarChar).Value = unidadFinal.Replace("\n", " ").ToString();
            comando.Parameters.Add("@disposicion", OleDbType.VarChar).Value = disposicion.Replace("\n", " ").ToString();
            comando.Parameters.Add("@clave", OleDbType.VarChar).Value = "'" + clave.Replace("\n", " ").ToString();
            comando.Parameters.Add("@cliente", OleDbType.VarChar).Value = cliente.Replace("\n", " ").ToString();
            comando.Parameters.Add("@calibre", OleDbType.VarChar).Value = calibre.Replace("\n", " ").ToString();
            comando.Parameters.Add("@material", OleDbType.VarChar).Value = material.Replace("\n", " ").ToString();
            comando.Parameters.Add("@color", OleDbType.VarChar).Value = color.Replace("\n", " ").ToString();
            comando.Parameters.Add("@perfil", OleDbType.VarChar).Value = perfil.Replace("\n", " ").ToString();
            comando.Parameters.Add("@corte", OleDbType.VarChar).Value = corte.Replace("\n", " ").ToString();
            comando.Parameters.Add("@descripcion", OleDbType.VarChar).Value = descripcion.Replace("\n", " ").ToString();
            comando.Parameters.Add("@inspeccionesRealizadas", OleDbType.VarChar).Value = inspeccionesRealizadas.Replace("\n", " ").ToString();
            comando.Parameters.Add("@probableCausa", OleDbType.VarChar).Value = probableCausa.Replace("\n", " ").ToString();            
            comando.Parameters.Add("@observaciones", OleDbType.VarChar).Value = observaciones.Replace("\n", " ").ToString();
            

            try
            {
                connection.Open();
                comando.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable selectAll() //Queda pendiente configurarlo para devolver un dataSet
        {
            string query = "Select * FROM t_historial";
            DataTable tablaDeHistorial = new DataTable();
            OleDbConnection connection = new OleDbConnection(getStringConnection());
            try
            {
                connection.Open();
                OleDbCommand comando = new OleDbCommand(query, connection);
                OleDbDataAdapter adaptadorDatos = new OleDbDataAdapter(comando);
                adaptadorDatos.Fill(tablaDeHistorial);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return (tablaDeHistorial);
        }

        public classHistorial()
        {
            // TODO: Complete member initialization
        }

        
    }
}
