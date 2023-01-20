using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using projeto_radar_backend.ModelViews;

namespace projeto_radar_backend.Services.Auth
{
  public class TokenJWT
  {
    public readonly static string Key = "Secret_radaR_API";
    public static string Builder(LoggedInUser loggedInUser)
    {
      var key = Encoding.ASCII.GetBytes(TokenJWT.Key);
      var tokenHandler = new JwtSecurityTokenHandler();
      var tokenDescriptor = new SecurityTokenDescriptor()
      {
        Subject = new ClaimsIdentity(new Claim[]{
                new Claim(ClaimTypes.Name, loggedInUser.Nome),
                new Claim(ClaimTypes.Role, loggedInUser.Nivel),
            }),
        Expires = DateTime.UtcNow.AddDays(2),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };
      var token = tokenHandler.CreateToken(tokenDescriptor);
      return tokenHandler.WriteToken(token);
    }
  }
}
