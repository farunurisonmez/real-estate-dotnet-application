using System.Linq.Expressions;
using RealEstate.Entities.Interfaces;

namespace RealEstate.BLL.ManagerServices.Abstract
{
     public interface IManager<T> where T:class, IEntity{
         //Raporlama işlemleri ve değişiklik işlemleri için kullanılacak metotlar
        IQueryable<T> GetAll();
        //Neden list değil çünkü bütün verileri çekmek yerine sadece istenilen verileri çekmek daha performanslı olacaktır.

        IQueryable<T> GetActives(); //Aktif olanları getirir.

        IQueryable<T> GetModifieds(); //Güncellenenleri getirir.

        IQueryable<T> GetPassives(); //Pasif olanları getirir.

        /*
        * Task geriye değer döndürmeyen async metotlar için kullanılır. 
        * Task<T> ise geriye değer döndüren async metotlar için kullanılır.
        */

        Task AddAsync(T item); //Veri ekleme işlemi
        Task AddRangeAsync(List<T> list); //Çoklu veri ekleme işlemi
        Task UpdateAsync(T item); //Veri güncelleme işlemi
        Task UpdateRangeAsync(List<T> list); //Çoklu veri güncelleme işlemi
        void Delete (T item); //Veri disable etme işlemi
        void DeleteRange(List<T> list); //Çoklu veri disable etme işlemi
        void Destroy(T item); //Veri silme işlemi


        //LinQ sorguları için kullanılacak metotlar

        IQueryable<T> Where(Expression<Func<T, bool>> exp); //Veriye göre filtreleme işlemi
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp); //Veri var mı yok mu kontrolü

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp); //İlk veriyi getirme işlemi

        IQueryable<X> Select<X>(Expression<Func<T, X>> exp); //Veri seçme işlemi

        Task<T> FindAsync(int id); //Id'ye göre veri getirme işlemi
     }
}