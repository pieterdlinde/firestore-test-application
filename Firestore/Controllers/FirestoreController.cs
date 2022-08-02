using Firestore.Models;
using Firestore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Firestore.Controllers;
[ApiController]
[Route("[controller]")]
public class FirestoreController : ControllerBase
{ 
    private readonly ILogger<FirestoreController> _logger;
    // This should be injected - This is only an example
    private readonly UserRepository _userRepository = new ();

    public FirestoreController(ILogger<FirestoreController> logger)
    {
        _logger = logger; 
    }

    [HttpGet]
    public async Task<ActionResult<List<User>>> GetAllUsersAsync()
    {
        return Ok(await _userRepository.GetAllAsync());
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<User>> GetUserAsync(string id)
    {
        var user = new User()
        {
            Id = id
        };

        return Ok(await _userRepository.GetAsync(user));
    }

    [HttpPost]
    [Route("{id}")]
    public async Task<ActionResult<User>> UpdateUserAsync(string id, User user)
    {
        if (id != user.Id)
        {
            return BadRequest("Id must match.");
        }

        return Ok(await _userRepository.UpdateAsync(user));
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<ActionResult> DeleteUserAsync(string id, User user)
    {
        if (id != user.Id)
        {
            return BadRequest("Id must match.");
        }

        await _userRepository.DeleteAsync(user);

        return Ok();
    }


    [HttpPut] 
    public async Task<ActionResult<User>> DeleteUserAsync(User user)
    {  
        return Ok(await _userRepository.AddAsync(user));
    }

    [HttpGet]
    [Route("city/{city}")]
    public async Task<ActionResult<User>> GetUserWhereCity(string city)
    {  
        return Ok(await _userRepository.GetUserWhereCity(city));
    }

}
