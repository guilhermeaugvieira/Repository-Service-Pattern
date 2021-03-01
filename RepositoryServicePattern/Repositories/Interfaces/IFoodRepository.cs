using Microsoft.EntityFrameworkCore;
using RepositoryServicePattern.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryServicePattern.Repositories.Interfaces
{
    public interface IFoodRepository
    {
        public Task<FoodItem> Create(FoodItem food);

        public Task<FoodItem> Delete(FoodItem food);

        public Task<List<FoodItem>> GetAll();

        public Task<FoodItem> GetById(long id);

        public Task<FoodItem> Update(FoodItem food);
    }
}
