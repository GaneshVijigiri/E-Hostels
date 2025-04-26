using EHostels.Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EHostels.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetDetails()
        {
            LoginUser user = new LoginUser();
            user.Email = User.FindFirstValue(ClaimTypes.Email);

            return Ok(user.Email);
        }
    }
}
