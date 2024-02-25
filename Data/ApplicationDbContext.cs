using MessageProject.Models;
using Microsoft.EntityFrameworkCore;

namespace MessageProject.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<MessageModel> Messages { get; set; } = default!;
    public DbSet<UserModel> Users { get; set; } = default!;
    public DbSet<ChatModel> Chats { get; set; } = default!;
}