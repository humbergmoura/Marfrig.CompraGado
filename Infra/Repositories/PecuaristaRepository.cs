using Domain.Models;
using Infra.Base.Abstractions;
using Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class PecuaristaRepository : DatabaseRepository<Pecuarista>
    {
        public PecuaristaRepository(AppDbContext context) : base(context)
        {
        }
    }
}
