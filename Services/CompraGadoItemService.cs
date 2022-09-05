using Domain.Models;
using Infra.Repositories;
using Services.Base;
using Services.Dtos;
using Services.ViewModels.ResponseResult;

namespace Services;

public class CompraGadoItemService : ServiceBase
{
    readonly CompraGadoItemRepository compraGadoItemRepository;

    public CompraGadoItemService(CompraGadoItemRepository _compraGadoItemRepository)
    {
        this.compraGadoItemRepository = _compraGadoItemRepository;
    }

    public async Task<CompraGadoItem> GetByIdAsync(int id)
    {
        try
        {
            return await this.compraGadoItemRepository.GetByIdAsync(id);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public ListResponseResult<CompraGadoItem> GetAll(int pageSize = 10, int pageIndex = 0, string query = "")
    {
        try
        {
            IList<CompraGadoItem> result;

            result = this.compraGadoItemRepository.GetAll();

            var totalCount = result.Count();
            if (result != null && totalCount > 0)
            {
                var data = result.Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(e => e.Id).ToList();

                return new ListResponseResult<CompraGadoItem>
                {
                    Data = data,
                    Success = true,
                    Pagination = {
                        PageIndex = pageIndex,
                        PageSize = pageSize,
                        TotalResult = totalCount,
                        TotalPages = (int)Math.Ceiling((decimal)totalCount / pageSize),
                        HasPrevious = pageIndex > 1,
                        HasNext = pageIndex < (int)Math.Ceiling((decimal)totalCount / pageSize)
                    }
                };
            }
            return new ListResponseResult<CompraGadoItem> { Data = null, Success = false, Pagination = null };
        }
        catch (Exception)
        {
            return new ListResponseResult<CompraGadoItem> { Data = null, Success = false, Pagination = null };
        }
    }

    public async Task<CompraGadoItem> Save(CompraGadoItemDTO compraGadoItemDTO)
    {
        try
        {
            if (compraGadoItemDTO.Quantidade < 1)
            {
                this.AddErrorApplicationErrors("Quantidade Inválida", "A quantidade de gado deve ser maior que ZERO");
                return null;
            }

            CompraGadoItem compraGadoItem = new CompraGadoItem(compraGadoItemDTO.IdAnimal, compraGadoItemDTO.IdCompraGado, compraGadoItemDTO.Quantidade);

            var result = await compraGadoItemRepository.SaveOrUpdateAsync(compraGadoItem);

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

        if (result != null)
        {
            compraGadoItemRepository.Delete(result);
        }
        return;
    }
}