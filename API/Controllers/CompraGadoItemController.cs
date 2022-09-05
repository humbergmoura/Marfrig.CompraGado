using Domain.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Dtos;
using Services.ViewModels.ResponseResult;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
[EnableCors("MyPolicy")]
public class CompraGadoItemController : ControllerBase
{
    private readonly CompraGadoItemService compraGadoItemService;

    public CompraGadoItemController(CompraGadoItemService compraGadoItemService)
    {
        this.compraGadoItemService = compraGadoItemService;
    }

    [HttpGet]
    [Route("BuscarCompraGadoItemPorId")]
    public async Task<CompraGadoItem> GetByIdAsync(int id)
    {
        return await compraGadoItemService.GetByIdAsync(id);
    }

    [HttpGet]
    [Route("BuscarCompraGadoItems")]
    public ListResponseResult<CompraGadoItem> GetAll(int pageSize = 10, int pageIndex = 1)
    {
        return compraGadoItemService.GetAll(pageSize, pageIndex);
    }

    [HttpPost]
    [Route("SalvarCompraGadoItem")]
    public async Task<CompraGadoItem> Save([FromBody] CompraGadoItemDTO compraGadoItem)
    {
        return await compraGadoItemService.Save(compraGadoItem);
    }

    [HttpPut]
    [Route("AtualizarCompraGadoItem")]
    public async Task<CompraGadoItem> Update([FromBody] CompraGadoItemDTO compraGadoItem)
    {
        return await compraGadoItemService.Save(compraGadoItem);
    }

    [HttpDelete]
    [Route("ExcluirCompraGadoItem")]
    public async Task Delete(int id)
    {
        await compraGadoItemService.Delete(id);
    }
}
