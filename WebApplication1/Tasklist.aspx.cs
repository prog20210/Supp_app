﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using Npgsql;
using System.Web.UI.HtmlControls;
using System.Net;
using System.Net.Sockets;
using System.Text;




namespace WebApplication1
{
    public partial class Addtask : System.Web.UI.Page
    { public string name = "";
        public string date;
        public string tim;
        public int id;
        public string email;
        public string fn, ln;
        public string otch;
        public string trademark;
        public string city;
        public string dep;
        public string dolz;
        public string tnumb;
        int tt, i;


        public string text = "";
        public string kat = "";
    
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings constr;

            Addtask task = new Addtask();
            


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
                        ///  Подготовительная часть. Коннект 


                        ///На стороне сервака 

                        /// Парсить строку подключения из конфигурации 

                        string[] cs = constr.ConnectionString.Split(';');

                        // загрузить адрес и порт сервака из конфига.
                        // вытащить адрес 

                        string str = cs[0];
                        string[] maddr = str.Split(' ');
                        string addres = maddr[2];

                        // Вытащить порт 

                        string[] prt = cs[1].Split(' ');
                        string full = addres + ":" + prt[3];

                        int port = Convert.ToInt16(prt[3]);



                        System.Net.IPAddress ipaddress = System.Net.IPAddress.Parse("127.0.0.1");

                        IPAddress[] ips = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
                        // точка подключения 
                        IPEndPoint endPoint = new IPEndPoint(ipaddress, port);

                       
                        Socket listeningSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);

                        AddressFamily fam= new AddressFamily();

                        SocketAddress socketAddress = endPoint.Serialize();
                    
                    

                        endPoint.Address.ToString();
                        endPoint.Port = port;

                   
                        endPoint.Create(socketAddress); 
                    
                            
                            
                            
                         


//IPEndPoint endpoint = new IPEndPoint(addres, port);



//   IPEndPoint myEP = new IPEndPoint(ips, port);



                        
                        listeningSocket.Bind(endPoint);
                        listeningSocket.Listen(port);
                        Socket acceptedSocket = listeningSocket.Accept();


                        try
                        {
                            acceptedSocket.Connect(ips, port);
                            // socket.Connect(endPoint);
                            endPoint.Address.ToString();
                            endPoint.Port.ToString();
                            
                            acceptedSocket.Bind(endPoint);
                        }

                        catch
                        {
                            Context.Response.Write("Ошибка сокета!");
                        }


            
















                        ///  



















                        while (rd.Read())
                        {
                            for (i = 0; i <= 9; i++)
                            {
                                int id = Convert.ToInt32(rd[0]);
                                email = rd[1].ToString();
                                fn = rd[2].ToString();
                                ln = rd[3].ToString();
                                otch = rd[4].ToString();
                                trademark = rd[5].ToString();
                                city = rd[6].ToString();
                                dep = rd[7].ToString();
                                dolz = rd[8].ToString();
                                tnumb = rd[9].ToString();
                                tt = tt + 1;
                                // оформить объект задачи
                            }

                           















                            //HttpContext.Current.Items["task"] = task.name + " " + task.date + " " + task.tim + " " + task.city + " " + task.trademark;



                            // HttpContext.Current.Items["task"] = task.name + " " + task.date + " " + task.tim + " " + task.city + " " + task.trademark;





                        }
                        ///////////Следующий результат/////////////////////
                        rd.NextResult();
                        ///
                    }
                    


                }
                catch
                {

                }
            }

            for (i=0;i<=tt;i++) {



                // Вывод данных из базы на web страницу
           
            

               

                Context.Response.Write(task.name + " " + task.date + " " + task.tim + " " + task.city + " " + task.trademark);
             
               

            }

            
            



            /// task.Response Ответ от сервера клиенту 



        }
    }








}




