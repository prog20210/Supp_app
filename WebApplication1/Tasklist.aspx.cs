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
using System.Web.UI.HtmlControls;



namespace WebApplication1
{
    public partial class Addtask : System.Web.UI.Page
    {  public string name="";
        public string date;
        public string  tim;
        public int id;
       public  string email;
       public  string fn, ln;
        public string otch;
        public string trademark;
        public string city;
        public string dep;
        public string dolz;
        public string tnumb;



        public string text="";
        public string kat="";

        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings constr;
            constr = ConfigurationManager.ConnectionStrings["con"];
            NpgsqlConnection con = new NpgsqlConnection(constr.ConnectionString);
            NpgsqlCommand com = con.CreateCommand();
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                try

                {


                    com.CommandText = "select * from req";

                    NpgsqlDataReader rd = com.ExecuteReader();
                    if (rd.HasRows)
                    {


                        while (rd.Read())
                        {
                            int id = Convert.ToInt32(rd[0]);
                            email = rd[1].ToString();
                            fn = rd[2].ToString();
                            ln = rd[3].ToString();
                            otch = rd[4].ToString();
                            trademark=rd[5].ToString();
                            city = rd[6].ToString();
                            dep = rd[7].ToString();
                            dolz = rd[8].ToString();
                            tnumb= rd[9].ToString();
                        }

                    }
                }
                catch
                {

                }
            }
            Addtask task=new Addtask();
            task.name = fn+" "+ ln;
            task.date = DateTime.Now.Date.ToShortDateString();
            task.tim =DateTime.Now.ToString(("HH:mm:ss"));
            task.city = this.city;
            task.trademark = this.trademark;

            task.SaveControlState();
            // Вывод данных из базы на web страницу
            HttpContext.Current.Items["task"] = task.name+" "+task.date+" "+task.tim+" "+task.city+" "+task.trademark;




            /// task.Response Ответ от сервера клиенту 



        }
    }








}




