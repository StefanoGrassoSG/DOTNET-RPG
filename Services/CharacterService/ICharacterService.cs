namespace DOTNET_RPG.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAll();

        Task<ServiceResponse<Character>> GetById(int id);

        Task<ServiceResponse<List<Character>>> AddCharacter(Character newChar);
    }
}
