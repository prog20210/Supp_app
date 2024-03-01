using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL.Design;
using System.Configuration;



namespace WebApplication1
{
    public partial class Addtask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings constr;
            constr = ConfigurationManager.ConnectionStrings["con"];
            NpgsqlConnection con = new NpgsqlConnection();
            NpgsqlCommand com = con.CreateCommand();
            com.CommandText = "select * from req";

            Addtask task;
           /// task.Response Ответ от сервера клиенту 



        }
    }
}