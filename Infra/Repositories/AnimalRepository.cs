using Domain.Models;
using Infra.Base.Abstractions;
using Infra.Context;

namespace Infra.Repositories;

public class AnimalRepository : DatabaseRepository<Animal>
{
    public AnimalRepository(AppDbContext context) : base(context)
    {
    }
}
