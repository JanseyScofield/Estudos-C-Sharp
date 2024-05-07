using System;
using IWantApp.Infra.Data;
using IWantApp.Domain.Products;

using System.CodeDom.Compiler;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace IWantApp.EndPoints.Categories {
    static class ProductPost {

        public static string Template => "/categories";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;

        public static async Task<IResult> Action(ProductRequest categoryRequest,HttpContext http, ApplicationDbContext context) {

            var userId = http.User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var category = new Category(categoryRequest.Name, userId, userId);

            if(!category.IsValid) {

                return Results.ValidationProblem(category.Notifications.ConvertToProblemDetails());
            }

            await context.Category.AddAsync(category);
            await context.SaveChangesAsync();
            
            return Results.Created($"/categories/{category.Id}", category.Id);
        }
    }

}