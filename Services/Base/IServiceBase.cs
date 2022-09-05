using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Base;

public interface IServiceBase
{
    Dictionary<string, string> ApplicationErrors { get; set; }

    void AddErrorApplicationErrors(string key, string value);
    void ResetApplicationErrors();
}
