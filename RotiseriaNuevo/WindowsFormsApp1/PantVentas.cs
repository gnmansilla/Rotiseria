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
    public partial class PantVentas : Form
    {
        public PantVentas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BajaVentas nuevaventana = new BajaVentas();
            nuevaventana.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantAltVentas nuevaventana = new PantAltVentas();
            nuevaventana.Show();
        }

        private void PantVentas_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciapersistencia = new Persistenciadedatos();
            instanciapersistencia.InicializarArchivos();
            ClasePrincipal instanciaclasePrincipal = new ClasePrincipal();
            instanciaclasePrincipal.Rellenarlistas();
            dataGridView1.DataSource = instanciaclasePrincipal.ValidarVentas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifVentas nuevaventana = new ModifVentas();
            nuevaventana.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
