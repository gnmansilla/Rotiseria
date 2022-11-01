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
    public partial class ModifPedidos : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        Pedido pedidomodificado = new Pedido();
        int pedido;
        public ModifPedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxIdPedido.Text.Length > 1 && textBoxIdCliente.Text.Length >= 1 && textBoxTipo.Text.Length > 4 && textBoxHorarioEstimado.Text.Length > 1 && textBoxCostoFinal.Text.Length > 2)
            {
                pedido = int.Parse(textBoxIdPedido.Text);

                pedidomodificado.IdPedido = int.Parse(textBoxIdPedido.Text);
                pedidomodificado.IdCliente = int.Parse(textBoxIdCliente.Text);
                pedidomodificado.Tipo = textBoxTipo.Text;
                pedidomodificado.HorarioEstimado = textBoxHorarioEstimado.Text;
                pedidomodificado.CostoFinal = int.Parse(textBoxCostoFinal.Text);

                principal = new ClasePrincipal();
                principal.Rellenarlistas();
                principal.ModificarPedidos(pedidomodificado, pedido);

                this.Close();
                PantPedidos NuevaPantalla = new PantPedidos();
                NuevaPantalla.Show();
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR LOS CAMPOS CORRECTAMENTE");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
