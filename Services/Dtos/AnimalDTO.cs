using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos
{
    public class AnimalDTO : BaseEntity
    {
        public string Descricao { get; set; } = null!;
        public decimal Preco { get; set; }
        public int IdPecuarista { get; set; }
        public int Quantidade { get; set; }
    }
}
