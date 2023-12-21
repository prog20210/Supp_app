<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="request.aspx.cs" Inherits="WebApplication1.request" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <pre class="has-inner-focus"><code class="lang-aspx-csharp" data-author-content='<%@ Page Language="C#" AutoEventWireup="True" %>

&lt;!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"&gt;
&lt;html xmlns="http://www.w3.org/1999/xhtml" &gt;
&lt;head&gt;
    &lt;title&gt;Button Example&lt;/title&gt;
&lt;script language="C#" runat="server"&gt;

      void SubmitBtn_Click(Object sender, EventArgs e) 
      {
         Message.Text="Hello World!!";
      }

   &lt;/script&gt;
&lt;/head&gt;
&lt;body&gt;
   &lt;form id="form1" runat="server"&gt;

      &lt;h3&gt;Button Example&lt;/h3&gt;

      Click on the submit button.&lt;br /&gt;&lt;br /&gt;
 
      &lt;asp:Button id="Button1"
           Text="Submit"
           OnClick="SubmitBtn_Click" 
           runat="server"/&gt;
       
      &lt;br /&gt;

      &lt;asp:label id="Message" runat="server"/&gt;
 
   &lt;/form&gt;
&lt;/body&gt;
&lt;/html&gt;
'><span>
<span class="hljs-tag">&lt;<span class="hljs-name">html</span> <span class="hljs-attr">xmlns</span>=<span class="hljs-string">&quot;http://www.w3.org/1999/xhtml&quot;</span> &gt;</span>
<span class="hljs-tag">&lt;<span class="hljs-name">head</span>&gt;</span>
    <span class="hljs-tag">&lt;<span class="hljs-name">title</span>&gt;</span>Button Example<span class="hljs-tag">&lt;/<span class="hljs-name">title</span>&gt;</span>
<span class="hljs-tag">&lt;<span class="hljs-name">script</span> <span class="hljs-attr">language</span>=<span class="hljs-string">&quot;C#&quot;</span> <span class="hljs-attr">runat</span>=<span class="hljs-string">&quot;server&quot;</span>&gt;</span><span class="cs">

      <span class="hljs-function"><span class="hljs-keyword">void</span> <span class="hljs-title">SubmitBtn_Click</span>(<span class="hljs-params">Object sender, EventArgs e</span>)</span> 
      {
         Message.Text=<span class="hljs-string">&quot;Hello World!!&quot;</span>;
      }

   </span><span class="hljs-tag">&lt;/<span class="hljs-name">script</span>&gt;</span>
<span class="hljs-tag">&lt;/<span class="hljs-name">head</span>&gt;</span>
<span class="hljs-tag">&lt;<span class="hljs-name">body</span>&gt;</span>
   <span class="hljs-tag">&lt;<span class="hljs-name">form</span> <span class="hljs-attr">id</span>=<span class="hljs-string">&quot;form1&quot;</span> <span class="hljs-attr">runat</span>=<span class="hljs-string">&quot;server&quot;</span>&gt;</span>

      <span class="hljs-tag">&lt;<span class="hljs-name">h3</span>&gt;</span>Button Example<span class="hljs-tag">&lt;/<span class="hljs-name">h3</span>&gt;</span>

      Click on the submit button.<span class="hljs-tag">&lt;<span class="hljs-name">br</span> /&gt;&lt;<span class="hljs-name">br</span> /&gt;</span>
 
      <span class="hljs-tag">&lt;<span class="hljs-name">asp:Button</span> <span class="hljs-attr">id</span>=<span class="hljs-string">&quot;Button1&quot;</span>
           <span class="hljs-attr">Text</span>=<span class="hljs-string">&quot;Submit&quot;</span>
           <span class="hljs-attr">OnClick</span>=<span class="hljs-string">&quot;SubmitBtn_Click&quot;</span> 
           <span class="hljs-attr">runat</span>=<span class="hljs-string">&quot;server&quot;</span>/&gt;</span>
       
      <span class="hljs-tag">&lt;<span class="hljs-name">br</span> /&gt;</span>

      <span class="hljs-tag">&lt;<span class="hljs-name">asp:label</span> <span class="hljs-attr">id</span>=<span class="hljs-string">&quot;Message&quot;</span> <span class="hljs-attr">runat</span>=<span class="hljs-string">&quot;server&quot;</span>/&gt;</span>
 
   <span class="hljs-tag">&lt;/<span class="hljs-name">form</span>&gt;</span>
<span class="hljs-tag">&lt;/<span class="hljs-name">body</span>&gt;</span>
<span class="hljs-tag">&lt;/<span class="hljs-name">html</span>&gt;</span>
</span></code></pre>
    <pre class="has-inner-focus"><code class="lang-aspx-csharp" data-author-content='<%@ Page Language="C#" AutoEventWireup="True" %>

&lt;!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"&gt;
&lt;html xmlns="http://www.w3.org/1999/xhtml" &gt;
&lt;head&gt;
    &lt;title&gt;Button Example&lt;/title&gt;
&lt;script language="C#" runat="server"&gt;

      void SubmitBtn_Click(Object sender, EventArgs e) 
      {
         Message.Text="Hello World!!";
      }

   &lt;/script&gt;
&lt;/head&gt;
&lt;body&gt;
   &lt;form id="form1" runat="server"&gt;

      &lt;h3&gt;Button Example&lt;/h3&gt;

      Click on the submit button.&lt;br /&gt;&lt;br /&gt;
 
      &lt;asp:Button id="Button1"
           Text="Submit"
           OnClick="SubmitBtn_Click" 
           runat="server"/&gt;
       
      &lt;br /&gt;

      &lt;asp:label id="Message" runat="server"/&gt;
 
   &lt;/form&gt;
&lt;/body&gt;
&lt;/html&gt;
'><span>
</span></code></pre>
</body>
</html>
