using RepositoryServicePattern.Data.Entities;
using RepositoryServicePattern.Repositories.Interfaces;
using RepositoryServicePattern.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryServicePattern.Services.Implementation
{
    public class FoodService : IFoodService
    {
        public readonly IFoodRepository _repository;
        
        public FoodService(IFoodRepository repository)
        {
            _repository = repository;
        }
        
        public async Task<FoodItem> Create(FoodItem food)
        {
            return await _repository.Create(food);
        }

        public async Task<FoodItem> Delete(long id)
        {
            var food = await _repository.GetById(id);
            
            return await _repository.Delete(food);
        }

        public async Task<List<FoodItem>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<FoodItem> GetById(long id)
        {
            return await _repository.GetById(id);
        }

        public async Task Update(long id ,FoodItem food)
        {
            food.ID = id;

            await _repository.Update(food);
        }
    }
}
