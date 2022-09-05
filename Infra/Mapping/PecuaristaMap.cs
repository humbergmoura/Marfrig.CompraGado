using Domain.Models;
using Infra.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mapping
{
    public class PecuaristaMap : EntityMapping<Pecuarista>
    {
        public override void Map(EntityTypeBuilder<Pecuarista> entity)
        {
            entity.Property(e => e.Nome)
                  .HasMaxLength(250)
                  .IsUnicode(false);
        }
    }
}
