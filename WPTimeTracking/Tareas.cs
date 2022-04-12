using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPTimeTracking
{
    public partial class Tareas : Form
    {
        public Tareas()
        {
            InitializeComponent();
        }

        private void Tareas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wPTTimeTrackingDataSet.tareas' Puede moverla o quitarla según sea necesario.
            this.tareasTableAdapter.Fill(this.wPTTimeTrackingDataSet.tareas);

        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            TareaNueva tareaNueva = new TareaNueva();
            tareaNueva.Visible = true;
            this.Close();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            //Eliminamos la fila seleccionada en el dataGrid

            //CONEXION BD
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=PCPATRICIA;Initial Catalog=WPTTimeTracking;Integrated Security=True");
            con.Open();

            //CONSULTA SQL
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            String st_delete = "delete from tareas where id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(st_delete, con);
            cmd.CommandText = st_delete;

            //MENSAJE DE ADVERTENCIA
            if (MessageBox.Show("¿Estas seguro que quieres eliminar la tarea con id " + id + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }

        private void button2_Click(object sender, EventArgs e)
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
                MessageBox.Show("No hay ningúna tarea con ese id.");
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            TareaEditar tareaEditar = new TareaEditar();
            tareaEditar.Visible = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Visible = true;
            this.Close();
        }
    }
}
