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

namespace IWantApp.EndPoints.Security {
    static class TokenPost {

        public static string Template => "/token";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action(LoginRequest loginRequest, UserManager<IdentityUser> userManager) {

            var user = userManager.FindByEmailAsync(loginRequest.Email).Result;
            if (!userManager.CheckPasswordAsync(user, loginRequest.Password).Result)
                Results.BadRequest();

            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(new Claim[] new Claim { ClaimTypes.Email, loginRequest.Email),},)
            };
        }
    }

}