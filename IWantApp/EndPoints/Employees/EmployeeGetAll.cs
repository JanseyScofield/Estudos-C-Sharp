using Microsoft.AspNetCore.Identity;
using IWantApp.infra.Data;


namespace IWantApp.EndPoints.Employees {
    static class EmployeeGetAll {

        public static string Template => "/employees";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action(int? page, int? rows, UserManager<IdentityUser> userManager,QueryAllUsersWithClaimName query ) {

            if( page <= 0 || rows <= 0 && rows > 10) {
                return Results.BadRequest();
            }
            return Results.Ok(query.Execute(page.Value, rows.Value));
        }
    }

}