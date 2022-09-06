using Domain.Models;
using Infra.Repositories;
using Services.Base;
using Services.Dtos;
using Services.ViewModels.ResponseResult;

namespace Services;

public class CompraGadoItemService : ServiceBase
{
    readonly CompraGadoItemRepository compraGadoItemRepository;
    readonly CompraGadoRepository compraGadoRepository;
    readonly PecuaristaRepository pecuaristaRepository;

    public CompraGadoItemService(CompraGadoItemRepository _compraGadoItemRepository, CompraGadoRepository compraGadoRepository, PecuaristaRepository pecuaristaRepository)
    {
        this.compraGadoItemRepository = _compraGadoItemRepository;
        this.compraGadoRepository = compraGadoRepository;
        this.pecuaristaRepository = pecuaristaRepository;
    }

    public async Task<CompraGadoItem> GetByIdAsync(int id)
    {
        try
        {
            var compraGadoItem = await compraGadoItemRepository.GetByIdAsync(id);
            if (compraGadoItemRepository.GetAll().Where(x => x.IdCompraGado == compraGadoItem.IdCompraGado).Count() == 1)
                compraGadoItem.CompraGado = await compraGadoRepository.GetByIdAsync(compraGadoItem.IdCompraGado);
            return await this.compraGadoItemRepository.GetByIdAsync(id);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public ListResponseResult<CompraGadoItem> GetAll(int pageSize = 10, int pageIndex = 0, ConsultaCompraDTO? query = null)
    {
        try
        {
            IList<CompraGadoItem> result;

            result = this.compraGadoItemRepository.GetAll();

            if (query.Id != null || query.Nome != null || query.DataDe != null || query.DataAte != null)
            {
                foreach (var item in result)
                {
                    item.CompraGado = compraGadoRepository.GetByIdAsync(item.IdCompraGado).Result;
                }
                if (query.Id != null)
                {
                    result = result.Where(x => x.Id == query.Id).ToList();
                }
                if (query.Nome != null)
                {
                    var pe = pecuaristaRepository.GetAll().Where(x => x.Nome.Contains(query.Nome));
                    foreach (var item in pe)
                    {
                        result = result.Where(x => x.CompraGado.IdPecuarista == item.Id).ToList();
                    }
                }
                if (query.DataDe != null)
                {
                    result = result.Where(x => x.CompraGado.DataEntrega >= query.DataDe).ToList();
                }
                if (query.DataAte != null)
                {
                    result = result.Where(x => x.CompraGado.DataEntrega <= query.DataAte).ToList();
                }
            }

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
            if (result.CompraGado != null)
            {
                compraGadoRepository.Delete(result.CompraGado);
            }
        }
        return;
    }
}