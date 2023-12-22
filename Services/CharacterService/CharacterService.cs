
using DOTNET_RPG.Models;

namespace DOTNET_RPG.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> Characters = new List<Character> {
            new Character(),
            new Character {Id = 1, Name = "Fobe" }

        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newChar)
        {   
            var serviceResponse = new ServiceResponse<List<Character>>();
            Characters.Add(newChar);
            serviceResponse.Data = Characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = Characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            var character = Characters.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = character;
            return serviceResponse;
        }
    }
}
