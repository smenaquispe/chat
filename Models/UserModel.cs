namespace MessageProject.Models;

public class UserModel
{
    public Guid Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public List<ChatModel> Chats { get; set; } = new();

    public UserModel()
    {
        Id = Guid.NewGuid();
    }
}