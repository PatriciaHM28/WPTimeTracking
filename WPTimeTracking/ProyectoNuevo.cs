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
    public partial class ProyectoNuevo : Form
    {
        public ProyectoNuevo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cancelamos el proceso y volvemos a la pestaña de proyectos
            Proyectos proyectos = new Proyectos();
            proyectos.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CONEXION BD
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=PCPATRICIA;Initial Catalog=WPTTimeTracking;Integrated Security=True");
            con.Open();

            //Buscamos el elemento de la tabla con el id indicado en el textBox
            String titulo = tb_titulo.Text;
            String st_selectTitulo = "select * from proyectos where titulo='"+titulo+"'";
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

                //AÑADIR DATOS
                String st_insert = "insert into proyectos(titulo, descripcion, observaciones) values (@titulo, @descripcion, @observaciones)";
                SqlCommand cmd = new SqlCommand(st_insert, con);
                cmd.Parameters.AddWithValue("@titulo", tb_titulo.Text);
                cmd.Parameters.AddWithValue("@descripcion", tb_descrip.Text);
                cmd.Parameters.AddWithValue("@observaciones", tb_observaciones.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Proyecto creado", "Confirmación", MessageBoxButtons.OK,MessageBoxIcon.Information);

                //Vacio los campos
                tb_titulo.Text = "";
                tb_descrip.Text = "";
                tb_observaciones.Text = "";
            }            

            Proyectos proyectos = new Proyectos();
            proyectos.Visible = true;
            this.Close();
        }
    }
}
