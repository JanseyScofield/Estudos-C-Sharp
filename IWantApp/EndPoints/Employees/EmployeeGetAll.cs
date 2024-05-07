using Microsoft.AspNetCore.Identity;
using IWantApp.infra.Data;
using Microsoft.AspNetCore.Authorization;


namespace IWantApp.EndPoints.Employees {
    static class EmployeeGetAll {

        public static string Template => "/employees";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handle => Action;

        [Authorize(Policy = "EmployeePolicy")]
        public static async Task<IResult> Action(int? page, int? rows, UserManager<IdentityUser> userManager,QueryAllUsersWithClaimName query ) {

            if( page <= 0 || rows <= 0 && rows > 10) {
                return Results.BadRequest();
            }
            var result = await query.Execute(page.Value, rows.Value);
            return Results.Ok(result);
        }
    }

}