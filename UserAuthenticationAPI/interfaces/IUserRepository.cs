using UserAuthenticationAPI.Models;

namespace UserAuthenticationAPI.interfaces
{
public interface IUserRepository
{
    User GetById(int id); 
    IEnumerable<User> GetAll();
    User GetByUsername(string username);
    void Add(User user);
    int SaveChanges();
}

}