using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Core.Extensions;
using Entities.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.JWT
{
    public class TokenHandler : ITokenHandler
    {
        IConfiguration _configuration;

        public TokenHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Token CreateToken(AdminUser adminUser, List<AdminRole> adminRoles)
        {
            Token token = new Token();

            //Security keyi nin simetriğini alalım
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]));

            //Şifrelenmiş kimlik oluştur
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            //Token ayarları
            token.DateExpire = DateTime.Now.AddMinutes(60);
            JwtSecurityToken securityToken = new JwtSecurityToken(
                issuer: _configuration["Token:Issuer"],
                audience: _configuration["Token:Audience"],
                expires: token.DateExpire,
                claims: SetClaims(adminUser: adminUser, adminRoles: adminRoles),//claims lere custom yapımızı ekledik
                notBefore: DateTime.Now,
                signingCredentials: signingCredentials
                );

            //Token oluşturu sınıfından bir örnek alalım
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

            //Token düzeltelim
            token.AccesToken = jwtSecurityTokenHandler.WriteToken(securityToken);

            //Refresh token üretelim  ValidateLifetime == true ise işimize yarayacak ama performans düşer
            token.RefreshToken = CreateRefreshToken();

            return token;
        }

        public string CreateRefreshToken()
        {
            byte[] number = new byte[32];
            using (RandomNumberGenerator random = RandomNumberGenerator.Create())
            {
                random.GetBytes(number);
                return Convert.ToBase64String(number);
            }
        }

        private IEnumerable<Claim> SetClaims(AdminUser adminUser, List<AdminRole> adminRoles)
        {
            var claims = new List<Claim>();
            claims.AddName(name: adminUser.Username);
            claims.AddRoles(roles: adminRoles.Select(p => p.Name).ToArray());
            return claims;
        }
    }
}

