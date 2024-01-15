<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Task.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <h1>Задачи</h1>
      

<script runat="server">


    private void Page_Load(Object sender, EventArgs e)
    {
       Table tbl = new Table();
        // Generate rows and cells.           
        int numrows = 3;
        int numcells = 2;
        for (int j = 0; j < numrows; j++)
        {
            TableRow r = new TableRow();
            for (int i = 0; i < numcells; i++) {
                TableCell c = new TableCell();
                c.Controls.Add(new LiteralControl("row "
                    + j.ToString() + ", cell " + i.ToString()));
                r.Cells.Add(c);
            }
            tbl.Rows.Add(r);
            
        }
    }
    
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1">
    <div>

    <h3>Table example, constructed at design time</h3>
    <asp:Table id="Table1" 
        CellPadding="10" 
        GridLines="Both"
        HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>
                Row 0, Col 0
            </asp:TableCell>
            <asp:TableCell>
                Row 0, Col 1
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Row 1, Col 0
            </asp:TableCell>
            <asp:TableCell>
                Row 1, Col 1
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    
    </div>
    </form>
    </a>
</asp:Content>
</body>
</html>