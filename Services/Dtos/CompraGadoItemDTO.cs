using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos
{
    public class CompraGadoItemDTO : BaseEntity
    {
        public int IdCompraGado { get; set; }
        public int IdAnimal { get; set; }
        public int Quantidade { get; set; }
    }
}
