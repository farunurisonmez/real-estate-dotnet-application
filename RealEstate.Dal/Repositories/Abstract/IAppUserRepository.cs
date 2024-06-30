using RealEstate.Entities.Models;

// Tamamı interfaceler üzerinden bir sistem kurmaya başladık ayrı ayrı repositoryler oluşturduk ve bu repositorylerin interface'lerini oluşturduk.
// 

namespace RealEstate.Dal.Repositories.Abstract {
    public interface IAppUserRepository:IRepository<AppUser> {
        
    }
}