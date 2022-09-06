using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos
{
    public class ConsultaCompraDTO
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataDe { get; set; }
        public DateTime? DataAte { get; set; }
    }
}
