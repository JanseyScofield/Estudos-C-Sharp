using System;
using IWantApp.Infra.Data;
using IWantApp.Domain.Products;
using System.CodeDom.Compiler;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Collections.Generic;

namespace IWantApp.EndPoints.Employees {
    static class EmployeePost {

        public static string Template => "/employees";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;

        public static async Task<IResult> Action(EmployeeRequest employeeRequest, UserManager<IdentityUser> userManager) {

            var user = new IdentityUser { UserName = employeeRequest.Email, Email = employeeRequest.Email };
            var result = await userManager.CreateAsync(user, employeeRequest.Password);

            if(!result.Succeeded) {
                return Results.ValidationProblem(result.Errors.ConvertToProblemDetails());
            }

            var userClaims = new List<Claim> {
                new Claim("EmployeeCode", employeeRequest.EmployeeCode),
                new Claim("EmployeeCode", employeeRequest.Name)
            };

            var claimResult = await userManager.AddClaimsAsync(user, userClaims);

            if (!claimResult.Succeeded) {
                return Results.BadRequest(result.Errors.First());
            }

            return Results.Created($"/employees/{user.Id}", user.Id);
        }
    }

}