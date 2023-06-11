using DTO;

namespace Services.ModelServices.Contracts
{
    public interface IGamesServices
    {
        Task<bool> DeleteAsync(GamesDTO value);
        Task<List<GamesDTO>> GetAllAsync();
        Task<GamesDTO> InsertAsync(GamesDTO value);
        Task<GamesDTO> UpdateAsync(GamesDTO value);
    }
}