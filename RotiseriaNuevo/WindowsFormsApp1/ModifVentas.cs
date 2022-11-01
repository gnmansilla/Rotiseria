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
    public partial class ModifVentas : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        Ventas ventamodificado = new Ventas();
        int venta;
        public ModifVentas()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        { 
            
            
                venta = int.Parse(textBoxIdPedido.Text);

                ventamodificado.IdPedido = int.Parse(textBoxIdPedido.Text);
                ventamodificado.IdCliente = int.Parse(textBoxIdCliente.Text);
                ventamodificado.Tipo = textBoxTipo.Text;
                ventamodificado.HorarioEstimado = textBoxHorarioEstimado.Text;
                ventamodificado.CostoFinal = int.Parse(textBoxCostoFinal.Text);
                ventamodificado.IdVentas = int.Parse(textBoxIdVentas.Text);
                ventamodificado.Fecha = textBoxFecha.Text;

                principal = new ClasePrincipal();
                principal.Rellenarlistas();
                principal.ModificarVentas(ventamodificado, venta);

                this.Close();
                PantVentas NuevaPantalla = new PantVentas();
                NuevaPantalla.Show();
            
            
        }


        private void button3_Click(object sender, EventArgs e)
            {
            this.Close();
        }
    }
}
