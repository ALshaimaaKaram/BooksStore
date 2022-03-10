﻿using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public class ModelRepository<T> : IModelRepository<T> where T : BaseModel
    {
        DbContext context;
        DbSet<T> table;
        public ModelRepository(DbContext _context)
        {
            context = _context;
            table = context.Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            await table.AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return table;
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await table.FindAsync(Id);
        }

        public async Task<T> Remove(T entity)
        {
            table.Remove(entity);
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            table.Update(entity);
            return entity;
        }
    }
}
