using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers

{
    [ApiController]
    [Route("api/[controller]")] // Get/api/users 
    public class UsersController : ControllerBase
    {
        private readonly DataContex _contex;
        public UsersController(DataContex contex)
        {
            _contex = contex;
        }
        [HttpGet]
        public async Task< ActionResult<IEnumerable<AppUser>>> GetUser()
        {
            var users = _contex.Users.ToList();
            return users;

        }

        [HttpGet("{id}")]

        public async Task< ActionResult<AppUser>> GetUser(int id)
        {
            return await _contex.Users.FindAsync(id);
        }

        
    }
}