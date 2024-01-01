using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Request
    {
        public int id { get; set; }


        public string surname { get; set; }

        public string name { get; set; }

        public string otch { get; set; }

        public string dep { get; set; }

        public string city { get; set; }

        public string otd { get; set; }
        

        public string dolz { get; set; }

        public string opsl { get; set; }



    }

    public class Solution
    {
        public int id { get; set; }
        public string Code { get; set; }
        public string Req { get; set; }
        public string Sol { get; set; }

    }

    public class knbase
    {
        public int id { get; set; }
        public string Codesol { get; set; }
        public string Sol { get; set; }
    }

    public class users
    {
        public int id { get; set; }

        
        public string Surname { get; set; }

        public string Name { get; set; }

        public string Otch { get; set; }

        public string dep { get; set; }

        public string Dolz { get; set; }

        public int Rights { get; set; }


    }

}