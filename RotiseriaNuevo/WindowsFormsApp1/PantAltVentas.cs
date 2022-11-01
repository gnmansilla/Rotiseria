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
    public partial class PantAltVentas : Form
    {
        Ventas nuevo = new Ventas();
        ClasePrincipal principal = new ClasePrincipal();
        public PantAltVentas()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            nuevo = new Ventas();
            nuevo.IdVentas = int.Parse(textBoxIdVentas.Text);
            nuevo.Tipo = textBoxTipo.Text;
            nuevo.HorarioEstimado = textBoxHorarioEstimado.Text;
            nuevo.CostoFinal = int.Parse(textBoxCostoFinal.Text);
            nuevo.IdPedido = int.Parse(textBoxIdPedido.Text);
            nuevo.Fecha = textBoxFecha.Text;
            nuevo.IdCliente = int.Parse(textBoxIdCliente.Text);


            principal = new ClasePrincipal();
            principal.Rellenarlistas();
            principal.AltaVentas(nuevo);

            Hide();
            PantVentas Nuevapantalla = new PantVentas();
            Nuevapantalla.Show();
        }

        private void textBoxHorarioEstimado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
