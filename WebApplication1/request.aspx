<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="req1.cshtml" runat="server" Inherits="WebApplication1.request" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title align="center"> Форма отправки запроса в техническую поддержку URT</title>
</head>
        <li>
           <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title</title>
    <style>
.wrapper {
  background-color: whitesmoke;
  list-style-type: none;
  padding: 0;
  border-radius: 3px;
}
.form-row {
  display: flex;
  justify-content: flex-end;
  padding: .5em;
}
.form-row > label {
  padding: .5em 1em .5em 0;
  flex: 1;
}
.form-row > input {
  flex: 2;
}
.form-row > input,
.form-row > button {
  padding: .5em;
}
.form-row > button {
  background: gray;
  color: white;
  border: 0;
}
@media screen and (min-width: 768px) {
  .form-row > input {
    flex: 3; 
  }
}
@media screen and (min-width: 992px) {
  .form-row > input {
    flex: 4; 
  }
}
@media screen and (min-width: 1200px) {
  .form-row > input {
    flex: 5; 
  }
}

.butt {
  align-items: center;
  background-clip: padding-box;
  background-color: #fa6400;
  border: 1px solid transparent;
  border-radius: .25rem;
  box-shadow: rgba(0, 0, 0, 0.02) 0 1px 3px 0;
  box-sizing: border-box;
  color: #fff;
  cursor: pointer;
  display: inline-flex;
  font-family: system-ui,-apple-system,system-ui,"Helvetica Neue",Helvetica,Arial,sans-serif;
  font-size: 16px;
  font-weight: 600;
  justify-content: center;
  line-height: 1.25;
  margin: 0;
  min-height: 3rem;
  padding: calc(.875rem - 1px) calc(1.5rem - 1px);
  position: center;
  text-decoration: none;
  transition: all 250ms;
  user-select: none;
  -webkit-user-select: none;
  touch-action: manipulation;
  vertical-align: baseline;
  width: 20em;
  text-align=center;
}

.submit:hover,
.submit:focus {
  background-color: #fb8332;
  box-shadow: rgba(0, 0, 0, 0.1) 0 4px 12px;
}

.submit:hover {
  transform: translateY(-1px);
}

.submit:active {
  background-color: #c85000;
  box-shadow: rgba(0, 0, 0, .06) 0 2px 4px;
  transform: translateY(0);
}

        h2 {
            text-align: center;
        }
 
        th, td {
  padding: 15px;
}
.email
{
 width: 50px
}

 .red {
            color: #ff0000;
        }


</style>
</head>


<body>
<h2>Форма отправки запроса в отдел технической поддержки </h2>
<form action="/req1" method="post">
  <ul class="wrapper">

<script type="text/javascript"  async>

    function autofill() {
        const { Client } = require("pg")
        const dotenv = require("dotenv")
        dotenv.config()
        const connectDb = async () => {
            try {
                const client = new Client({
                    user: postgres;
                    host: process.env.PGHOST,
                    database: process.env.PGDATABASE,
                    password: process.env.PGPASSWORD,
                    port: process.env.PGPORT
                })

                await client.connect()
                const res = await client.query('SELECT * FROM some_table')
                console.log(res)
                await client.end()
            } catch (error) {
                console.log(error)
            }
        }
        connectDb()
    }
</script>

      

<li class="form-row">
        <label>E-Mail </label>
        <input name="email" value="" required/>
    </li>
<li class="form-row">
        <label>Марка </label>
        <input name="trademark" value="" />
        </li>
    
    <li class="form-row">
        <label>Город </label>
        <input name="city" value="" />
    </li>
    
          <li class="form-row">
        <label>Подразделение</label>
        <input name="dep" value="" />
    </li>
     <li class="form-row">
        <label>Фамилия </label>
        <input name="lastName" />
        </li>
          <li class="form-row">

        <label>Имя</label>
        <input name="firstName" />
    </li>
      
      <li class="form-row">

        <label>Отчество </label>
        <input name="otch" />
    </li>
   <li class="form-row">

        <label>Должность </label>
        <input name="dolz" />
    </li>

      <li class="form-row">

        <label>Версия URT </label>
        <input name="ver" />
    </li>

<li class="form-row">

        <label>Краткое описание случая</label>
        <input name="opsl" />
    </li>

      <li class="form-row">

        <label>Телефонный номер </label>
        <input name="tnumb" />
    </li>




        
<p align="center">
<input type="submit" class="butt" name="submit" value="Отправить запрос" /></p>

<p align="center">

<input type="button" class="butt" name="back" value="На главную " onclick="document.location='Default.aspx'" />
</p>

<script src="fill.js">

    function autofill() {
        const { Client } = require("pg")
        const dotenv = require("dotenv")
        dotenv.config()
        const connectDb = async () => {
            try {
                const client = new Client({
                    user: postgres;
                    host: process.env.PGHOST,
                    database: process.env.PGDATABASE,
                    password: process.env.PGPASSWORD,
                    port: process.env.PGPORT
                })

                await client.connect()
                const res = await client.query('SELECT * FROM some_table')
                console.log(res)
                await client.end()
            } catch (error) {
                console.log(error)
            }
        }
        connectDb()
    }
</script>


<p align="center">
<input type="button" class="butt" name="fill"  onclick= "autofill()" value="Заполнить" />
</p>


</form>
   
</body>
</html>
