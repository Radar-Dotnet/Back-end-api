using projeto_radar_backend.DTOs;
using projeto_radar_backend.ModelViews;
using projeto_radar_backend.Services;
using projeto_radar_backend.Services.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using projeto_radar_backend.Database;
using Microsoft.EntityFrameworkCore;

namespace projeto_radar_backend.Controllers
{
	public class LoginController : ControllerBase
	{
    private readonly DbRadarContext _context;

    public LoginController(DbRadarContext context)
    {
      _context = context;
    }

    [HttpPost("api/login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] UserDTO userDTO)
		{
			if (string.IsNullOrEmpty(userDTO.Email) || string.IsNullOrEmpty(userDTO.Senha))
				return StatusCode(400, new { Message = "Preencha o email e a senha"});

      var user = await _context.Users.Where(u => u.Email == userDTO.Email && u.Senha == userDTO.Senha).FirstOrDefaultAsync();

			if (user is null) return StatusCode(404, new { Message = "Usuário não encontrado" });

			var loggedInUser = DTOBuilder<LoggedInUser>.Builder(user);
			loggedInUser.Token = TokenJWT.Builder(loggedInUser);

      return StatusCode(201, loggedInUser);
    }
	}
}
