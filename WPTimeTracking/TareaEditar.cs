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
    public partial class TareaEditar : Form
    {
        public TareaEditar()
        {
            InitializeComponent();
        }

        private void TareaEditar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wPTTimeTrackingDataSet.proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter.Fill(this.wPTTimeTrackingDataSet.proyectos);
            // TODO: esta línea de código carga datos en la tabla 'wPTTimeTrackingDataSet.tecnicos' Puede moverla o quitarla según sea necesario.
            this.tecnicosTableAdapter.Fill(this.wPTTimeTrackingDataSet.tecnicos);
            // TODO: esta línea de código carga datos en la tabla 'wPTTimeTrackingDataSet.t_estados' Puede moverla o quitarla según sea necesario.
            this.t_estadosTableAdapter.Fill(this.wPTTimeTrackingDataSet.t_estados);
            // TODO: esta línea de código carga datos en la tabla 'wPTTimeTrackingDataSet.tareas' Puede moverla o quitarla según sea necesario.
            this.tareasTableAdapter.Fill(this.wPTTimeTrackingDataSet.tareas);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
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
            int id = Int32.Parse(lb_id.Text);
            String st_update = "update tareas set titulo=@titulo, descripcion=@descripcion, observaciones=@observaciones, id_estado=@id_estado, id_tecnico=@id_tecnico, id_proyecto=@id_proyecto where id='" + id + "'";
            SqlCommand cmd = new SqlCommand(st_update, con);
            cmd.Parameters.AddWithValue("@titulo", tb_titulo.Text);
            cmd.Parameters.AddWithValue("@descripcion", tb_descrip.Text);
            cmd.Parameters.AddWithValue("@observaciones", tb_observaciones.Text);
            cmd.Parameters.AddWithValue("@id_estado", lb_estado.Text);
            cmd.Parameters.AddWithValue("@id_tecnico", lb_tecnico.Text);
            cmd.Parameters.AddWithValue("@id_proyecto", lb_proyecto.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Tarea editada", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //CAMBIAR DE PANTALLA
            Proyectos proyectos = new Proyectos();
            proyectos.Visible = true;
            this.Close();
        }

        private void lb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CONEXION BD
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=PCPATRICIA;Initial Catalog=WPTTimeTracking;Integrated Security=True");
            con.Open();


            //CONSULTA SQL
            SqlDataReader dr;
            int id = Int32.Parse(lb_id.Text);
            String st_selectTitulo = "select * from tareas where id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(st_selectTitulo, con);
            cmd.Connection = con;
            dr = cmd.ExecuteReader();

            //COLOCAMOS LA INFORMACIÓN EN LOS TEXBOX
            if (dr.Read())
            {
                tb_titulo.Text = dr["titulo"].ToString();
                tb_descrip.Text = dr["descripcion"].ToString();
                tb_observaciones.Text = dr["observaciones"].ToString();
                lb_estado.Text = dr["id_estado"].ToString();
                lb_tecnico.Text = dr["id_tecnico"].ToString();
                lb_proyecto.Text = dr["id_proyecto"].ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tareas tareas = new Tareas();
            tareas.Visible = true;
            this.Close();
        }
    }
}
