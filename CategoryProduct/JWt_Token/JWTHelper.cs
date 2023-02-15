
using CategoryProduct.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using Twilio.Http;
namespace CategoryProduct.JWT_Token
{
    public class JWTHelper
    {

        public static SymmetricSecurityKey _signinkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MbQeThWmZq4t7w!z"));
        public static string CreateJWTToken(LogInCredential userinfo)
        {
            var credentials = new SigningCredentials(_signinkey, SecurityAlgorithms.HmacSha256);
            var issuer = "https://localhost:44370/";
            var audiance = "https://localhost:44370/";
            var claims = new[] {

                new Claim(ClaimTypes.Name,userinfo.UserName),
                new Claim(ClaimTypes.Role,userinfo.Role)

             };

            var token = new JwtSecurityToken(
                    issuer,
                    audiance,
                    claims,
                    expires: DateTime.Now.AddMinutes(2),
                    signingCredentials: credentials
                    );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public static IPrincipal ValidatejwtToken(string token)
        {
            var h = new JwtSecurityTokenHandler();

            h.ValidateToken(token, new TokenValidationParameters()
            {
                ValidAlgorithms = new[] { SecurityAlgorithms.HmacSha256 },
                ValidateAudience = false,
                ValidateIssuer = false,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MbQeThWmZq4t7w!z")),
                ValidateIssuerSigningKey = true,
                ValidateLifetime = true
            }, out SecurityToken securityToken);
            JwtSecurityToken jwt = (JwtSecurityToken)securityToken; 
            var id = new ClaimsIdentity(jwt.Claims, "jwt", ClaimTypes.Name, ClaimTypes.Role);
            return new ClaimsPrincipal(id);
        }
        public static void AuthenticationRequest(string token)
        {
            try
            {
                var principal = ValidatejwtToken(token);
                HttpContext.Current.User = principal;
                Thread.CurrentPrincipal = principal;
            }
            catch { }
        }
    }
}
