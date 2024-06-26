﻿using System;
using IWantApp.Infra.Data;

namespace IWantApp.EndPoints.Categories {
    static class ProductGetAll {

        public static string Template => "/categories";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action( ApplicationDbContext context) {

            var category = context.Category.ToList();
            var response = category.Select(c => new CategoryResponse(c.Id, c.Name, c.Active ));


            return Results.Ok(response);
        }
    }
}