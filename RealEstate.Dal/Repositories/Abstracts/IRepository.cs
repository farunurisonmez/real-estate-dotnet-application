﻿using RealEstate.Entities.Interfaces;
using System.Linq.Expressions;


namespace RealEstate.Dal.Repositories.Abstracts
{
    public interface IRepository<T> where T : class,IEntity
    {
        //Raporlama yapacak komutlarımız.
        IQueryable<T> GetAll();
        IQueryable<T> GetActives();
        IQueryable<T> GetModifieds();
        IQueryable<T> GetPassives();

        //Veritabanında değişiklik yapacak komutlarımız.
        void Add(T item);

   
        Task AddAsync(T item); 
        void AddRange(List<T> list);
        Task AddRangeAsync(List<T> list);
        Task Update(T item);
        Task UpdateRange(List<T> list);
        void Delete(T item);
        void DeleteRange(List<T> list);
        void Destroy(T item);
        void DestroyRange(List<T> list);

        //Linq Commands
        IQueryable<T> Where(Expression<Func<T,bool>> exp);
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp);
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);

        //Find
        Task<T> FindAsync(int id);


    }
}
