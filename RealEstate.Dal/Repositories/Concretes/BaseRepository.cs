using Microsoft.EntityFrameworkCore;
using RealEstate.Dal.Context;
using RealEstate.Dal.Repositories.Abstracts;
using RealEstate.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Dal.Repositories.Concretes
{
    /// <summary>
    /// BaseRepository sınıfı IRepository arayüzünden türetilmiştir.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        CustomContext _db;

        /// <summary>
        /// Constructor injection
        /// </summary>
        /// <param name="db"></param>
        public BaseRepository(CustomContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Veritabanına veri ekler.
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            _db.SaveChanges();
        }

        /// <summary>
        /// Veritabanına asenkron olarak veri ekler.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task AddAsync(T item)
        {
            await _db.Set<T>().AddAsync(item);
            await _db.SaveChangesAsync();
        }

        /// <summary>
        /// Veritabanına list tipinde veri ekler.
        /// </summary>
        /// <param name="list"></param>
        public void AddRange(List<T> list)
        {
            _db.Set<T>().AddRange();
            _db.SaveChanges();
        }

        /// <summary>
        /// Veritabanına list tipinde veri ekler.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public async Task AddRangeAsync(List<T> list)
        {
            await _db.Set<T>().AddRangeAsync();
            await _db.SaveChangesAsync();
        }

        /// <summary>
        /// Verinin olup olmadıgını kontrol eder.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> exp)
        {
            return await _db.Set<T>().AnyAsync(exp);
        }

        /// <summary>
        /// Verinin pasife çekılmesı
        /// </summary>
        /// <param name="item"></param>
        public void Delete(T item)
        {
            item.Status = Entities.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            _db.SaveChanges();
        }

        public void DeleteRange(List<T> list)
        {
            foreach (T item in list) Delete(item);
        }

        public void Destroy(T item)
        {
            
            _db.Set<T>().Remove(item);
            _db.SaveChanges();
        }

        public void DestroyRange(List<T> list)
        {
            _db.Set<T>().RemoveRange(list);
            _db.SaveChanges();
        }

        public async Task<T> FindAsync(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            return await _db.Set<T>().FirstOrDefaultAsync(exp);
        }

        public IQueryable<T> GetActives()
        {
            return Where(x => x.Status != Entities.Enums.DataStatus.Deleted);  
        }

        public IQueryable<T> GetAll()
        {
            return _db.Set<T>().AsQueryable();
        }

        public IQueryable<T> GetModifieds()
        {
            return Where(x => x.Status == Entities.Enums.DataStatus.Updated);
        }

        public IQueryable<T> GetPassives()
        {
            return Where(x => x.Status == Entities.Enums.DataStatus.Deleted);
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _db.Set<T>().Select(exp);
        }

        /// <summary>
        /// Güncelleme işlemi yapar.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task Update(T item)
        {
            item.Status = Entities.Enums.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            T original =await FindAsync(item.Id);
            _db.Entry(original).CurrentValues.SetValues(item);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateRange(List<T> list)
        {
            foreach (T item in list) await Update(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public IQueryable<T> Where(Expression<Func<T, bool>> exp)
        {
           return _db.Set<T>().Where(exp);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void IRepository<T>.Add(T item)
        {
            _db.Set<T>().Add(item);
            _db.SaveChanges();
        }
    }
}
