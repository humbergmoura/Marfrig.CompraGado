using Domain.Abstractions;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Base;

public interface IServiceBase<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> Add<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;

    void Delete(TEntity entity);

    IList<TEntity> Get(int PageIndex = -1, int PageSize = 10);

    Task<TEntity> GetById(dynamic id);

    Task<TEntity> Update<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;

    Dictionary<string, string> ApplicationErrors { get; set; }

    void AddErrorApplicationErrors(string key, string value);
    void ResetApplicationErrors();
}
