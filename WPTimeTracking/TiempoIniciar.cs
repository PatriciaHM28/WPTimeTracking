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
    public partial class TiempoIniciar : Form
    {
        public TiempoIniciar()
        {
            InitializeComponent();
        }

        private void TiempoIniciar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'wPTTimeTrackingDataSet.tareas' Puede moverla o quitarla según sea necesario.
            this.tareasTableAdapter.Fill(this.wPTTimeTrackingDataSet.tareas);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tiempos tiempos = new Tiempos();
            tiempos.Visible = true;
            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            tb_timer.Text = timer1.ToString() + "00: 00: 00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
