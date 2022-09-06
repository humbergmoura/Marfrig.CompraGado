using System;
using System.Collections.Generic;
using Domain.Models;
using Infra.Extension;
using Infra.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infra.Context
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.UseCollation("Latin1_General_CI_AI");

            modelBuilder.AddMapping(new AnimalMap());
            modelBuilder.AddMapping(new PecuaristaMap());
            modelBuilder.AddMapping(new CompraGadoMap());
            modelBuilder.AddMapping(new CompraGadoItemMap());
        }
    }
}
