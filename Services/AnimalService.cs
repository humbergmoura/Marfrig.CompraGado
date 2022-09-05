using Domain.Models;
using Infra.Repositories;
using Services.Base;
using Services.Dtos;
using Services.ViewModels.ResponseResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services;

public class AnimalService : ServiceBase
{
    private readonly AnimalRepository animalRepository;

    public AnimalService(AnimalRepository animalRepository)
    {
        this.animalRepository = animalRepository;
    }

    public async Task<Animal> GetByIdAsync(int Id)
    {
        try
        {
            return await this.animalRepository.GetByIdAsync(Id);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public ListResponseResult<Animal> GetAll(int pageSize = 10, int pageIndex = 1, string query = "")
    {
        try
        {
            IList<Animal> result;

            result = this.animalRepository.GetAll(pageIndex, pageSize);

            var totalCount = result.Count();
            if (result != null && totalCount > 0)
            {
                var data = result.Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(e => e.Id).ToList();

                return new ListResponseResult<Animal>
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
            return new ListResponseResult<Animal> { Data = null, Success = false, Pagination = null };
        }
        catch (Exception)
        {
            return new ListResponseResult<Animal> { Data = null, Success = false, Pagination = null };
        }
    }

    public async Task<Animal> Save(AnimalDTO animalDTO)
    {
        try
        {
            if (string.IsNullOrEmpty(animalDTO.Descricao))
            {
                this.AddErrorApplicationErrors("pecuaristaNullOrEmpty", "O nome está vazio.");
                return null;
            }

            var animal = new Animal(animalDTO.Id, animalDTO.Descricao, animalDTO.Preco, animalDTO.IdPecuarista, animalDTO.Quantidade);

            var result = await animalRepository.SaveOrUpdateAsync(animal);

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
            animalRepository.Delete(result);
        }
        return;
    }
}
