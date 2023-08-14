using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Web_DesesperanzaAPI.Models;
using Microsoft.IdentityModel.Tokens;

namespace Web_DesesperanzaAPI.Helpers
{
    public static class JWTHelpers
    {

        public static IEnumerable<Claim> GetClaims(this UserTokens userAccounts, Guid id)
        {
            List<Claim> claims = new List<Claim>()
            {
            new Claim("Id", userAccounts.Id.ToString()),
            new Claim(ClaimTypes.Name, userAccounts.Username),
            new Claim(ClaimTypes.Email, userAccounts.EmailId),
            new Claim(ClaimTypes.NameIdentifier, userAccounts.Id.ToString()),
            new Claim(ClaimTypes.Expiration, DateTime.UtcNow.AddDays(1).ToString("MMM ddd dd HH: mm:ss tt")),
            //El 1 significa que le suma un día a la hora actual.
            //Así, expira en 24 hs. Luego define con forma muy copada cómo se verá la hora            
            };
            //Luego crea nombres distintos para quienes usen la página.
            //Está bastante hardcodeado y usa el userName como base para distinguir:

            if (userAccounts.Username == "Admin")
            {
                claims.Add(new Claim(ClaimTypes.Role, "Administrator"));
            }
            else if (userAccounts.Username =="User 1")
            {
                claims.Add(new Claim(ClaimTypes.Role, "User"));
                claims.Add(new Claim("UserOnly", "User 1"));
            }
            return claims;
        }
        public static IEnumerable<Claim> GetClaims(this UserTokens userAccounts, out Guid Id)
        {
            Id = Guid.NewGuid();
            return GetClaims(userAccounts, Id);
        }

        public static UserTokens GenTokenKeys (UserTokens model, JwtSettings jwtSettings)
        {
            try
            {
                var userToken = new UserTokens();
                if (model == null)
                {
                    throw new ArgumentNullException(nameof(model));
                }

                //Genera clave secreta
                var key = System.Text.Encoding.ASCII.GetBytes(jwtSettings.IssuerSigningKey);
                Guid Id;

                //Expira en un día
                DateTime expireTime = DateTime.UtcNow.AddDays(1);

                //Validez del token
                userToken.Validity = expireTime.TimeOfDay;

                //Generar el token
                var JwToken = new JwtSecurityToken(
                    issuer: jwtSettings.ValidIssuer,
                    audience: jwtSettings.ValidAudience,
                    claims: GetClaims(model, out Id),
                    notBefore: new DateTimeOffset(DateTime.Now).DateTime,
                    expires: new DateTimeOffset(expireTime).DateTime,
                    signingCredentials: new SigningCredentials(
                        new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256));
                userToken.Token = new JwtSecurityTokenHandler().WriteToken(JwToken);
                userToken.Username = model.Username;
                userToken.Id = model.Id;
                userToken.GuidId = Id;
                return userToken;    
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating the JWT", ex);
            }
        }
    }
}
