using System.ComponentModel.DataAnnotations.Schema;

namespace UI.Entities;

public class Animal
{
    public int Id { get; set; }
    public string Descricao { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    public int IdPecuarista { get; set; }
    public string Pecuarista { get; set; }
}
