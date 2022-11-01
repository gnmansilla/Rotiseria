using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClasePrincipal
    {
        List<Cliente> ListaCliente = new List<Cliente>();

        public void AltaCliente(Cliente personanueva) //Dar de alta cliente
        {
            ListaCliente = ValidarCliente();
            Cliente nuevo = new Cliente();
            nuevo.Telefono = personanueva.Telefono;
            nuevo.Nombre = personanueva.Nombre;
            nuevo.Dni = personanueva.Dni;
            nuevo.Direccion = personanueva.Direccion;
            nuevo.IdCliente = personanueva.IdCliente;
            ListaCliente.Add(nuevo);
            InstanciaPersistenciaDeDatos.GuardarArchivoCliente(ListaCliente);
            
            
        }
        public void BajaCliente(int idcliente) //Dar de baja cliente
        {
            ListaCliente = ValidarCliente();
            var clienteEliminado = ListaCliente.Find(x => idcliente == x.IdCliente);
            ListaCliente.Remove(clienteEliminado);
            InstanciaPersistenciaDeDatos.GuardarArchivoCliente(ListaCliente);


        }
        public void ModificarCliente(Cliente personaNuevo, int idcliente) //Modificacion cliente
        {
            ListaCliente = ValidarCliente();
            var Clientemodificado = ListaCliente.Find(x => idcliente == x.IdCliente);

            Clientemodificado.Nombre = personaNuevo.Nombre;
            Clientemodificado.Dni = personaNuevo.Dni;
            Clientemodificado.Direccion = personaNuevo.Direccion;
            Clientemodificado.Telefono = personaNuevo.Telefono;
            Clientemodificado.IdCliente = personaNuevo.IdCliente;


            var clienteEliminado = ListaCliente.Find(x => idcliente == x.IdCliente);
            ListaCliente.Remove(clienteEliminado);
            ListaCliente.Add(Clientemodificado);
            InstanciaPersistenciaDeDatos.GuardarArchivoCliente(ListaCliente);

        }
        List<Cajero> ListaCajero = new List<Cajero>();

        public void AltaCajero(Cajero personanueva)  //Dar de alta cajero
        {
            Cajero nuevo = new Cajero();
            nuevo.Telefono = personanueva.Telefono;
            nuevo.Nombre = personanueva.Nombre;
            nuevo.Dni = personanueva.Dni;
            nuevo.Direccion = personanueva.Direccion;
            nuevo.antiguedad = personanueva.antiguedad;
            nuevo.salario = personanueva.salario;
            nuevo.IdCajero = personanueva.IdCajero;
            ListaCajero.Add(nuevo);
            InstanciaPersistenciaDeDatos.GuardarArchivoCajero(ListaCajero);
        }
        public void BajaCajero(int idcajero) //Dar de baja cajero
        {
            var CajeroEliminado = ListaCajero.Find(x => idcajero == x.IdCajero);
            ListaCajero.Remove(CajeroEliminado);
            InstanciaPersistenciaDeDatos.GuardarArchivoCajero(ListaCajero);
        }

        public void ModificarCajero(Cajero personaNuevo, int idcajero) //Modificacion cajero
        {
            var Cajeromodificado = ListaCajero.Find(x => idcajero == x.IdCajero);

            Cajeromodificado.Nombre = personaNuevo.Nombre;
            Cajeromodificado.Dni = personaNuevo.Dni;
            Cajeromodificado.Direccion = personaNuevo.Direccion;
            Cajeromodificado.Telefono = personaNuevo.Telefono;
            Cajeromodificado.IdCajero = personaNuevo.IdCajero;
            Cajeromodificado.antiguedad = personaNuevo.antiguedad;
            Cajeromodificado.salario = personaNuevo.salario;

            var cajeroEliminado = ListaCajero.Find(x => idcajero == x.IdCajero);
            ListaCajero.Remove(cajeroEliminado);
            ListaCajero.Add(Cajeromodificado);
            InstanciaPersistenciaDeDatos.GuardarArchivoCajero(ListaCajero);

        }
        List<Cocinero> ListaCocinero = new List<Cocinero>();

        public void AltaCocinero(Cocinero personanueva)  //Dar de alta cocinero
        {
            Cocinero nuevo = new Cocinero();
            nuevo.Telefono = personanueva.Telefono;
            nuevo.Nombre = personanueva.Nombre;
            nuevo.Dni = personanueva.Dni;
            nuevo.Direccion = personanueva.Direccion;
            nuevo.IdCocinero = personanueva.IdCocinero;
            nuevo.Salario = personanueva.Salario;
            nuevo.IdPedido = personanueva.IdPedido;
            ListaCocinero.Add(nuevo);
            InstanciaPersistenciaDeDatos.GuardarArchivoCocinero(ListaCocinero);
        }
        public void BajaCocinero(int idcocinero) //Dar de baja cocinero
        {
            var CocineroEliminado = ListaCocinero.Find(x => idcocinero == x.IdCocinero);
            ListaCocinero.Remove(CocineroEliminado);
            InstanciaPersistenciaDeDatos.GuardarArchivoCocinero(ListaCocinero);
        }
        public void ModificarCocinero(Cocinero personaNuevo, int idcocinero) //Modificacion cocinero
        {
            var Cocineromodificado = ListaCocinero.Find(x => idcocinero == x.IdCocinero);

            Cocineromodificado.Nombre = personaNuevo.Nombre;
            Cocineromodificado.Dni = personaNuevo.Dni;
            Cocineromodificado.Direccion = personaNuevo.Direccion;
            Cocineromodificado.Telefono = personaNuevo.Telefono;
            Cocineromodificado.IdCocinero = personaNuevo.IdCocinero;
            Cocineromodificado.IdPedido = personaNuevo.IdPedido;
            Cocineromodificado.Salario = personaNuevo.Salario;

            var cocineroEliminado = ListaCocinero.Find(x => idcocinero == x.IdCocinero);
            ListaCocinero.Remove(cocineroEliminado);
            ListaCocinero.Add(Cocineromodificado);
            InstanciaPersistenciaDeDatos.GuardarArchivoCocinero(ListaCocinero);
        }
        
        List<Delivery> ListaDelivery = new List<Delivery>();

        public void AltaDelivery(Delivery personanueva)  //Dar de alta delivery
        {
            Delivery nuevo = new Delivery();
            nuevo.Telefono = personanueva.Telefono;
            nuevo.Nombre = personanueva.Nombre;
            nuevo.Dni = personanueva.Dni;
            nuevo.Direccion = personanueva.Direccion;
            nuevo.IdDelivery = personanueva.IdDelivery;
            nuevo.Salario = personanueva.Salario;
            nuevo.IdPedido = personanueva.IdPedido;
            nuevo.TiempoDemora = personanueva.TiempoDemora;
            ListaDelivery.Add(nuevo);
            InstanciaPersistenciaDeDatos.GuardarArchivoDelivery(ListaDelivery);
        }
        public void BajaDelivery(int iddelevery) //Dar de baja delivery
        {
            var DeliveryEliminado = ListaDelivery.Find(x => iddelevery == x.IdDelivery);
            ListaDelivery.Remove(DeliveryEliminado);
            InstanciaPersistenciaDeDatos.GuardarArchivoDelivery(ListaDelivery);
        }
        public void ModificarDelivery(Delivery personaNuevo, int iddelivery) //Modificacion delivery
        {
            var Deliverymodificado = ListaDelivery.Find(x => iddelivery == x.IdDelivery);

            Deliverymodificado.Nombre = personaNuevo.Nombre;
            Deliverymodificado.Dni = personaNuevo.Dni;
            Deliverymodificado.Direccion = personaNuevo.Direccion;
            Deliverymodificado.Telefono = personaNuevo.Telefono;
            Deliverymodificado.IdDelivery = personaNuevo.IdDelivery;
            Deliverymodificado.IdPedido = personaNuevo.IdPedido;
            Deliverymodificado.Salario = personaNuevo.Salario;
            Deliverymodificado.TiempoDemora = personaNuevo.TiempoDemora;

            var deliveryEliminado = ListaDelivery.Find(x => iddelivery == x.IdDelivery);
            ListaDelivery.Remove(deliveryEliminado);
            ListaDelivery.Add(Deliverymodificado);
            InstanciaPersistenciaDeDatos.GuardarArchivoDelivery(ListaDelivery);
        }

        List<Encargado> ListaEncargado = new List<Encargado>();

        public void AltaEncargado(Encargado personanueva)  //Dar de alta encargado
        {
            Encargado nuevo = new Encargado();
            nuevo.Telefono = personanueva.Telefono;
            nuevo.Nombre = personanueva.Nombre;
            nuevo.Dni = personanueva.Dni;
            nuevo.Direccion = personanueva.Direccion;
            nuevo.IdEncargado = personanueva.IdEncargado;
            ListaEncargado.Add(nuevo);
            InstanciaPersistenciaDeDatos.GuardarArchivoEncargado(ListaEncargado);

        }
        public void BajaEncargado(int idencargado) //Dar de baja encargado
        {
            var EncargadoEliminado = ListaEncargado.Find(x => idencargado == x.IdEncargado);
            ListaEncargado.Remove(EncargadoEliminado);
            InstanciaPersistenciaDeDatos.GuardarArchivoEncargado(ListaEncargado);

        }
        public void ModificarEncargado(Encargado personaNuevo, int idencargado) //Modificacion encargado
        {
            var Encargadomodificado = ListaEncargado.Find(x => idencargado == x.IdEncargado);

            Encargadomodificado.Nombre = personaNuevo.Nombre;
            Encargadomodificado.Dni = personaNuevo.Dni;
            Encargadomodificado.Direccion = personaNuevo.Direccion;
            Encargadomodificado.Telefono = personaNuevo.Telefono;
            Encargadomodificado.IdEncargado = personaNuevo.IdEncargado;

            var EncargadoEliminado = ListaEncargado.Find(x => idencargado == x.IdEncargado);
            ListaEncargado.Remove(EncargadoEliminado);
            ListaEncargado.Add(Encargadomodificado);
            InstanciaPersistenciaDeDatos.GuardarArchivoEncargado(ListaEncargado);

        }
        List<Proveedores> ListaProveedores = new List<Proveedores>();
        public void AltaProveedores(Proveedores personanueva)  //Dar de alta proveedores
        {
            Proveedores nuevo = new Proveedores();
            nuevo.Telefono = personanueva.Telefono;
            nuevo.Nombre = personanueva.Nombre;
            nuevo.Dni = personanueva.Dni;
            nuevo.Direccion = personanueva.Direccion;
            nuevo.IdProveedor = personanueva.IdProveedor;
            nuevo.IdAlimento = personanueva.IdAlimento;
            ListaProveedores.Add(nuevo);
            InstanciaPersistenciaDeDatos.GuardarArchivoProveedores(ListaProveedores);

        }
        public void BajaProveedor(int idproveedor) //Dar de baja proveedor
        {
            var ProveedorEliminado = ListaProveedores.Find(x => idproveedor == x.IdProveedor);
            ListaProveedores.Remove(ProveedorEliminado);
            InstanciaPersistenciaDeDatos.GuardarArchivoProveedores(ListaProveedores);

        }
        public void ModificarProveedor(Proveedores personaNuevo, int idproveedor) //Modificacion proveedor
        {
            var Proveedormodificado = ListaProveedores.Find(x => idproveedor == x.IdProveedor);

            Proveedormodificado.Nombre = personaNuevo.Nombre;
            Proveedormodificado.Dni = personaNuevo.Dni;
            Proveedormodificado.Direccion = personaNuevo.Direccion;
            Proveedormodificado.Telefono = personaNuevo.Telefono;
            Proveedormodificado.IdProveedor = personaNuevo.IdProveedor;

            var ProveedorEliminado = ListaProveedores.Find(x => idproveedor == x.IdProveedor);
            ListaProveedores.Remove(ProveedorEliminado);
            ListaProveedores.Add(Proveedormodificado);
            InstanciaPersistenciaDeDatos.GuardarArchivoProveedores(ListaProveedores);

        }
        List<Alimento> ListaAlimentos = new List<Alimento>();
        public void AltaAlimentos(Alimento Alimentonueva)  //Dar de alta alimento
        {
            Alimento nuevo = new Alimento();
            nuevo.Nombre = Alimentonueva.Nombre;
            nuevo.Tipo = Alimentonueva.Tipo;
            nuevo.IdAlimento = Alimentonueva.IdAlimento;
            nuevo.PrecioCosto = Alimentonueva.PrecioCosto;
            ListaAlimentos.Add(nuevo);
            InstanciaPersistenciaDeDatos.GuardarArchivoAlimento(ListaAlimentos);

        }
        public void BajaAlimentos(int idalimentos) //Dar de baja alimento
        {
            var AlimentoEliminado = ListaAlimentos.Find(x => idalimentos == x.IdAlimento);
            ListaAlimentos.Remove(AlimentoEliminado);
            InstanciaPersistenciaDeDatos.GuardarArchivoAlimento(ListaAlimentos);

        }
        public void ModificarAlimentos(Alimento AlimentoNuevo, int idalimentos) //Modificacion alimento
        {
            var Alimentomodificado = ListaAlimentos.Find(x => idalimentos == x.IdAlimento);

            Alimentomodificado.Nombre = AlimentoNuevo.Nombre;
            Alimentomodificado.Tipo = AlimentoNuevo.Tipo;
            Alimentomodificado.IdAlimento = AlimentoNuevo.IdAlimento;
            Alimentomodificado.PrecioCosto = AlimentoNuevo.PrecioCosto;
            
            var AlimentoEliminado = ListaAlimentos.Find(x => idalimentos == x.IdAlimento);
            ListaAlimentos.Remove(AlimentoEliminado);
            ListaAlimentos.Add(Alimentomodificado);
            InstanciaPersistenciaDeDatos.GuardarArchivoAlimento(ListaAlimentos);

        }
        List<Pedido> ListaPedidos = new List<Pedido>();
        public void AltaPedido(Pedido pedidonueva)  //Dar de alta pedido
        {
            ListaPedidos = ValidarPedido();
            Pedido nuevo = new Pedido();
            nuevo.IdCliente = pedidonueva.IdCliente;
            nuevo.IdPedido = pedidonueva.IdPedido;
            nuevo.Tipo = pedidonueva.Tipo;
            nuevo.HorarioEstimado = pedidonueva.HorarioEstimado;
            nuevo.CostoFinal = pedidonueva.CostoFinal;
            ListaPedidos.Add(nuevo);
            InstanciaPersistenciaDeDatos.GuardarArchivoPedidos(ListaPedidos);


        }
        public void BajaPedido(int idpedidos) //Dar de baja pedido
        {
            ListaPedidos = ValidarPedido();
            var PedidoEliminado = ListaPedidos.Find(x => idpedidos == x.IdPedido);
            ListaPedidos.Remove(PedidoEliminado);
            InstanciaPersistenciaDeDatos.GuardarArchivoPedidos(ListaPedidos);

        }
        public void ModificarPedidos(Pedido pedidoNuevo, int idpedidos) //Modificacion pedido
        {
            ListaPedidos = ValidarPedido();
            var Pedidomodificado = ListaPedidos.Find(x => idpedidos == x.IdPedido);

            Pedidomodificado.IdCliente = pedidoNuevo.IdCliente;
            Pedidomodificado.IdPedido = pedidoNuevo.IdPedido;
            Pedidomodificado.Tipo = pedidoNuevo.Tipo;
            Pedidomodificado.HorarioEstimado = pedidoNuevo.HorarioEstimado;
            Pedidomodificado.CostoFinal = pedidoNuevo.CostoFinal;

            var PedidoEliminado = ListaPedidos.Find(x => idpedidos == x.IdPedido);
            ListaPedidos.Remove(PedidoEliminado);
            ListaPedidos.Add(Pedidomodificado);
            InstanciaPersistenciaDeDatos.GuardarArchivoPedidos(ListaPedidos);

        }
        List<Ventas> ListaVentas = new List<Ventas>();
        public void AltaVentas(Ventas ventasnueva)  //Dar de alta ventas
        {
            ListaVentas = ValidarVentas();
            Ventas nuevo = new Ventas();
            nuevo.IdVentas = ventasnueva.IdVentas;
            nuevo.Fecha = ventasnueva.Fecha;
            nuevo.IdPedido = ventasnueva.IdPedido;
            nuevo.Tipo = ventasnueva.Tipo;
            nuevo.HorarioEstimado = ventasnueva.HorarioEstimado;
            nuevo.CostoFinal = ventasnueva.CostoFinal;
            nuevo.IdCliente = ventasnueva.IdCliente;
            ListaVentas.Add(nuevo);
            InstanciaPersistenciaDeDatos.GuardarArchivoVentas(ListaVentas);

        }
        public void BajaVenta(int idventas) //Dar de baja ventas
        {
            ListaVentas = ValidarVentas();
            var VentaEliminado = ListaVentas.Find(x => idventas == x.IdVentas);
             ListaVentas.Remove(VentaEliminado);
            InstanciaPersistenciaDeDatos.GuardarArchivoVentas(ListaVentas);

        }
        public void ModificarVentas(Ventas ventaNuevo, int idventas) //Modificacion ventas
        {
            ListaVentas = ValidarVentas();
            var Ventamodificado = ListaVentas.Find(x => idventas == x.IdVentas);

            Ventamodificado.IdVentas = ventaNuevo.IdVentas;
            Ventamodificado.Fecha = ventaNuevo.Fecha;
            Ventamodificado.IdPedido = ventaNuevo.IdPedido;
            Ventamodificado.Tipo = ventaNuevo.Tipo;
            Ventamodificado.HorarioEstimado = ventaNuevo.HorarioEstimado;
            Ventamodificado.CostoFinal = ventaNuevo.CostoFinal;
            Ventamodificado.IdCliente = ventaNuevo.IdCliente;

            var VentaEliminado = ListaVentas.Find(x => idventas == x.IdVentas);
            ListaVentas.Remove(VentaEliminado);
            ListaVentas.Add(Ventamodificado);
            InstanciaPersistenciaDeDatos.GuardarArchivoVentas(ListaVentas);

        }

        Persistenciadedatos InstanciaPersistenciaDeDatos = new Persistenciadedatos(); //Relleno de listas
        public void Rellenarlistas()
        {
            ListaCliente = InstanciaPersistenciaDeDatos.LeerArchivoCliente();
            ListaAlimentos = InstanciaPersistenciaDeDatos.LeerArchivoAlimentos();
            ListaCajero = InstanciaPersistenciaDeDatos.LeerArchivoCajero();
            ListaCocinero = InstanciaPersistenciaDeDatos.LeerArchivoCocinero();
            ListaDelivery = InstanciaPersistenciaDeDatos.LeerArchivoDelivery();
            ListaEncargado = InstanciaPersistenciaDeDatos.LeerArchivoEncargado();
            ListaPedidos = InstanciaPersistenciaDeDatos.LeerArchivoPedido();
            ListaProveedores = InstanciaPersistenciaDeDatos.LeerArchivoProveedores();
            ListaVentas = InstanciaPersistenciaDeDatos.LeerArchivoVentas();
        }

        public List<Cliente> ValidarCliente()
        {
            ListaCliente = InstanciaPersistenciaDeDatos.LeerArchivoCliente();
            if (ListaCliente == null)
            {
                List<Cliente> NuevaListaCliente = new List<Cliente>();
                return NuevaListaCliente;
            }
            else
            {
                return ListaCliente;
            }
        }
        public List<Alimento> ValidarAlimento()
        {
            ListaAlimentos = InstanciaPersistenciaDeDatos.LeerArchivoAlimentos();
            if (ListaAlimentos == null)
            {
                List<Alimento> NuevaListaAlimento = new List<Alimento>();
                return NuevaListaAlimento;
            }
            else
            {
                return ListaAlimentos;
            }
        }
        public List<Cajero> ValidadCajero()
        {
            ListaCajero = InstanciaPersistenciaDeDatos.LeerArchivoCajero();
            if (ListaCajero == null)
            {
                List<Cajero> NuevaListaCajero = new List<Cajero>();
                return NuevaListaCajero;
            }
            else
            {
                return ListaCajero;
            }
        }
        public List<Cocinero> ValidarCocinero()
        {
            ListaCocinero = InstanciaPersistenciaDeDatos.LeerArchivoCocinero();
            if (ListaCocinero == null)
            {
                List<Cocinero> NuevaListaCocinero = new List<Cocinero>();
                return NuevaListaCocinero;
            }
            else
            {
                return ListaCocinero;
            }
        }
        public List<Delivery> ValidarDelivery()
        {
            ListaDelivery = InstanciaPersistenciaDeDatos.LeerArchivoDelivery();
            if (ListaDelivery == null)
            {
                List<Delivery> NuevaListaDelivery = new List<Delivery>();
                return NuevaListaDelivery;
            }
            else
            {
                return ListaDelivery;
            }
        }
        public List<Encargado> ValidarEncargado()
        {
            ListaEncargado = InstanciaPersistenciaDeDatos.LeerArchivoEncargado();
            if (ListaEncargado == null)
            {
                List<Encargado> NuevaListaEncargado = new List<Encargado>();
                return NuevaListaEncargado;
            }
            else
            {
                return ListaEncargado;
            }
        }
        public List<Pedido> ValidarPedido()
        {
            ListaPedidos = InstanciaPersistenciaDeDatos.LeerArchivoPedido();
            if (ListaPedidos == null)
            {
                List<Pedido> NuevaListaPedido = new List<Pedido>();
                return NuevaListaPedido;
            }
            else
            {
                return ListaPedidos;
            }
        }
        public List<Proveedores> ValidarProveedores()
        {
            ListaProveedores = InstanciaPersistenciaDeDatos.LeerArchivoProveedores();
            if (ListaProveedores == null)
            {
                List<Proveedores> NuevaListaProveedores = new List<Proveedores>();
                return NuevaListaProveedores;
            }
            else
            {
                return ListaProveedores;
            }
        }
        public List<Ventas> ValidarVentas()
        {
            ListaVentas = InstanciaPersistenciaDeDatos.LeerArchivoVentas();
            if (ListaVentas == null)
            {
                List<Ventas> NuevaListaVentas = new List<Ventas>();
                return NuevaListaVentas;
            }
            else
            {
                return ListaVentas;
            }
        }
        public List<Cliente> BuscarClientePorID(int idcliente) //Buscar cliente
        {
            List<Cliente> NuevaListaCliente = new List<Cliente>();
            if (ListaCliente == null)
            {
                return NuevaListaCliente;
            }
            else
            {
                var clienteObtenido = ListaCliente.Find(x => idcliente == x.IdCliente);
                NuevaListaCliente.Add(clienteObtenido);
                return NuevaListaCliente;
            }
        }
        public List<Alimento> BuscarAlimentoporID(int idalimento) //Buscar alimento
        {
            List<Alimento> NuevaListaAlimento = new List<Alimento>();
            if (ListaAlimentos == null)
            {
                return NuevaListaAlimento;
            }
            else
            {
                var alimentoObtenido = ListaAlimentos.Find(x => idalimento == x.IdAlimento);
                NuevaListaAlimento.Add(alimentoObtenido);
                return NuevaListaAlimento;
            }
        }
        public List<Pedido> BuscarPedidoID(int idpedido)
        {
            List<Pedido> NuevaListaPedido = new List<Pedido>();
            if (ListaPedidos ==null)
            {
                return NuevaListaPedido;
            }
            else
            {
                var pedidoObtenido = ListaPedidos.Find(x => idpedido == x.IdPedido);
                NuevaListaPedido.Add(pedidoObtenido);
                return NuevaListaPedido;
            }

        }



        


































    }



































    }

