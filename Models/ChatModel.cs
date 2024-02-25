namespace MessageProject.Models;

public class ChatModel
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public List<MessageModel> Messages { get; set; } = new();
    public List<UserModel> Users { get; set; } = new();

    public ChatModel()
    {
        Id = Guid.NewGuid();
    }
}