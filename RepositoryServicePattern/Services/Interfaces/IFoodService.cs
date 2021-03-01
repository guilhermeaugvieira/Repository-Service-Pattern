using RepositoryServicePattern.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryServicePattern.Services.Interfaces
{
    public interface IFoodService
    {
        public Task<List<FoodItem>> GetAll();

        public Task<FoodItem> GetById(long id);

        public Task Update(long id, FoodItem food);

        public Task<FoodItem> Create(FoodItem food);

        public Task<FoodItem> Delete(long id);
    }
}
