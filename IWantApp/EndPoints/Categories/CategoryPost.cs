using System;
using IWantApp.Infra.Data;
using IWantApp.Domain.Products;

using System.CodeDom.Compiler;
namespace IWantApp.EndPoints.Categories {
    static class CategoryPost {

        public static string Template => "/categories";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action(CategoryRequest categoryRequest, ApplicationDbContext context) {

            var category = new Category {
                Name = categoryRequest.Name,
                CreatedBy = "Test",
                CreatedOn = DateTime.Now,
                EditedBy = "Test",
                EditedOn = DateTime.Now,
            };

            context.Category.Add(category);
            context.SaveChanges();

            return Results.Created($"/categories/{category.Id}", category.Id);
        }
    }

}