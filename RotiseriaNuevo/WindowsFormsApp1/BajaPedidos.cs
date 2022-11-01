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
    
    public partial class BajaPedidos : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        int Pedido;

        public BajaPedidos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pedido = int.Parse(textBox1.Text);
            principal.BajaPedido(Pedido);

            PantPedidos NuevaVentana = new PantPedidos();
            NuevaVentana.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
