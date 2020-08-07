﻿using Common.Repository;
using Inventory.Data.Entities;
using Inventory.Repositories.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Repositories.Repositories
{
    public class ThingRepository : Repository<Thing>, IThingRepository
    {
        public ThingRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Thing>> GetWithCategoriesAndCurrencies()
        {
            return await DbSet
                .Where(t => t.Deleted == false)
                .Include(t => t.Currency)
                .Include(t => t.Category)
                .ToListAsync();
        }
    }
}