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
    public partial class Proyectos : Form
    {
        public Proyectos()
        {
            InitializeComponent();
        }

        private void Proyectos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wPTTimeTrackingDataSet.proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter.Fill(this.wPTTimeTrackingDataSet.proyectos);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrimos la ventana para crear un Nuevo proyecto
            ProyectoNuevo proyectoNuevo = new ProyectoNuevo();
            proyectoNuevo.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abrimos la ventana para editar un proyecto
            ProyectoEditar proyectoEditar = new ProyectoEditar();
           proyectoEditar.Visible = true;
           this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Eliminamos la fila seleccionada en el dataGrid

            //CONEXION BD
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=PCPATRICIA;Initial Catalog=WPTTimeTracking;Integrated Security=True");
            con.Open();

            //CONSULTA SQL
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            String st_delete = "delete from proyectos where id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(st_delete, con);
            cmd.CommandText = st_delete;

            //MENSAJE DE ADVERTENCIA
            if (MessageBox.Show("¿Estas seguro que quieres eliminar el proyecto con id "+id+"?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();

                //Recarga los datos de la tabla
                this.proyectosTableAdapter.Fill(this.wPTTimeTrackingDataSet.proyectos);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("No hay ningún proyecto con ese id.");
            }
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Visible = true;
            this.Close();
        }
    }
}
