using MessageProject.Models;
using MessageProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace MessageProject.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly MessageService _messageService;

    public MessageController(MessageService messageService)
    {
        _messageService = messageService;
    }

    [HttpGet]
    public IActionResult GetMessages()
    {
        return Ok(_messageService.GetMessages());
    }

    [HttpPost]
    public IActionResult PostMessage([FromBody] MessageModel message)
    {
        if(string.IsNullOrEmpty(message.Content) || string.IsNullOrEmpty(message.Sender))
            return BadRequest("Message Content and Sender are required.");

        _messageService.AddMessage(message);
        return CreatedAtAction(nameof(GetMessages), new {id = message.Id}, message);
    }
}
