using System;
using Logica;
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
    public partial class BajaCliente : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        int cliente;
        public BajaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente = int.Parse(textBoxIdCliente.Text);
            principal.BajaCliente(cliente);

            PantCliente NuevaVentana = new PantCliente();
            NuevaVentana.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxIdCliente_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
