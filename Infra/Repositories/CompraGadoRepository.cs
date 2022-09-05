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
    public class CompraGadoRepository : DatabaseRepository<CompraGado>
    {
        public CompraGadoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
