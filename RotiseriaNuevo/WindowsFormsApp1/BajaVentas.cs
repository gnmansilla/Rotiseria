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
    public partial class BajaVentas : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        int Venta;
        public BajaVentas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venta = int.Parse(textBox1.Text);
            principal.BajaVenta(Venta);

            PantVentas NuevaVentana = new PantVentas();
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
