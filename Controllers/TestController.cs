using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_app.Controllers
{
    public class TestController : ControllerBase
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionString["conn"]);
    }
}
