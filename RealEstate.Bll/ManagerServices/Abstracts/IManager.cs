using RealEstate.Entities.Interfaces;
using RealEstate.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Bll.ManagerServices.Abstracts
{
    //Raporlama işlemleri ve değişiklik işlemleri için kullanılacak metotlar
    public interface IManager<T> where T:class,IEntity
    {
        //List Commands
        IQueryable<T> GetAll(); //Raporlama işlemleri ve değişiklik işlemleri için kullanılacak metotlar
        IQueryable<T> GetActives(); //Aktif olanları getirir.
        IQueryable<T> GetModifieds(); //Güncellenenleri getirir.
        IQueryable<T> GetPassives(); //Pasif olanları getirir.
      
       /*
        * Task geriye değer döndürmeyen async metotlar için kullanılır. 
        * Task<T> ise geriye değer döndüren async metotlar için kullanılır.
        */
        string Add(T item);
        
        Task AddAsync(T item);  //Veri ekleme işlemi
        Task AddRangeAsync(List<T> list); //Çoklu veri ekleme işlemi
        Task Update(T item);  //Çoklu veri güncelleme işlemi
        Task UpdateRange(List<T> list); //Çoklu veri güncelleme işlemi
        void Delete(T item); //Veri disable etme işlemi
        void DeleteRange(List<T> list); //Çoklu veri disable etme işlemi
        void Destroy(T item);  //Veri silme işlemi
        void DestroyRange(List<T> list); //Çoklu veri silme işlemi

        //Linq Commands
        IQueryable<T> Where(Expression<Func<T, bool>> exp); //Veriye göre filtreleme işlemi
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp); //Veri var mı yok mu kontrolü
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp); //İlk veriyi getirme işlemi
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp); //Veri seçme işlemi

        //Find
        Task<T> FindAsync(int id); //Id'ye göre veri getirme işlemi
    }
}
