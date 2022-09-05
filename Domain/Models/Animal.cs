using System;
using System.Collections.Generic;
using Domain.Abstractions;

namespace Domain.Models;

public partial class Animal : BaseEntity
{
    public Animal(int id, string descricao, decimal preco, int idPecuarista, int quantidade)
    {
        CompraGadoItems = new HashSet<CompraGadoItem>();
        Descricao = descricao;
        Preco = preco;
        IdPecuarista = idPecuarista;
        Quantidade = quantidade;
        Id = id;
    }

    public string Descricao { get; set; } = null!;
    public decimal Preco { get; set; }
    public int IdPecuarista { get; set; }
    public int Quantidade { get; set; }

    public virtual Pecuarista Pecuarista { get; set; } = null!;
    public virtual ICollection<CompraGadoItem> CompraGadoItems { get; set; }

    public void Update(string descricao, decimal preco, int idPecuarista, int quantidade)
    {
        Validar(descricao, preco, idPecuarista, quantidade);
    }

    public void Save(string descricao, decimal preco, int idPecuarista, int quantidade)
    {
        Validar(descricao, preco, idPecuarista, quantidade);
    }

    private void Validar(string descricao, decimal preco, int idPecuarista, int quantidade)
    {
        if (string.IsNullOrEmpty(descricao))
        {
            throw new InvalidOperationException($"O {nameof(descricao)} é inváldo.");
        }
        if (string.IsNullOrEmpty(descricao))
        {
            throw new InvalidOperationException($"O {nameof(preco)} é inváldo.");
        }
        if (string.IsNullOrEmpty(descricao))
        {
            throw new InvalidOperationException($"O {nameof(idPecuarista)} é inváldo.");
        }
        if (string.IsNullOrEmpty(descricao))
        {
            throw new InvalidOperationException($"O {nameof(quantidade)} é inváldo.");
        }
    }
}
