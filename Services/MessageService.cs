using MessageProject.Data;
using MessageProject.Models;

namespace MessageProject.Services;
public class MessageService
{

    private readonly ApplicationDbContext _context;
    
    public MessageService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<MessageModel> GetMessages()
    {
        return _context.Messages.ToList();
    }

    public void AddMessage(MessageModel message)
    {
        _context.Messages.Add(message);
        _context.SaveChanges();
    }
}
