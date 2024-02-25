using MessageProject.Data;
using MessageProject.Models;

namespace MessageProject.Services;

public class UserService
{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<UserModel> GetUsers()
    {
        return _context.Users.ToList();
    }

    public void AddUser(UserModel user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }
}