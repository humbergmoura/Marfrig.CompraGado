using Domain.Models;
using Infra.Repositories;
using Services.Base;
using Services.Dtos;
using Services.ViewModels.ResponseResult;
using System.Collections.ObjectModel;

namespace Services;

public class CompraGadoService : ServiceBase
{
    readonly CompraGadoRepository compraGadoRepository;

    public CompraGadoService(CompraGadoRepository _compraGadoRepository)
    {
        this.compraGadoRepository = _compraGadoRepository;
    }

    public async Task<CompraGado> GetByIdAsync(int id)
    {
        try
        {
            return await this.compraGadoRepository.GetByIdAsync(id);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public ListResponseResult<CompraGado> GetAll(int pageSize = 10, int pageIndex = 0, string query = "")
    {
        try
        {
            IList<CompraGado> result;

            result = this.compraGadoRepository.GetAll();

            var totalCount = result.Count();
            if (result != null && totalCount > 0)
            {
                var data = result.Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(e => e.Id).ToList();

                return new ListResponseResult<CompraGado>
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
            return new ListResponseResult<CompraGado> { Data = null, Success = false, Pagination = null };
        }
        catch (Exception)
        {
            return new ListResponseResult<CompraGado> { Data = null, Success = false, Pagination = null };
        }
    }

    public async Task<CompraGado> Save(CompraGadoDTO compraGadoDTO)
    {
        try
        {
            DateTime dataEntrega;
            if (!DateTime.TryParse(compraGadoDTO.DataEntrega.ToShortDateString(), out dataEntrega))
            {
                this.AddErrorApplicationErrors("Data Inválida", "Informe uma data correta");
                new Exception("Erro: Data inválida!");
                return null;
            }

            ICollection<CompraGadoItem> compraGadoItems = new Collection<CompraGadoItem>();
            foreach (var item in compraGadoDTO.compraGadoItemDTO)
            {
                var compraGadoItem = new CompraGadoItem(item.IdCompraGado, item.IdAnimal, item.Quantidade);
                compraGadoItems.Add(compraGadoItem);
            }

            var compraGado = new CompraGado(compraGadoDTO.Id, compraGadoDTO.IdPecuarista, compraGadoDTO.DataEntrega);
            compraGado.CompraGadoItems = compraGadoItems;
            var result = await compraGadoRepository.SaveOrUpdateAsync(compraGado);

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
            compraGadoRepository.Delete(result);
        }
        return;
    }
}