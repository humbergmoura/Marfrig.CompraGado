using Domain.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Services;
using Services.Dtos;
using Services.Validators;
using Services.ViewModels.ResponseResult;
using System.Net.Mime;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
[EnableCors("MyPolicy")]
public class AnimaisController : ControllerBase
{
    private readonly AnimalService animalService;

    public AnimaisController(AnimalService animalService)
    {
        this.animalService = animalService;
    }

    [HttpGet]
    [Route("BuscarAnimalPorId")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        if (id == 0)
            return NotFound();

        return await ExecuteAsync(() => animalService.GetById(id));
    }

    [HttpGet]
    [Route("BuscarAnimais")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public ListResponseResult<Animal> GetAll(int pageSize = 10, int pageIndex = 1)
    {
        return this.animalService.GetAll(pageSize, pageIndex);
    }

    [HttpPost]
    [Route("SalvarAnimal")]
    public async Task<IActionResult> Save([FromBody] AnimalDTO animalDto)
    {
        if (animalDto == null)
            return NotFound();

        var animal = animalService.Mapper(animalDto);

        return await ExecuteAsync(() => animalService.Add<AnimalValidator>(animal));
    }

    [HttpPut]
    [Route("AtualizarAnimal")]
    public async Task<IActionResult> Update([FromBody] Animal animal)
    {
        if (animal == null)
            return NotFound();

        return await ExecuteAsync(() => animalService.Update<AnimalValidator>(animal));
    }

    [HttpDelete]
    [Route("ExcluirAnimal")]
    public async Task Delete(int id)
    {
        await animalService.Delete(id);
    }

    private async Task<IActionResult> ExecuteAsync(Func<Task<Animal>> func)
    {
        try
        {
            var result = await func();

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    private IActionResult Execute(Func<Animal> func)
    {
        try
        {
            var result = func();

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}
