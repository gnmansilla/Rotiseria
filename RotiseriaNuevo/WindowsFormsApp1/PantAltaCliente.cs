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
    public partial class PantAltaCliente : Form
    {
        Cliente nuevo = new Cliente();
        ClasePrincipal principal = new ClasePrincipal();
        public PantAltaCliente()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PantAltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevo = new Cliente();
            nuevo.Telefono = textBoxTELEFONO.Text;
            nuevo.Nombre = textBoxnombre.Text;
            nuevo.Dni = int.Parse(textBoxDNI.Text);
            nuevo.Direccion = textBoxDIRECCION.Text;
            nuevo.IdCliente = int.Parse(textBoxIDCLIENTE.Text);

            principal = new ClasePrincipal();
            principal.Rellenarlistas();
            principal.AltaCliente(nuevo);

            Hide();
            PantCliente nuevaPantalla = new PantCliente();
            nuevaPantalla.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
