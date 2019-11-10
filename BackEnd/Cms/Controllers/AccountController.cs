using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Model.Credential;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Cms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        readonly UserManager<IdentityUser> userManager;
        readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] Credential credential)
        {
            var user = new IdentityUser { UserName = credential.Email, Email = credential.Email };
            var result = await userManager.CreateAsync(user, credential.Password);
            if (!result.Succeeded) 
                return BadRequest(result.Errors);
            await signInManager.SignInAsync(user, isPersistent: false);
            var SigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this is the secret phrase"));   
            var signingCredentials = new SigningCredentials(SigningKey, SecurityAlgorithms.HmacSha256);

            var jwt = new JwtSecurityToken(signingCredentials: signingCredentials);
            var ok = Ok(new JwtSecurityTokenHandler().WriteToken(jwt));
            return ok   ;
        }
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{ 
        //    return new string[] { "vv", "ss" };
        //}
    }
}