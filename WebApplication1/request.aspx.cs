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
        string email="";
        string fn="";
        string ln="";
        string otch="";
        string trademark="";
        string city="";
        string dep="";
        string dolz="";
        string tnumb="";
        string urtver = "";
        public string eml = "";



        protected void Page_Load(object sender, EventArgs e)
        {
            // получить текущего пользователя, извлечь e-mail 
            //eml = "avsemykin2016@yandex.ru";
            //Zap(eml);












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


                string[] gg;
                int num;
                int numbn;
                int i = 0;
                //com.CommandText = "select max(id) from req";


                com.CommandText = "select * from users where email=" + @"'" + mail + @"'";

                NpgsqlDataReader rd1 = com.ExecuteReader();


                while (rd1.Read())
                {
                    fn = rd1[1].ToString();
                    ln = rd1[2].ToString();
                    otch = rd1[3].ToString();
                    trademark=rd1[5].ToString();
                    dep = rd1[6].ToString();
                    dolz = rd1[4].ToString();
                    tnumb = rd1[8].ToString();
                    urtver =rd1[9].ToString();
                   
                }



                //Заполнение формы =заполнение контекста HTTP 
                //HttpContext.Current.Items["email"] = "avsemykin2016@yandex.ru";
                //       HttpContext.Current.Items["trademark"] = "kljlkjkljkljlkjkljkljklj";



                //Заполнение формы =заполнение контекста HTTP 
                HttpContext.Current.Items["email"] =eml;
                HttpContext.Current.Items["trademark"] = trademark;
                HttpContext.Current.Items["lastname"] = ln;
                HttpContext.Current.Items["firstname"] = fn;
                HttpContext.Current.Items["otch"] = otch;
                HttpContext.Current.Items["dep"] = dep;
                HttpContext.Current.Items["dolz"] = dolz;
                HttpContext.Current.Items["urtver"] = urtver;



               





            }

            catch { }
            return mail;
        }








            //"Server = 127.0.0.1; Port = 5433; Database = sup; User Id = postgres; Password =12345";


           
            ///return mail;





        }
  
    }


