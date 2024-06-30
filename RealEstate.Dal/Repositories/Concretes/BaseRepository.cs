using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RealEstate.Dal.Repositories.Abstract;
using RealEstate.Entities.Interfaces;

namespace RealEstate.Dal.Repositories.Concretes {

    // BaseRepository IRepository interfaceinden kalıtım alır ve bu interface'deki metotları implemente eder.
    // T tipinde bir generic yapı oluşturduk ve bu yapı IEntity interface'inden kalıtım almalıdır.
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        DbContext _dbContext;

        //Constructor metodu ile DbContext tipinde bir parametre alır ve bu parametreyi _context değişkenine atar.
        public BaseRepository(DbContext context)
        {
            _dbContext = context;
        }
        public async Task AddAsync(T item)
        {
            await _dbContext.Set<T>().AddAsync(item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddRangeAsync(List<T> list)
        {
            await _dbContext.Set<T>().AddRangeAsync(list);
            await _dbContext.SaveChangesAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> exp)
        {
            return _dbContext.Set<T>().AnyAsync(exp);
        }

        //<summary>
        //Bu metot veriyi pasif hale getirir.
        //</summary>
        public void Delete(T item)
        {
            item.Status = Entities.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            _dbContext.SaveChanges();
        }

        public void DeleteRange(List<T> list)
        {
            foreach (T item in list) Delete(item);
        }

        public void Destroy(T item)
        {
            _dbContext.Set<T>().Remove(item);
            _dbContext.SaveChanges();
        }

        public async Task<T> FindAsync(int id)
        {
           return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
           return await _dbContext.Set<T>().FirstOrDefaultAsync(exp);
        }

        //<summary>
        //Bu metot aktif olan verileri getirir.
        //</summary>
        public IQueryable<T> GetActives()
        {
            return Where(x => x.Status != Entities.Enums.DataStatus.Deleted); 
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().AsQueryable();
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
            return _dbContext.Set<T>().Select(exp);
        }

        public async Task UpdateAsync(T item)
        {
            item.Status = Entities.Enums.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            T original = await FindAsync(item.Id);
            _dbContext.Entry(original).CurrentValues.SetValues(item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(List<T> list)
        {
            foreach (T item in list) await UpdateAsync(item);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> exp)
        {
            return _dbContext.Set<T>().Where(exp);
        }
    }
}
