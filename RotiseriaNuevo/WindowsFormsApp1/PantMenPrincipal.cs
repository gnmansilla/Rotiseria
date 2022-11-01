using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PantMenPrincipal : Form
    {
        public PantMenPrincipal()
        {
            InitializeComponent();
        }

        private void PantMenPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnminimizar.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnminimizar.Visible = false;
            btnmaximizar.Visible = true;

        }

        private void btnesconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantCliente nuevaventana = new PantCliente();
            nuevaventana.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PantPedidos nuevaventana = new PantPedidos();
            nuevaventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PantVentas nuevaventana = new PantVentas();
            nuevaventana.Show();
        }
    }
}
