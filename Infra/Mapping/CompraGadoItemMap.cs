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
    public class CompraGadoItemMap : EntityMapping<CompraGadoItem>
    {
        public override void Map(EntityTypeBuilder<CompraGadoItem> entity)
        {
            entity.ToTable("CompraGadoItem");

            entity.HasOne(d => d.Animal)
                .WithMany(p => p.CompraGadoItems)
                .HasForeignKey(d => d.IdAnimal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompraGadoItem_Animal");

            entity.HasOne(d => d.CompraGado)
                .WithMany(p => p.CompraGadoItems)
                .HasForeignKey(d => d.IdCompraGado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompraGadoItem_CompraGado");
        }
    }
}
