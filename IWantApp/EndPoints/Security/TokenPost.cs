using System;
using IWantApp.Infra.Data;
using IWantApp.Domain.Products;
using System.CodeDom.Compiler;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Collections.Generic;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace IWantApp.EndPoints.Security {
    static class TokenPost {

        public static string Template => "/token";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;

        [AllowAnonymous]
        public static IResult Action(LoginRequest loginRequest, IConfiguration configuration, UserManager<IdentityUser> userManager, ILogger log) {

            log.LogInformation("Getting token");

            var user = userManager.FindByEmailAsync(loginRequest.Email).Result;
            if (!userManager.CheckPasswordAsync(user, loginRequest.Password).Result)
                Results.BadRequest();
            var claims = userManager.GetClaimsAsync(user).Result;
            var subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Email, loginRequest.Email),
                new Claim(ClaimTypes.NameIdentifier, user.Id),
            });
            subject.AddClaims(claims);

            var key = Encoding.ASCII.GetBytes(configuration["JwtBearerTokenSetting:SecretKey"]);
            var tokenDescriptor = new SecurityTokenDescriptor  // generate token
            {
                Subject = subject,
                SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Audience = configuration["JwtBearerTokenSetting:Audience"],
                Issuer = configuration["JwtBearerTokenSetting:Issuer"],
                Expires = DateTime.UtcNow.AddSeconds(30)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return Results.Ok(new {
                token = tokenHandler.WriteToken(token)
            });
        }
    }

}