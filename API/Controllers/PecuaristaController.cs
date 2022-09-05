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
public class PecuaristaController : ControllerBase
{
    private readonly PecuaristaService pecuaristaService;

    public PecuaristaController(PecuaristaService pecuaristaService)
    {
        this.pecuaristaService = pecuaristaService;
    }

    [HttpGet]
    [Route("BuscarPecuaristaPorId")]
    public async Task<Pecuarista> GetById(int id)
    {
        return await pecuaristaService.GetByIdAsync(id);
    }

    [HttpGet]
    [Route("BuscarPecuaristas")]
    public ListResponseResult<Pecuarista> GetAll(int pageSize = 10, int pageIndex = 1)
    {
        return pecuaristaService.GetAll(pageSize, pageIndex);
    }

    [HttpPost]
    [Route("SalvarPecuarista")]
    public async Task<Pecuarista> Save([FromBody] PecuaristaDTO pecuarista)
    {
        return await pecuaristaService.Save(pecuarista);
    }

    [HttpPut]
    [Route("AtualizarPecuarista")]
    public async Task<Pecuarista> Update([FromBody] PecuaristaDTO pecuarista)
    {
        return await pecuaristaService.Save(pecuarista);
    }

    [HttpDelete]
    [Route("ExcluirPecuarista")]
    public async Task Delete(int id)
    {
        await pecuaristaService.Delete(id);
    }
}
