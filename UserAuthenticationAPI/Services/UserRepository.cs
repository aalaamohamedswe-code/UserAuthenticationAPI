using UserAuthenticationAPI.interfaces;
using UserAuthenticationAPI.Models;

public class UserRepository : IUserRepository 
{
    private readonly ApplicationDbContext _context;
    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public void Add(User user)
    {
        _context.Users.Add(user);
    }
    public IEnumerable<User> GetAll()
    {
        return _context.Users.ToList();
    }
    public User GetById(int id)
    {
        return _context.Users.Find(id);
    }
    public User GetByUsername(string username)
    {
        return _context.Users.FirstOrDefault(u => u.Username == username);
    }
    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}