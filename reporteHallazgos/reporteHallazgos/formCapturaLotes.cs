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
    public partial class formCapturaLotes : Form
    {
        public string[] arregloDeLotes;
        public int cantidadLotesInicial;
        public string cadena;
        public string prefijo; 
        public formCapturaLotes(int cantidadLotes, string prefijo)
        {
            cantidadLotesInicial = cantidadLotes;
            this.prefijo = prefijo; 
            InitializeComponent();
        }

        private void formCapturaLotes_Load(object sender, EventArgs e)
        {
            
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            dataGridView1.Columns.Add("lote", "Lote");
            for (int x = 0; x < cantidadLotesInicial; x++)
            {
                dataGridView1.Rows.Add(prefijo);
            }                
            autosizeGrid(); 
        }

        private void autosizeGrid()
        {

            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cadena = ""; 
                arregloDeLotes = new string[dataGridView1.Rows.Count];
                
                cadena = "Los lotes son : \n";
                for (int x = 0; x < arregloDeLotes.Length; x++)
                {
                    if ((dataGridView1.Rows[x].Cells[0].Value ==null))
                    {
                        MessageBox.Show("Por favor no dejes celdas en blanco"); 
                        return; 
                    }
                    if ((dataGridView1.Rows[x].Cells[0].Value.ToString() == ""))
                    {
                        MessageBox.Show("Por favor no dejes lotes en blanco");
                        return;
                        }
                    arregloDeLotes[x] = dataGridView1.Rows[x].Cells[0].Value.ToString();
                    
                    cadena += arregloDeLotes[x] + "\n";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return; 
            }
            this.Hide();
            this.Dispose(); 
            
            //MessageBox.Show(cadena); 
            //MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString()); 
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            //MessageBox.Show("Cell end edit" + e.RowIndex); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return; 
            }
            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
            dataGridView1.BeginEdit(false); 
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                for (int x = e.RowIndex; x < dataGridView1.Rows.Count; x++)
                {
                    dataGridView1.Rows[x].Cells[0].Value = dataGridView1.Rows[x-1].Cells[0].Value.ToString();
                }

            }

            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
            dataGridView1.BeginEdit(false); 

        }

    }
}
