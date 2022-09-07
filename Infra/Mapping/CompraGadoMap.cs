using Domain.Abstractions;
using Domain.Models;
using Infra.Base.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mapping
{
    public class CompraGadoMap : EntityMapping<CompraGado>
    {
        public override void Map(EntityTypeBuilder<CompraGado> entity)
        {
            entity.ToTable("CompraGado");

            entity.Property(e => e.DataEntrega).HasColumnType("datetime");

            entity.HasOne(d => d.Pecuarista)
                .WithMany(p => p.CompraGados)
                .HasForeignKey(d => d.IdPecuarista)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompraGado_Pecuarista");
        }
    }
}
