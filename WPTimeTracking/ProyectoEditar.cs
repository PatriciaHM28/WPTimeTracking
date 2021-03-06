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
            //Boton que nos permite hacer modificaciones de datos en la tabla

            //CONEXION BD
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=PCPATRICIA;Initial Catalog=WPTTimeTracking;Integrated Security=True");
            con.Open();

            //CREACION Y EJECUCIÓN DE CONSULTA
            String s_titulo = lb_titulo.Text;
            String st_update = "update proyectos set titulo=@titulo, descripcion=@descripcion, observaciones=@observaciones where titulo='"+ s_titulo + "'";
            SqlCommand cmd = new SqlCommand(st_update, con);
            cmd.Parameters.AddWithValue("@titulo", tb_titulo.Text);
            cmd.Parameters.AddWithValue("@descripcion", tb_descrip.Text);
            cmd.Parameters.AddWithValue("@observaciones", tb_observaciones.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Proyecto editado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //CAMBIAR DE PANTALLA
            Proyectos proyectos = new Proyectos();
            proyectos.Visible = true;
            this.Close();
        }

        private void lb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Situamos la información de la base de datos en sus campos correspondientes.

            //CONEXION BD
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=PCPATRICIA;Initial Catalog=WPTTimeTracking;Integrated Security=True");
            con.Open();

            //CONSULTA SQL
            SqlDataReader dr;
            String s_titulo = lb_titulo.Text;
            String st_selectTitulo = "select * from proyectos where titulo = '" + s_titulo + "'";
            SqlCommand cmd = new SqlCommand(st_selectTitulo, con);
            cmd.Connection = con;
            dr = cmd.ExecuteReader();

            //COLOCAMOS LA INFORMACIÓN EN LOS TEXBOX
            if (dr.Read())
            {
                tb_titulo.Text = dr["titulo"].ToString();
                tb_descrip.Text = dr["descripcion"].ToString();
                tb_observaciones.Text = dr["observaciones"].ToString();
            }
        }
    }
}
