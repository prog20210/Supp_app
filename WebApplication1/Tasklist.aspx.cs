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
    {  public string name="";
        public string date;
        public string  tim;
        
       
        public string text="";
        public string kat="";

        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings constr;
            constr = ConfigurationManager.ConnectionStrings["con"];
            NpgsqlConnection con = new NpgsqlConnection(constr.ConnectionString);
            NpgsqlCommand com = con.CreateCommand();
            
            com.CommandText = "select * from req";

            Addtask task=new Addtask();
            task.name = "nnnn";
            task.date = DateTime.Now.Date.ToShortDateString();
            task.tim =DateTime.Now.ToString(("HH:mm:ss"));

          





            /// task.Response Ответ от сервера клиенту 
            try
            {
                con.Open();
                NpgsqlDataReader rd=com.ExecuteReader();

           if (rd.HasRows)
                {
                  

                    
                }
               
            

            }


            catch
            {

            }
            

        }
    }
}