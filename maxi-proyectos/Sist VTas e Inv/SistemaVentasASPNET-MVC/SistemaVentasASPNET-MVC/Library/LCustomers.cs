using SistemaVentasASPNET_MVC.Areas.Clientes.Models;
using SistemaVentasASPNET_MVC.Data;
using System.Collections.Generic;
using System.Linq;
using System;

namespace SistemaVentasASPNET_MVC.Library
{
    public class LCustomers : ListObject
    {
        public LCustomers(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<InputModelRegister> getTClients(String valor, int id)
        {
            List<TClients> listTClients;
            var clientsList = new List<InputModelRegister>();
            if (valor == null && id.Equals(0))
            {
                listTClients = _context.TClients.ToList();
            }
            else
            {
                if (id.Equals(0))
                {
                    listTClients = _context.TClients.Where(u => u.NID.StartsWith(valor) || u.Nombre.StartsWith(valor) ||
              u.Apellido.StartsWith(valor) || u.Email.StartsWith(valor)).ToList();
                }
                else
                {
                    listTClients = _context.TClients.Where(u => u.IdCliente.Equals(id)).ToList();
                }
            }
            if (!listTClients.Count.Equals(0))
            {
                foreach (var item in listTClients)
                {
                    clientsList.Add(new InputModelRegister
                    {
                        IdCliente = item.IdCliente,
                        NID = item.NID,
                        Nombre = item.Nombre,
                        Apellido = item.Apellido,
                        Email = item.Email,
                        Telefono = item.Telefono,
                        Credito = item.Credito,
                        Direccion = item.Direccion,
                        Image = item.Image,
                    });
                }
            }
            return clientsList;
        }

        public List<TClients> getTClient(String Nid)
        {
            var listTClients = new List<TClients>();
            using (var dbContext = new ApplicationDbContext())
            {
                listTClients = dbContext.TClients.Where(u => u.NID.Equals(Nid)).ToList();
            }

            return listTClients;
        }
    }
}
