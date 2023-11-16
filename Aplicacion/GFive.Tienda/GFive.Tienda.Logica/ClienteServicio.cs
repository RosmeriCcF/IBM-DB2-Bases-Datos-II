using GFive.Tienda.Repositorio;
using System.Data;

namespace GFive.Tienda.Logica
{
    public class ClienteServicio
    {
        private readonly ClienteRepositorio clienteRepositorio;

        public ClienteServicio()
        {
            clienteRepositorio = new ClienteRepositorio();
        }

        public DataTable SelectAll()
        {
            return clienteRepositorio.GETClientes().Tables[0];
        }

        public DataTable SelectClienteByDNI(string dni)
        {
            return clienteRepositorio.GETClientes(dni).Tables[0];
        }
    }
}
