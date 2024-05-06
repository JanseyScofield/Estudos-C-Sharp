using IWantApp.EndPoints.Employees;
using Microsoft.Data.SqlClient;
using Dapper;


namespace IWantApp.infra.Data {
    public class QueryAllUsersWithClaimName {
        private readonly IConfiguration _configuration;
        public QueryAllUsersWithClaimName(IConfiguration configuration) {
            this._configuration = configuration;
        }
        public IEnumerable<EmployeeResponse> Execute(int page, int rows) {

            var db = new SqlConnection(_configuration["ConnectionString:IWantDb"]);
            var query = @"select Email, ClaimValue as Name
                    from AspNetUsers u inner
                    join AspNetuserClaims c
                    on u.id = c.UserId and claimtype = 'Name'
                    order by name
                    OFFSET (@page-1) * @rows ROWS FETCH NEXT @rows ROWS ONLY";
            return db.Query<EmployeeResponse>(
                query,
                    new { page, rows }
                );
        }
    }
}
