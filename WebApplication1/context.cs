using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;

namespace WebApplication1
{
    public class context : DbContext
    {

        private const string comstr = @"User ID = postgres; Password=12345;Host=localhost;Port=5432;Database=sup;Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime = 0;";



    }
}
    