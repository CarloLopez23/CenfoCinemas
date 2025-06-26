using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public ActionResult Create(UserController user)
        {
            try
            {
                var um = new UserManager();
                um.Create(user);
                return Ok(user);

            }
        }
    }
}
