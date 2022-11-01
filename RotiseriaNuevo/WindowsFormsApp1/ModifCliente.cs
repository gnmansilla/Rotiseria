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
    public partial class ModifCliente : Form

    {
        ClasePrincipal principal = new ClasePrincipal();
        Cliente clientemodificado = new Cliente();
        int cliente;
        public ModifCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxnombre.Text.Length > 5 && textBoxIDCLIENTE.Text.Length >= 1 && textBoxDIRECCION.Text.Length > 5 && textBoxTELEFONO.Text.Length > 5 && textBoxDNI.Text.Length > 6)
            {
                cliente = int.Parse(textBoxIDCLIENTE.Text);

                clientemodificado.Telefono = textBoxTELEFONO.Text;
                clientemodificado.IdCliente = int.Parse(textBoxIDCLIENTE.Text);
                clientemodificado.Dni = int.Parse(textBoxDNI.Text);
                clientemodificado.Nombre = textBoxnombre.Text;
                clientemodificado.Direccion = textBoxDIRECCION.Text;

                principal = new ClasePrincipal();
                principal.Rellenarlistas();
                principal.ModificarCliente(clientemodificado, cliente);

                this.Close();
                PantCliente NuevaPantalla = new PantCliente();
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

