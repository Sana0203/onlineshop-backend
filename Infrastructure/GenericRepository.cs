using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopBackend.DB;
using OnlineShopBackend.Entities;
using OnlineShopBackend.Interfaces;

namespace OnlineShopBackend.Infrastructure
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private readonly MyOnlineShopDB _db;
        public GenericRepository(MyOnlineShopDB db)
        {
            _db = db;
        } 

        public async Task<T> AddAsync(T entity)
        {
            await _db.AddAsync(entity);
            return entity;
        }
        public async Task<IEnumerable<T>> GetAllAsync(params string[] includes){
            
            var query = _db.Set<T>().AsQueryable();
            foreach (var item in includes)
            {
                query=query.Include(item);
            }
            await Task.Delay(500);
            return await query.ToListAsync();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async void Remove(int id)
        {
            var entry = await GetAsync(id);
            if (entry != null)
            {
                _db.Remove(entry);
            }
        }

        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
        }
    }
}