﻿using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos
{
    public class PecuaristaDTO : BaseEntity
    {
        public string Nome { get; set; } = null!;
    }
}
