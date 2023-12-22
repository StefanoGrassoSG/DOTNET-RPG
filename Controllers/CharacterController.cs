
using DOTNET_RPG.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_RPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {

        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService) 
        {
            _characterService = characterService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
        {
            return Ok(await _characterService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character character)
        {
            return Ok(await _characterService.AddCharacter(character));
        }
    }
}
