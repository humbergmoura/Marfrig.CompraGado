using Domain.Models;
using Infra.Base.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mapping
{
    public class AnimalMap: EntityMapping<Animal>
    {
        public override void Map(EntityTypeBuilder<Animal> entity)
        {
                entity.ToTable("Animal");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Preco).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Pecuarista)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.IdPecuarista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Animal_Pecuarista");
        }
    }
}
