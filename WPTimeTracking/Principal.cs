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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrimos la ventana de proyectos
            Proyectos proyectos = new Proyectos();
            proyectos.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abrimos la ventana de tiempos

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Abrimos la ventana de tareas
            Tareas tareas = new Tareas();
            tareas.Visible = true;
            this.Close();
        }
    }
}
