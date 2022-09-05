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
public class CompraGadoController : ControllerBase
{
    private readonly CompraGadoService compraGadoService;

    public CompraGadoController(CompraGadoService compraGadoService)
    {
        this.compraGadoService = compraGadoService;
    }

    [HttpGet]
    [Route("BuscarCompraGadoPorId")]
    public async Task<CompraGado> GetByIdAsync(int id)
    {
        return await compraGadoService.GetByIdAsync(id);
    }

    [HttpGet]
    [Route("BuscarCompraGado")]
    public ListResponseResult<CompraGado> GetAll(int pageSize = 10, int pageIndex = 1)
    {
        return compraGadoService.GetAll(pageSize, pageIndex);
    }

    [HttpPost]
    [Route("SalvarCompraGado")]
    public async Task<CompraGado> Post([FromBody] CompraGadoDTO compraGado)
    {
        return await compraGadoService.Save(compraGado);
    }

    [HttpPut]
    [Route("AtualizarCompraGado")]
    public async Task<CompraGado> Put([FromBody] CompraGadoDTO compraGado)
    {
        return await compraGadoService.Save(compraGado);
    }

    [HttpDelete]
    [Route("ExcluirAnimal")]
    public async Task Delete(int id)
    {
        await compraGadoService.Delete(id);
    }
}
