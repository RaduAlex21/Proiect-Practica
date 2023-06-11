using DTO;
using Microsoft.AspNetCore.Mvc;
using Services.ModelServices.Contracts;

namespace GamesAppProiect.Controllers
{
    public class GamesController : Controller
    {
        #region Constructor
        private readonly IGamesServices gamesServices;
        public GamesController(IGamesServices gamesServices)
        {
            gamesServices = gamesServices;
        }
        #endregion

        #region Crud  
        [HttpGet("GetAll")] 
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await gamesServices.GetAllAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] GamesDTO games)
        {
            try
            {
                return Ok(await gamesServices.InsertAsync(games));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] GamesDTO games)
        {
            try
            {
                return Ok(await gamesServices.UpdateAsync(games));
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
                return Ok(await gamesServices.DeleteAsync(new GamesDTO { Id = id }));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
        #endregion  
    }
}
