using Domain.Models;
using Infra.Base.Abstractions;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class CompraGadoItemRepository : DatabaseRepository<CompraGadoItem>
    {
        public CompraGadoItemRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<CompraGadoItem> GetAllWithOthersEntities()
        {
            return this.set
                .Include("CompraGado")
                .AsQueryable();

        }

        public IQueryable<CompraGadoItem> GetAllByCompraGadoId(int idCompraGado)
        {
            return this.set
                .Include(c => c.CompraGado)
                .Where(c => c.IdCompraGado == idCompraGado)
                .AsQueryable();
        }
    }
}
