using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.ModelServices;
using Services.ModelServices.Contracts;

namespace GamesAppProiect.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        #region Constructor
        private readonly IAccountsService _accountService;
        public AccountsController(IAccountsService accountService)
        {
            _accountService = accountService;
        }
        #endregion

        #region Crud 

        [HttpGet("GetAll")]

        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _accountService.GetAllAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] AccountsDTO profile)
        {
            try
            {
                return Ok(await _accountService.InsertAsync(profile));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] AccountsDTO profile)
        {
            try
            {
                return Ok(await _accountService.UpdateAsync(profile));
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
                return Ok(await _accountService.DeleteAsync(new AccountsDTO { Id = id }));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion 

        [HttpGet("Username/{username}")]
        public async Task<IActionResult> GetSearchByUsername(string username)
        {
            try
            {
                var person = await _accountService.GetAccount(username);
                return Ok(person);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSearchById(int id)
        {
            try
            {
                var person = await _accountService.SearchByIdAsync(id);
                return Ok(person);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
