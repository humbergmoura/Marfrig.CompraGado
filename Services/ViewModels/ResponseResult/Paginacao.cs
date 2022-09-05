using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewModels.ResponseResult
{
    public class Paginacao
    {
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int TotalResult { get; set; }
        public int TotalPages { get; set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }
    }
}
