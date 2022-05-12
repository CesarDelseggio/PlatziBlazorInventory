using Business.Interfaces;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class Services<T> : IServices<T> where T : EntityBase
    {
        public virtual List<T> GetAll()
        {
            using (var db = new InventoryContext())
            {
                return db.Set<T>().ToList();
            }
        }

        public virtual T GetById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.Set<T>().FirstOrDefault(x => x.Id == id);
            }
        }

        public virtual async void Add(T entity)
        {
            using (var db = new InventoryContext())
            {
                db.Add(entity);
                await db.SaveChangesAsync();
            }
        }

        public virtual async void Update(T entity)
        {
            using (var db = new InventoryContext())
            {
                db.Update(entity);
                await db.SaveChangesAsync();
            }
        }

        public virtual async void Delete(T entity)
        {
            using (var db = new InventoryContext())
            {
                db.Remove(entity);
                await db.SaveChangesAsync();
            }
        } 
        
        public virtual bool Exist(string id)
        {
            using(var db = new InventoryContext())
            {
                return db.Set<T>().Count(x=> x.Id == id) > 0;
            }
        }

        public virtual bool Exist(T entity)
        {
            using (var db = new InventoryContext())
            {
                return db.Set<T>().Count(x => x.Id == entity.Id) > 0;
            }
        }
    }
}
