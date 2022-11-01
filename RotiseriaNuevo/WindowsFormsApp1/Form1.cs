using Logica;
using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciaPersistenciaDeDatos = new Persistenciadedatos();
            instanciaPersistenciaDeDatos.InicializarArchivos();
            ClasePrincipal instanciaClasePrincipal = new ClasePrincipal();
            instanciaClasePrincipal.Rellenarlistas();


        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantMenPrincipal nuevaPantalla = new PantMenPrincipal();
            nuevaPantalla.Show();

        }
    }
}
