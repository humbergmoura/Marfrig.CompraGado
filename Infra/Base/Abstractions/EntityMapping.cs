using Domain.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Base.Abstractions
{
    public abstract class EntityMapping<TEntity> where TEntity : BaseEntity
    {
        public abstract void Map(EntityTypeBuilder<TEntity> entity);
    }
}
