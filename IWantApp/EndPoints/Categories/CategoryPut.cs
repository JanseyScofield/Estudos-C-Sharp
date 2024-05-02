using System;
using IWantApp.Infra.Data;
using IWantApp.Domain.Products;

using System.CodeDom.Compiler;
using Microsoft.AspNetCore.Mvc;
namespace IWantApp.EndPoints.Categories {
    static class CategoryPut {

        public static string Template => "/categories/{id}";
        public static string[] Methods => new string[] { HttpMethod.Put.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]Guid Id, CategoryRequest categoryRequest, ApplicationDbContext context) {
            
            var category = context.Category.Where(c => c.Id == Id).FirstOrDefault();
            category.Name = categoryRequest.Name;
            category.Active = categoryRequest.Active;

            context.SaveChanges();

            return Results.Ok();
        }
    }

}