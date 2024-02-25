using MessageProject.Data;
using MessageProject.Models;

namespace MessageProject.Services;

public class ChatService
{
    private readonly ApplicationDbContext _context;

    public ChatService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<ChatModel> GetChats()
    {
        return _context.Chats.ToList();
    }

    public void AddChat(ChatModel chat)
    {
        _context.Chats.Add(chat);
        _context.SaveChanges();
    }
}