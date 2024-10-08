using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JSPool;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;
using System.Configuration;



namespace WebApplication1
{
    public partial class request : System.Web.UI.Page
    {
        string email;
        protected void Page_Load(object sender, EventArgs e)
        {
            // получить текущего пользователя, извлечь e-mail 
            string eml = "avsemykin2016@yandex.ru";
            Zap(eml);












        }


        public string Zap(string mail)
        {



            ConnectionStringSettings constr;
            constr = ConfigurationManager.ConnectionStrings["con"];

            NpgsqlConnection con = new NpgsqlConnection();
            NpgsqlCommand com = con.CreateCommand();

            constr = ConfigurationManager.ConnectionStrings["con"];





            ///con.ConnectionString = constr[0]


            con.ConnectionString = constr.ToString();

            //"Server = 127.0.0.1; Port = 5433; Database = sup; User Id = postgres; Password =12345";

            try
            {
               
                con.Open();
               
               


                int num;
                int numbn;
                int i = 0;
                //com.CommandText = "select max(id) from req";


                com.CommandText = "select * from users";
                NpgsqlDataReader rd = com.ExecuteReader();



                if (rd.HasRows) {

                    while (rd.Read())
                    {
                        string gg = rd.GetString(i);
                        i = i + 1;
                    }


                }
                //Заполнение формы =заполнение контекста HTTP 
                HttpContext.Current.Items["email"] = "avsemykin2016@yandex.ru";
                HttpContext.Current.Items["trademark"] = "kljlkjkljkljlkjkljkljklj";



                //Заполнение формы =заполнение контекста HTTP 
                HttpContext.Current.Items["email"] =rd[0].ToString();
                HttpContext.Current.Items["trademark"] = rd[1].ToString();
                return mail;


            }





            catch { }









            //"Server = 127.0.0.1; Port = 5433; Database = sup; User Id = postgres; Password =12345";


           
            return mail;





        }
  
    }

}
