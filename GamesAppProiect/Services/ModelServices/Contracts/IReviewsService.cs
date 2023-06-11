using DTO;

namespace Services.ModelServices.Contracts
{
    public interface IReviewsService
    {
        Task<bool> DeleteAsync(ReviewsDTO value);
        Task<List<ReviewsDTO>> GetAllAsync();
        Task<ReviewsDTO> InsertAsync(ReviewsDTO value);
        Task<ReviewsDTO> UpdateAsync(ReviewsDTO value);
    }
}