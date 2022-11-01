using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Logica
{
    public class Persistenciadedatos
    {
        readonly string RutaListaCliente = @"C:\repo\go\src\clases\RotiseriaNuevo\ListaCliente.txt";
        readonly string RutaListaAlimentos = @"C:\repo\go\src\clases\RotiseriaNuevo\ListaAlimentos.txt";
        readonly string RutaListaCajero = @"C:\repo\go\src\clases\RotiseriaNuevo\ListaCajero.txt";
        readonly string RutaListaCocinero = @"C:\repo\go\src\clases\RotiseriaNuevo\ListaCocinero.txt";
        readonly string RutaListaDelivery = @"C:\repo\go\src\clases\RotiseriaNuevo\ListaDelivery.txt";
        readonly string RutaListaEncargado = @"C:\repo\go\src\clases\RotiseriaNuevo\ListaEncargado.txt";
        readonly string RutaListaProveedores = @"C:\repo\go\src\clases\RotiseriaNuevo\ListaProveedores.txt";
        readonly string RutaListaPedidos = @"C:\repo\go\src\clases\RotiseriaNuevo\ListaPedidos.txt";
        readonly string RutaListaVentas = @"C:\repo\go\src\clases\RotiseriaNuevo\ListaVentas.txt";

        public void InicializarArchivos()
        {
            if (!File.Exists(RutaListaCliente))
            {
                File.Create(RutaListaCliente).Close();
            }

            if (!File.Exists(RutaListaAlimentos))
            {
                File.Create(RutaListaAlimentos).Close();
            }

            if (!File.Exists(RutaListaCajero))
            {
                File.Create(RutaListaCajero).Close();
            }

            if (!File.Exists(RutaListaCocinero))

            {
                File.Create(RutaListaCocinero).Close();
            }

            if (!File.Exists(RutaListaDelivery))

            {
                File.Create(RutaListaDelivery).Close();
            }

            if (!File.Exists(RutaListaEncargado))
            {
                File.Create(RutaListaEncargado).Close();
            }

            if (!File.Exists(RutaListaProveedores))
            {
                File.Create(RutaListaProveedores).Close();
            }

            if (!File.Exists(RutaListaPedidos))
            {
                File.Create(RutaListaPedidos).Close();
            }

            if (!File.Exists(RutaListaVentas))
            {
                File.Create(RutaListaVentas).Close();
            }
        }


        public List<Cliente> LeerArchivoCliente()
        {
            string locationFile = RutaListaCliente;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Cliente> ListaCliente = JsonConvert.DeserializeObject<List<Cliente>>(content);
                return ListaCliente;
            }
        }

        public List<Alimento> LeerArchivoAlimentos()
        {
            string locationFile = RutaListaAlimentos;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Alimento> ListaAlimentos = JsonConvert.DeserializeObject<List<Alimento>>(content);
                return ListaAlimentos;
            }
        }

        public List<Cajero> LeerArchivoCajero()
        {
            string locationFile = RutaListaCajero;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Cajero> ListaCajero = JsonConvert.DeserializeObject<List<Cajero>>(content);
                return ListaCajero;
            }
        }

        public List<Cocinero> LeerArchivoCocinero()
        {
            string locationFile = RutaListaCocinero;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Cocinero> ListaCocinero = JsonConvert.DeserializeObject<List<Cocinero>>(content);
                return ListaCocinero;
            }
        }

        public List<Delivery> LeerArchivoDelivery()
        {
            string locationFile = RutaListaDelivery;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Delivery> ListaDelivery = JsonConvert.DeserializeObject<List<Delivery>>(content);
                return ListaDelivery;
            }
        }

        public List<Encargado> LeerArchivoEncargado()
        {
            string locationFile = RutaListaEncargado;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Encargado> ListaEncargado = JsonConvert.DeserializeObject<List<Encargado>>(content);
                return ListaEncargado;
            }
        }

        public List<Pedido> LeerArchivoPedido()
        {
            string locationFile = RutaListaPedidos;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Pedido> ListaPedido = JsonConvert.DeserializeObject<List<Pedido>>(content);
                return ListaPedido;
            }
        }

        public List<Proveedores> LeerArchivoProveedores()
        {
            string locationFile = RutaListaProveedores;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Proveedores> ListaProveedores = JsonConvert.DeserializeObject<List<Proveedores>>(content);
                return ListaProveedores;
            }
        }

        public List<Ventas> LeerArchivoVentas()
        {
            string locationFile = RutaListaVentas;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Ventas> ListaVentas = JsonConvert.DeserializeObject<List<Ventas>>(content);
                return ListaVentas;
            }
        }

        public void GuardarArchivoCliente(List<Cliente> ListaCliente)
        {
            string locationFile = RutaListaCliente;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaCliente);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoAlimento(List<Alimento> ListaAlimento)
        {
            string locationFile = RutaListaAlimentos;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaAlimento);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoCajero(List<Cajero> ListaCajero)
        {
            string locationFile = RutaListaCajero;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaCajero);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoCocinero(List<Cocinero> ListaCocinero)
        {
            string locationFile = RutaListaCocinero;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaCocinero);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoDelivery(List<Delivery> ListaDelivery)
        {
            string locationFile = RutaListaDelivery;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaDelivery);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoEncargado(List<Encargado> ListaEncargado)
        {
            string locationFile = RutaListaEncargado;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaEncargado);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoProveedores(List<Proveedores> ListaProveedores)
        {
            string locationFile = RutaListaProveedores;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaProveedores);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoVentas(List<Ventas> ListaVentas)
        {
            string locationFile = RutaListaVentas;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaVentas);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoPedidos(List<Pedido> ListaPedidos)
        {
            string locationFile = RutaListaPedidos;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaPedidos);
                writer.Write(jsonContent);
            }

        }
    }
}

















        









        




        



        
















        



    

    
    
       
    

    



