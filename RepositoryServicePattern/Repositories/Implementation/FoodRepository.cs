using Microsoft.EntityFrameworkCore;
using RepositoryServicePattern.Data.Context;
using RepositoryServicePattern.Data.Entities;
using RepositoryServicePattern.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryServicePattern.Repositories.Implementation
{
    public class FoodRepository : IFoodRepository
    {
        private readonly ApplicationContext dbContext;
        
        public FoodRepository(ApplicationContext context)
        {
            dbContext = context;
        }

        public async Task<FoodItem> Create(FoodItem food)
        {
            await dbContext.Foods.AddAsync(food);

            await dbContext.SaveChangesAsync();

            return food;
        }

        public async Task<FoodItem> Delete(FoodItem food)
        {
            dbContext.Foods.Remove(food);

            await dbContext.SaveChangesAsync();

            return food;
        }

        public async Task<List<FoodItem>> GetAll()
        {
            return await dbContext.Foods.ToListAsync();
        }

        public async Task<FoodItem> GetById(long id)
        {
            return await dbContext.Foods.FindAsync(id);
        }

        public async Task<FoodItem> Update(FoodItem food)
        {
            dbContext.Foods.Update(food);

            await dbContext.SaveChangesAsync();

            return food;
        }
    }
}
