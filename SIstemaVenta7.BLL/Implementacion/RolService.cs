using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SIstemaVenta7.BLL.Interfaces;
using SistemaVenta7.DAL.Interfaces;
using SistemaVenta7.Entity;

namespace SIstemaVenta7.BLL.Implementacion
{
    public class RolService : IRolService
    {
        private readonly IGenericRepository<Rol> _repositorio;

        public RolService(IGenericRepository<Rol> repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Rol>> Lista()
        {
            IQueryable<Rol> query = await _repositorio.Consultar();

            return query.ToList();
        }
    }
}
