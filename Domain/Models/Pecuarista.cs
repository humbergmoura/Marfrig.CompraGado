using Domain.Abstractions;
using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Pecuarista:BaseEntity
{
    public Pecuarista(int id, string nome)
    {
        Animals = new HashSet<Animal>();
        CompraGados = new HashSet<CompraGado>();
        Id = id;
        Nome = nome;
    }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Animal> Animals { get; set; }
    public virtual ICollection<CompraGado> CompraGados { get; set; }
}
