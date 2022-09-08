using Domain.Models;
using Infra.Repositories;
using Services.Base;
using Services.Dtos;
using Services.ViewModels.ResponseResult;

namespace Services;

public class PecuaristaService : ServiceBase<Pecuarista>
{
    readonly PecuaristaRepository pecuaristaRepository;

    public PecuaristaService(PecuaristaRepository _pecuaristaRepository) : base(_pecuaristaRepository)
    {
        this.pecuaristaRepository = _pecuaristaRepository;
    }

    public async Task<Pecuarista> GetByIdAsync(int Id)
    {
        Pecuarista result = null;
        try
        {
            result = await this.pecuaristaRepository.GetByIdAsync(Id);
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public ListResponseResult<Pecuarista> GetAll(int pageSize = 10, int pageIndex = 1, string query = "")
    {
        try
        {
            IList<Pecuarista> result;

            result = this.pecuaristaRepository.GetAll();

            var totalCount = result.Count();
            if (result != null && totalCount > 0)
            {
                var data = result.Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(e => e.Id).ToList();

                return new ListResponseResult<Pecuarista>
                {
                    Data = data,
                    Success = true,
                    Pagination = {
                        PageIndex = pageIndex,
                        PageSize = pageSize,
                        TotalResult = totalCount,
                        TotalPages = (int)Math.Ceiling((decimal)totalCount/pageSize),
                        HasPrevious = pageIndex > 1,
                        HasNext = pageIndex < (int)Math.Ceiling((decimal)totalCount / pageSize)
                    }
                };
            }
            return new ListResponseResult<Pecuarista> { Data = null, Success = false, Pagination = null };
        }
        catch (Exception)
        {
            return new ListResponseResult<Pecuarista> { Data = null, Success = false, Pagination = null };
        }
    }

    public async Task<Pecuarista> Save(PecuaristaDTO pecuaristaDTO)
    {
        try
        {
            if (string.IsNullOrEmpty(pecuaristaDTO.Nome))
            {
                this.AddErrorApplicationErrors("pecuaristaNullOrEmpty", "O nome está vazio.");
                return null;
            }

            var pecuarista = new Pecuarista(pecuaristaDTO.Id, pecuaristaDTO.Nome);

            var result = await pecuaristaRepository.SaveOrUpdateAsync(pecuarista);

            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public async Task Delete(int id)
    {
        var result = await GetByIdAsync(id);

        // Fazer validação se existe dados com este ID.

        if (result != null)
        {
            pecuaristaRepository.Delete(result);
        }
        return;
    }
}
