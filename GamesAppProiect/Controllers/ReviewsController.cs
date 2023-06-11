using DTO;
using Microsoft.AspNetCore.Mvc;
using Services.ModelServices.Contracts;

namespace reviewsAppProiect.Controllers
{
    public class ReviewsController : Controller
    {
        #region Constructor
        private readonly IReviewsService reviewsService;
        public ReviewsController(IReviewsService reviewsService)
        {
            reviewsService = reviewsService;
        }
        #endregion

        #region Crud  
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await reviewsService.GetAllAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] ReviewsDTO reviews)
        {
            try
            {
                return Ok(await reviewsService.InsertAsync(reviews));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] ReviewsDTO reviews)
        {
            try
            {
                return Ok(await reviewsService.UpdateAsync(reviews));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                return Ok(await reviewsService.DeleteAsync(new ReviewsDTO { Id = id }));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
    }
}
