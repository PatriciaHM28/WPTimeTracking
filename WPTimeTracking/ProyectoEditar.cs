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
    public partial class ProyectoEditar : Form
    {
        public ProyectoEditar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proyectos proyectos = new Proyectos();
            proyectos.Visible = true;
            this.Hide();
        }

        private void ProyectoEditar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wPTTimeTrackingDataSet.proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter.Fill(this.wPTTimeTrackingDataSet.proyectos);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tb_observaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_titulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_descrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Proyecto editado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //CAMBIAR DE PANTALLA
            Proyectos proyectos = new Proyectos();
            proyectos.Visible = true;
            this.Hide();
        }

        private void lb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AÑADIR DATOS
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=PCPATRICIA;Initial Catalog=WPTTimeTracking;Integrated Security=True");
            con.Open();

            int id = Int32.Parse(lb_id.Text);
            String st_selectTitulo = "select titulo from proyectos where id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(st_selectTitulo, con);
            String titulo;
            cmd.ExecuteReader();
            //tb_titulo.Text = cmd.;

            con.Close();
        }
    }
}
