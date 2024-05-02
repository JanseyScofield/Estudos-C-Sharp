using System;
using IWantApp.Infra.Data;
using IWantApp.Domain.Products;

using System.CodeDom.Compiler;
namespace IWantApp.EndPoints.Categories {
    static class CategoryGetAll {

        public static string Template => "/categories";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action( ApplicationDbContext context) {

            var category = context.Category.ToList();
            var response = category.Select(c => new CategoryResponse { Id = c.Id, Name = c.Name, Active = c.Active });


            return Results.Ok(response);
        }
    }
}