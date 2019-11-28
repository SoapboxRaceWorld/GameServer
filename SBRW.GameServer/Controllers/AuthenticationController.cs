// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/27/2019 @ 10:45 PM.

using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SBRW.Data.Entities;
using SBRW.GameServer.Auth;

namespace SBRW.GameServer.Controllers
{
    [ApiController]
    [Route("auth")]
    [Produces(MediaTypeNames.Application.Json)]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;

        private readonly IMapper _mapper;

        public AuthenticationController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userIdentity = _mapper.Map<AppUser>(model);

            var result = await _userManager.CreateAsync(userIdentity, model.Password);

            if (!result.Succeeded) return new BadRequestObjectResult(result.Errors);

            return new OkObjectResult("Account created");
        }

        [HttpPost("login")]
        public async Task<IActionResult> LogIn([FromBody] LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok("you thought");
        }
    }
}