using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopBackend.Entities;

namespace OnlineShopBackend.Interfaces
{
    public interface IRepository<T> where T:Entity
    //an interface that can be used onlu for classes implementing Entity 
    //which all have a primary key (Id)
    {
        Task<IEnumerable<T>>  GetAllAsync(params string[] includes);
        //for selecting * form the given relation

        Task<T?>  GetAsync(int id);
        //gets the tuple by primary key
        Task<T> AddAsync(T entity);
        //insert a new tuple to the relation
        void Update(T entity);
        //updates the vlues of the given entity in the relation
        void Remove(int id);
        //removes the given tuple
        Task SaveChangesAsync();
        //saves the changes on the relation
    }
}