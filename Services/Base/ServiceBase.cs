using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Base;

public abstract class ServiceBase : IServiceBase
{
    public Dictionary<string, string> ApplicationErrors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void AddErrorApplicationErrors(string key, string value)
    {
        if (this.ApplicationErrors == null)
            this.ApplicationErrors = new Dictionary<string, string>();

        if (!this.ApplicationErrors.ContainsKey(key))
            this.ApplicationErrors.Add(key, value);
    }

    public void ResetApplicationErrors()
    {
        this.ApplicationErrors = new Dictionary<string, string>();
    }
}
