using System;
using IWantApp.Infra.Data;
using IWantApp.Domain.Products;

using System.Security.Claims;

namespace IWantApp.EndPoints.Products
    {
    static class ProductPost {

        public static string Template => "/products";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;

        public static async Task<IResult> Action( ProductRequest productRequest,HttpContext http, ApplicationDbContext context) {

            var userId = http.User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var product = new Category(productRequest.Name, userId, userId);

            if(!product.IsValid) {

                return Results.ValidationProblem(product.Notifications.ConvertToProblemDetails());
            }

            await context.Category.AddAsync(product);
            await context.SaveChangesAsync();
            
            return Results.Created($"/products/{product.Id}", product.Id);
        }
    }

}