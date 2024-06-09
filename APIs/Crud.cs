using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopBackend.Entities;
using OnlineShopBackend.Interfaces;

namespace OnlineShopBackend.APIs
{
    public static class Crud
    {
        public static async void MapCrud<T>(this WebApplication app, string prefix, params string[] includes) where T : Entity{

            app.MapPost($"/{prefix}/list",async (IRepository<T> entities)=>{
                return await entities.GetAllAsync(includes);
            });

            app.MapPost($"/{prefix}/get/{{id}}", async (IRepository<T> entities, int id)=>{
                return await entities.GetAsync(id);
            });

            app.MapPost($"/{prefix}/add", async (IRepository<T> entities, T entity)=>{
                var result =  await entities.AddAsync(entity);
                await entities.SaveChangesAsync();
                return result;
            });

            app.MapPut($"/{prefix}/update", async (IRepository<T> entities, T entity)=>{
                entities.Update(entity);
                await entities.SaveChangesAsync();
                return Results.Ok();
            });

            app.MapDelete($"/{prefix}/remove/{{id}}", async (IRepository<T> entities,int id)=>{
                entities.Remove(id);
                await entities.SaveChangesAsync();
                return Results.Ok();
            });




        }
    }
}