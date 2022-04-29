using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WPTimeTracking
{
    public partial class Login : Form
    {
        //DECLARACIONES
        SqlConnection con = Conexion.abrirConexion();
        SqlCommand sql_comand;
        SqlDataReader dr;
        String st_selectTecnico="";
        String st_usuarioDatoTabla = "", st_contrasenaDatoTabla = "";

        public Login()
        {
            InitializeComponent();
            tb_contrasena.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_usuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void tb_contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjBotones1_Click(object sender, EventArgs e)
        {
            //Buscamos el elemento de la tabla con el id indicado en el textBox
            String s_usuarioSql = tb_usuario.Text, s_contrasenaSql = tb_contrasena.Text;
            st_selectTecnico = "select * from tecnicos where usuario='" + s_usuarioSql + "' and password='" + s_contrasenaSql + "'";
            sql_comand = new SqlCommand(st_selectTecnico, con);
            sql_comand.Connection = con;
            dr = sql_comand.ExecuteReader();

            //No pueden dejar los campos vacios
            if (tb_usuario.Text == "") 
            {
                MessageBox.Show("El campo 'usuario' no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dr.Close();
            }
            else
            {
                //Si existe algún tiempo en relación a esa tarea se actualizarán los datos de la tabla,
                //de lo contrario creará el nuevo tiempo
                if (dr.Read())
                {
                    st_usuarioDatoTabla += dr["usuario"].ToString();
                    st_contrasenaDatoTabla += dr["password"].ToString();
                    dr.Close();
                }
                else { dr.Close(); }

                if (st_usuarioDatoTabla == tb_usuario.Text & st_contrasenaDatoTabla == tb_contrasena.Text)
                {
                    //Cierro el DataReader
                    dr.Close();

                    //Abrimos ventana principal de la aplicación
                    Principal principal = new Principal();
                    principal.Visible = true;
                    this.Hide();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
