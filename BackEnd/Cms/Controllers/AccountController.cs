using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Entity.Model.Credential;
using Entity.Model.Token;
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
        public async Task<ActionResult<Token>> Register([FromBody] Credential credential)
        {
            var user = new IdentityUser { UserName = credential.Email, Email = credential.Email };
            var result = await userManager.CreateAsync(user, credential.Password);
            if (!result.Succeeded) 
                return BadRequest(result.Errors);
            await signInManager.SignInAsync(user, isPersistent: false);

            return CreateToken(user);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<Token>> Login([FromBody] Credential credential)
        {
            var result = await signInManager.PasswordSignInAsync(credential.Email, credential.Password,false,false);
            if (!result.Succeeded)
                return BadRequest();
            var user = await userManager.FindByEmailAsync(credential.Email);

            return CreateToken(user);
        }

        Token CreateToken(IdentityUser user)
        {
            var claim = new Claim[]
               {
                    new Claim(JwtRegisteredClaimNames.Sub, user.Id), new Claim(JwtRegisteredClaimNames.NameId,user.UserName)
               };

            var SigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this is the secret phrase"));
            var signingCredentials = new SigningCredentials(SigningKey, SecurityAlgorithms.HmacSha256);

            Token Token = new Token();
            var jwt = new JwtSecurityToken(signingCredentials: signingCredentials, claims: claim);
            Token.token = Ok(new JwtSecurityTokenHandler().WriteToken(jwt)).Value.ToString();
            return Token;
        }
        
    }
}