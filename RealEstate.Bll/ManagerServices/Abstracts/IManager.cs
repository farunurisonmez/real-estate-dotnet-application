using RealEstate.Entities.Interfaces;
using System.Linq.Expressions;

namespace RealEstate.Bll.ManagerServices.Abstracts
{
    //Raporlama işlemleri ve değişiklik işlemleri için kullanılacak metotlar
    public interface IManager<T> where T:class,IEntity
    {
        /// <summary>
        /// Veritabanındaki tüm verileri getirir.
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Aktif olan verileri getirir.
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetActives();

        /// <summary>
        /// Güncellenen verileri getirir.
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetModifieds(); 

        /// <summary>
        /// Pasif olanları getirir.
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetPassives();

        /// <summary>
        /// Veritabanına veri ekler.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        string Add(T item);
        
        /// <summary>
        /// Veritabanına asenkron olarak veri ekler.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task AddAsync(T item);

        /// <summary>
        /// Veritabanına list tipinde veri ekler.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        Task AddRangeAsync(List<T> list);

        /// <summary>
        /// Veritabanında veri güncelleme işlemi yapar.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task Update(T item);

        /// <summary>
        /// Çoklu veri güncelleme işlemi
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        Task UpdateRange(List<T> list);

        /// <summary>
        /// Veri disable etme işlemi
        /// </summary>
        /// <param name="item"></param>
        void Delete(T item);

        /// <summary>
        /// Çoklu veri disable etme işlemi
        /// </summary>
        /// <param name="list"></param>
        void DeleteRange(List<T> list); //Çoklu veri disable etme işlemi
        void Destroy(T item);  //Veri silme işlemi
        void DestroyRange(List<T> list); //Çoklu veri silme işlemi

        /// <summary>
        /// Veriye göre filtreleme işlemi yapar. LinQ sorgusu ile çalışır.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        IQueryable<T> Where(Expression<Func<T, bool>> exp);

        /// <summary>
        /// Veritabanında veri var mı yok mu kontrolü yapar.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp);

        /// <summary>
        /// İlk veriyi getirme işlemi
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp);

        /// <summary>
        /// Veri seçme işlemi
        /// </summary>
        /// <typeparam name="X"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);

        /// <summary>
        /// Veri bulma işlemi
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> FindAsync(int id);
    }
}
