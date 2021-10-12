using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_rest_Controller
{
    public class Secrets
    {
        public static readonly string ConnectionString = "Server=tcp:my-server-cata1.database.windows.net,1433;Initial Catalog=myDB;Persist Security Info=False;User ID=Catalina;Password={Pentruca!21};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}