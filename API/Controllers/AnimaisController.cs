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
public class AnimaisController : ControllerBase
{
    private readonly AnimalService animalService;

    public AnimaisController(AnimalService animalService)
    {
        this.animalService = animalService;
    }

    [HttpGet]
    [Route("BuscarAnimalPorId")]
    public async Task<Animal> GetByIdAsync(int id)
    {
        return await this.animalService.GetByIdAsync(id);
    }

    [HttpGet]
    [Route("BuscarAnimais")]
    public ListResponseResult<Animal> GetAll(int pageSize = 10, int pageIndex = 1)
    {
        return this.animalService.GetAll(pageSize, pageIndex);
    }

    [HttpPost]
    [Route("SalvarAnimal")]
    public async Task<Animal> Save([FromBody] AnimalDTO animal)
    {
        return await animalService.Save(animal);
    }

    [HttpPut]
    [Route("AtualizarAnimal")]
    public async Task<Animal> Update([FromBody] AnimalDTO animal)
    {
        return await animalService.Save(animal);
    }

    [HttpDelete]
    [Route("ExcluirAnimal")]
    public async Task Delete(int id)
    {
        await animalService.Delete(id);
    }
}
