using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JSPool;
using Microsoft.AspNetCore.Mvc.RazorPages;
 


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


        public  string Zap(string mail)
        {
            string a = mail;

            //Заполнение формы =заполнение контекста HTTP 
            HttpContext.Current.Items["email"] = "avsemykin2016@yandex.ru";
            HttpContext.Current.Items["trademark"] = "kljlkjkljkljlkjkljkljklj";
            return mail;

        }
        
        

    }
}
