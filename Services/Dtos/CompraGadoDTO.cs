using Domain.Abstractions;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos
{
    public class CompraGadoDTO : BaseEntity
    {
        public CompraGadoDTO(ICollection<CompraGadoItemDTO> compraGadoItemDTO)
        {
            this.compraGadoItemDTO = compraGadoItemDTO;
        }

        public int IdPecuarista { get; set; }
        public DateTime DataEntrega { get; set; }

        public ICollection<CompraGadoItemDTO> compraGadoItemDTO { get; set; }
    }
}
