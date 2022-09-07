using Domain.Abstractions;
using Infra.Base.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Extension;

internal static class ModelBuilderExtension
{
    public static void AddMapping<TEntity>(this ModelBuilder builder, EntityMapping<TEntity> mapping) where TEntity : BaseEntity
    {
        builder.Entity<TEntity>(mapping.Map);
    }
}
