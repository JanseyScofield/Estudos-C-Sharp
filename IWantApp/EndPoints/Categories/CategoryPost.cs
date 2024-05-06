using System;
using IWantApp.Infra.Data;
using IWantApp.Domain.Products;

using System.CodeDom.Compiler;
using System.Xml.Linq;
namespace IWantApp.EndPoints.Categories {
    static class CategoryPost {

        public static string Template => "/categories";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action(CategoryRequest categoryRequest, ApplicationDbContext context) {

            var category = new Category(categoryRequest.Name, "Teste", "Teste");

            if(!category.IsValid) {

                return Results.ValidationProblem(category.Notifications.ConvertToProblemDetails());
            }

            context.Category.Add(category);
            context.SaveChanges();

            return Results.Created($"/categories/{category.Id}", category.Id);
        }
    }

}