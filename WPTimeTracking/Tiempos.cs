using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPTimeTracking
{
    public partial class Tiempos : Form
    {
        public Tiempos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tiempos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wPTTimeTrackingDataSet.tiempos' Puede moverla o quitarla según sea necesario.
            this.tiemposTableAdapter.Fill(this.wPTTimeTrackingDataSet.tiempos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
            panel1.Visible=true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Buscamos el elemento de la tabla con el id indicado en el textBox
            string s_buscar = textBox1.Text;
            int rowIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(s_buscar))
                    {
                        rowIndex = row.Index;
                        dataGridView1.ClearSelection();
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                        dataGridView1.Focus();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay ningún tiempo con ese id.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiempoIniciar tiempoIniciar = new TiempoIniciar();
            tiempoIniciar.Visible = true;
            this.Close();
        }
    }
}
