using Domain.Abstractions;

namespace Domain.Models;

public partial class CompraGado : BaseEntity
{
    public CompraGado(int id, int idPecuarista, DateTime dataEntrega)
    {
        CompraGadoItems = new HashSet<CompraGadoItem>();
        Id = id;
        IdPecuarista = idPecuarista;
        DataEntrega = dataEntrega;
    }

    public int IdPecuarista { get; set; }
    public DateTime DataEntrega { get; set; }

    public virtual Pecuarista Pecuarista { get; set; } = null!;
    public virtual ICollection<CompraGadoItem> CompraGadoItems { get; set; }
}
