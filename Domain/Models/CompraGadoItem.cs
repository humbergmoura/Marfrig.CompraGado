using Domain.Abstractions;

namespace Domain.Models;

public partial class CompraGadoItem : BaseEntity
{
    public CompraGadoItem(int idCompraGado, int idAnimal, int quantidade)
    {
        IdCompraGado = idCompraGado;
        IdAnimal = idAnimal;
        Quantidade = quantidade;
    }

    public int IdCompraGado { get; set; }
    public int IdAnimal { get; set; }
    public int Quantidade { get; set; }

    public virtual Animal Animal { get; set; } = null!;
    public virtual CompraGado CompraGado { get; set; } = null!;
}
