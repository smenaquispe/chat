using MessageProject.Models;
using MessageProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace MessageProject.Controllers;

[ApiController]
[Route("[controller]")]
public class ChatController : ControllerBase
{
    private readonly ChatService _chatService;

    public ChatController(ChatService chatService)
    {
        _chatService = chatService;
    }

    [HttpGet]
    public IActionResult GetChats()
    {
        return Ok(_chatService.GetChats());
    }

    [HttpPost]
    public IActionResult PostChat([FromBody] ChatModel chat)
    {
        if(string.IsNullOrEmpty(chat.Name))
            return BadRequest("Chat Name is required.");

        if(chat.Users.Count < 2)
            return BadRequest("Chat must have at least 2 users.");

        _chatService.AddChat(chat);
        return CreatedAtAction(nameof(GetChats), new {id = chat.Id}, chat);
    }
}