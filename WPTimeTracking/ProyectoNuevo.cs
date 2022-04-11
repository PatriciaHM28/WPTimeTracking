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
            Proyectos proyectos = new Proyectos();
            proyectos.Visible = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AÑADIR DATOS
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=PCPATRICIA;Initial Catalog=WPTTimeTracking;Integrated Security=True");
            con.Open();

            String st_insert = "insert into proyectos(titulo, descripcion, observaciones) values (@titulo, @descripcion, @observaciones)";
            SqlCommand cmd = new SqlCommand(st_insert, con);
            cmd.Parameters.AddWithValue("@titulo", tb_titulo.Text);
            cmd.Parameters.AddWithValue("@descripcion", tb_descrip.Text);
            cmd.Parameters.AddWithValue("@observaciones", tb_observaciones.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Proyecto creado", "Confirmación", MessageBoxButtons.OK,MessageBoxIcon.Information);

            tb_titulo.Text = "";
            tb_descrip.Text = "";
            tb_observaciones.Text = "";

            Proyectos proyectos = new Proyectos();
            proyectos.Visible = true;
            this.Hide();
        }
    }
}
