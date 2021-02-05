using Async_Inn.Models;
using Async_Inn.Models.Api;
using Async_Inn.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService service)
        {
            userService = service;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterUser data)
        {
            var user = await userService.Register(data, this.ModelState);

            if (ModelState.IsValid)
            {
                return user;
            }

            return BadRequest(new ValidationProblemDetails(ModelState));
        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserDTO>> Login(LoginData data)
        {
            var user = await userService.Authenticate(data.Username, data.Password);
            if (user != null)
            {
                return user;
            }
            return Unauthorized();
        }

        [Authorize]
        [HttpGet("me")]
        public async Task<ActionResult<UserDTO>> Me()
        {
            // Following the [Authorize] phase, this.User will be ... you.
            // Put a breakpoint here and inspect to see what's passed to our getUser method
            return await userService.GetUser(this.User);
        }
    }
}