using apiCharlsShoes.Data;
using CharlsShoes.BLL;
using CharlsShoes.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiCharlsShoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  
    public class AuthController : ControllerBase
    {
        //{"username": "jasi",
        //"password": "Welcomen@1234"}
        //{"username": "superAdmin",

        //"password": "Welcomen@1234"}

    private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;

        public AuthController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
        }

        private UsuarioOperations usuarioOperations = UsuarioOperations.Instance();

        [Authorize (Roles ="Admin")]
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {

            var userExist = await userManager.FindByNameAsync(model.userName);

            if (userExist != null)

                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                {
                    Message = "El usuario ya existe",
                    Status = false
                });

            ApplicationUser user = new ApplicationUser()
            {   
                Email = model.email,
                
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.userName,

            };
            var result = await userManager.CreateAsync(user, model.password);
            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                {
                    Message = "Error al crear usuario"+ result.Errors.Select(x => "Código " + x.Code + " Descripción" + x.Description),
                    Status = false
                });
            }

            return Ok(new Response { Status = true, Message = "Usuario Creado" });

        }
        [Authorize (Roles ="Admin")]
        [HttpPost]
        [Route("RegisterAdmin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        {

            var userExist = await userManager.FindByNameAsync(model.userName);

            if (userExist != null)

                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                {
                    Message = "El usuario ya existe",
                    Status = false
                });

            ApplicationUser user = new ApplicationUser()
            {
                Email = model.email,

                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.userName,

            };
            var result = await userManager.CreateAsync(user, model.password);
            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                {
                    Message = "Error al crear usuario" + result.Errors.Select(x => "Código " + x.Code + " Descripción" + x.Description),
                    Status = false
                });
            }

            if (!await roleManager.RoleExistsAsync("Admin"))
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            if (!await roleManager.RoleExistsAsync("User"))
                await roleManager.CreateAsync(new IdentityRole("User"));


            if (await roleManager.RoleExistsAsync("Admin"))
            {
                await userManager.AddToRoleAsync(user, "Admin");
            }
            return Ok(new Response { Status = true, Message = "Usuario Creado" });

        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model) { 
        
        var user = await userManager.FindByNameAsync(model.userName);
        if(user!=null && await userManager.CheckPasswordAsync(user, model.password))
            {

                var userRoles = await userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
                {

                    new Claim(ClaimTypes.Name,user.UserName),
                      new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                };

                foreach(var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }


                var signingkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
                var token = new JwtSecurityToken(
                issuer : _configuration["JWT:ValidIssuer"],
                audience : _configuration["JWT:ValidAudience"],
                  
              expires: DateTime.Now.AddHours(3),
              claims: authClaims,
              signingCredentials: new SigningCredentials(signingkey, SecurityAlgorithms.HmacSha256));

                return Ok(new
                {   message ="Acceso exitoso",
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    status= true

                });

                
            }
            return Unauthorized();
        }



       /*
        public IActionResult Index([FromBody] Usuario model)
        {
            if (

                 usuarioOperations.Login(model) != null

                )
            {
                var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub,model.usuario),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                };
                var signingkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySuperSecureKey"));
                var token = new JwtSecurityToken(
                     issuer: "voidgeeks.com",
                     audience: "voidgeeks.com",
                     expires: DateTime.UtcNow.AddHours(1),
                     claims: claims,
                     signingCredentials: new Microsoft.IdentityModel.Tokens.SigningCredentials(signingkey, SecurityAlgorithms.HmacSha256));
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            };
            return Unauthorized();



            /*
            // GET: api/<AuthController>
            [HttpGet]
            public IEnumerable<string> Get()
            {
                return new string[] { "value1", "value2" };
            }

            // GET api/<AuthController>/5
            [HttpGet("{id}")]
            public string Get(int id)
            {
                return "value";
            }

            // POST api/<AuthController>
            [HttpPost]
            public void Post([FromBody] string value)
            {
            }

            // PUT api/<AuthController>/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE api/<AuthController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }
        }
   */
    }
}
