using Mithuvai.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Mithuvai.Gateway
{
    public class DbConnection
    {
        public SqlConnection Con = new SqlConnection(WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString.ToString());

   
    }
}