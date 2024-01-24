using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Voyages.Data;
using Voyages.DTOs.Requests;
using Voyages.DTOs.Responses;
using Voyages.Interfaces;

namespace Voyages.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(UserManager<AppUser> userManager, IUserService userService, IMapper mapper)
        {
            _userManager = userManager;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(UserLoginRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user is null) return NotFound("User not found");

            var validatePassword = await _userManager.CheckPasswordAsync(user, request.Password);

            if (!validatePassword) return BadRequest("Wrong password");


            var roles = await _userManager.GetRolesAsync(user);
            var roleName = roles.FirstOrDefault();

            var token = _userService.GenerateToken(user, roleName);

            return Ok(new AuthResponse
            {
                User = _mapper.Map<UserResponse>(user),
                Token = token,
                Role = roleName
            });
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(CreateUserRequest request)
        {
            var userExist = await _userManager.FindByEmailAsync(request.Email);

            if (userExist is not null) return BadRequest("User exist");

            var user = _mapper.Map<AppUser>(request);

            var isCreated = await _userManager.CreateAsync(user, request.Password);

            if (!isCreated.Succeeded) return BadRequest("Something went wrong");

            await _userManager.AddToRoleAsync(user, "User");

            var token = _userService.GenerateToken(user, "User");

            return Ok(new AuthResponse
            {
                User = _mapper.Map<UserResponse>(user),
                Token = token,
                Role = "User"
            });
        }
    }
}
