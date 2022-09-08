using Domain.Abstractions;
using FluentValidation;
using Infra.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Base;

public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : BaseEntity
{
    private readonly IDatabaseRepository<TEntity> _baseRepository;

    public ServiceBase(IDatabaseRepository<TEntity> baseRepository)
    {
        _baseRepository = baseRepository;
    }

    public async Task<TEntity> Add<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>
    {
        Validate(obj, Activator.CreateInstance<TValidator>());
        await _baseRepository.SaveOrUpdateAsync(obj);
        return obj;
    }

    public void Delete(TEntity entity) => _baseRepository.Delete(entity);

    public IList<TEntity> Get(int PageIndex = -1, int PageSize = 10) => _baseRepository.GetAll(PageIndex, PageSize);

    public Task<TEntity> GetById(dynamic id) => _baseRepository.GetByIdAsync(id);

    public async Task<TEntity> Update<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>
    {
        Validate(obj, Activator.CreateInstance<TValidator>());
        await _baseRepository.SaveOrUpdateAsync(obj);
        return obj;
    }

    private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
    {
        if (obj == null)
            throw new Exception("Registros não detectados!");

        validator.ValidateAndThrow(obj);
    }

    public void ResetApplicationErrors()
    {
        this.ApplicationErrors = new Dictionary<string, string>();
    }

    public Dictionary<string, string> ApplicationErrors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void AddErrorApplicationErrors(string key, string value)
    {
        if (this.ApplicationErrors == null)
            this.ApplicationErrors = new Dictionary<string, string>();

        if (!this.ApplicationErrors.ContainsKey(key))
            this.ApplicationErrors.Add(key, value);
    }
}
