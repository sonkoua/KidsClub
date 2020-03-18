using System.Collections.Generic;
using System.Threading.Tasks;
using KidsClub.API.Models;

namespace KidsClub.API.Data
{
    public interface IKidsRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}