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
    public partial class TareaNueva : Form
    {
        public TareaNueva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CONEXION BD
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=PCPATRICIA;Initial Catalog=WPTTimeTracking;Integrated Security=True");
            con.Open();

            //Buscamos el elemento de la tabla con el id indicado en el textBox
            String titulo = tb_titulo.Text;
            String st_selectTitulo = "select * from tareas where titulo='" + titulo + "'";
            SqlCommand cmd2 = new SqlCommand(st_selectTitulo, con);
            cmd2.Connection = con;
            SqlDataReader dr = cmd2.ExecuteReader();
            String titulo2 = "";

            //Si existe algún proyecto con ese nombre aparecerá un aviso de advertencia,
            //de lo contrario creará el proyecto sin problemas
            if (dr.Read())
            {
                titulo2 += dr["titulo"].ToString();
            }

            if (titulo2 == tb_titulo.Text)
            {
                MessageBox.Show("Ya existe un proyecto con este nombre, porfavor cambialo", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Cierro el DataReader
                dr.Close();
            }
            else
            {
                //Cierro el DataReader
                dr.Close();

                //Inserta datos en la BD
                String st_insert = "insert into tareas(titulo, descripcion, observaciones, id_estado, id_proyecto) values (@titulo, @descripcion, @observaciones, @id_estado, @id_proyecto)";
                SqlCommand cmd = new SqlCommand(st_insert, con);
                cmd.Parameters.AddWithValue("@titulo", tb_titulo.Text);
                cmd.Parameters.AddWithValue("@descripcion", tb_descrip.Text);
                cmd.Parameters.AddWithValue("@observaciones", tb_observaciones.Text);
                cmd.Parameters.AddWithValue("@id_estado", lb_estado.Text);
                cmd.Parameters.AddWithValue("@id_proyecto", lb_proyecto.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Tarea creada", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_titulo.Text = "";
                tb_descrip.Text = "";
                tb_observaciones.Text = "";
            }

            Tareas tareas = new Tareas();
            tareas.Visible = true;
            this.Close();
        }

        private void TareaNueva_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wPTTimeTrackingDataSet.t_estados' Puede moverla o quitarla según sea necesario.
            this.t_estadosTableAdapter.Fill(this.wPTTimeTrackingDataSet.t_estados);
            // TODO: esta línea de código carga datos en la tabla 'wPTTimeTrackingDataSet.proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter.Fill(this.wPTTimeTrackingDataSet.proyectos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tareas tareas = new Tareas();
            tareas.Visible = true;
            this.Close();
        }
    }
}
