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
    public partial class PantPedidos : Form
    {
        public PantPedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantAltPedidos nuevaventana = new PantAltPedidos();
            nuevaventana.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PantPedidos_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciapersistencia = new Persistenciadedatos();
            instanciapersistencia.InicializarArchivos();
            ClasePrincipal instanciaclasePrincipal = new ClasePrincipal();
            instanciaclasePrincipal.Rellenarlistas();
            dataGridView1.DataSource = instanciaclasePrincipal.ValidarPedido();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BajaPedidos nuevaventana = new BajaPedidos();
            nuevaventana.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifPedidos nuevaventana = new ModifPedidos();
            nuevaventana.Show();
            this.Close();
        }
    }
}
