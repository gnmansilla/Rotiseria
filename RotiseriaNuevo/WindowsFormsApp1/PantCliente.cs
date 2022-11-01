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
    public partial class PantCliente : Form
    {
        public PantCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PantCliente_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciaPersistencia = new Persistenciadedatos();
            instanciaPersistencia.InicializarArchivos();
            ClasePrincipal InstanciaClasePrincipal = new ClasePrincipal();
            InstanciaClasePrincipal.Rellenarlistas();

            dataGridView1.DataSource = InstanciaClasePrincipal.ValidarCliente();  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantAltaCliente nuevaventana = new PantAltaCliente();
            nuevaventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BajaCliente Nuevaventana = new BajaCliente();
            Nuevaventana.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifCliente nuevaventana = new ModifCliente();
            nuevaventana.Show();
            this.Close();
        }
    }
}
