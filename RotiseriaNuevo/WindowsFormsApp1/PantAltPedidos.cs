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
    public partial class PantAltPedidos : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        Pedido nuevo = new Pedido();
        public PantAltPedidos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevo = new Pedido();
            nuevo.IdPedido = int.Parse(textBoxIdPedido.Text);
            nuevo.Tipo = textBoxTipo.Text;
            nuevo.IdCliente = int.Parse(textBoxIdCliente.Text);
            nuevo.HorarioEstimado = textBoxHorarioEstimado.Text;
            nuevo.CostoFinal = int.Parse(textBoxCostoFinal.Text);

            principal = new ClasePrincipal();
            principal.Rellenarlistas();
            principal.AltaPedido(nuevo);

            Hide();
            PantPedidos Nuevapantalla = new PantPedidos();
            Nuevapantalla.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
