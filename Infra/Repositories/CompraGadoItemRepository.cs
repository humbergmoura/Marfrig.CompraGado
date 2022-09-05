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
    }
}
