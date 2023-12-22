using DOTNET_RPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_RPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        private static List<Character> Characters = new List<Character> {
            new Character(),
            new Character {Id = 1, Name = "Fobe" }
            
        };

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(Characters);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(Characters.FirstOrDefault(c => c.Id == id));
        }
    }
}
