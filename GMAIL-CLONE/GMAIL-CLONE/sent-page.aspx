﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sent-page.aspx.cs" Inherits="GMAIL_CLONE.sent_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="SettingsStyle.css" type="text/css" rel="Stylesheet" />
    <link href="StyleSheet.css" type="text/css" rel="Stylesheet" />
    <link href="StyleSheet2.css" type="text/css" rel="Stylesheet" />
    <link href="StyleSheet3.css" type="text/css" rel="Stylesheet" />
    <%--<link href="SettingsStyle.css" type="text/css" rel="Stylesheet" />--%>
     <style type="text/css">

 #aboxr
     {
         width:300px;
         height:auto;
         float:right;
         padding-right:20px;
         padding-top:20px;
     }
     .bt
     {
         width:200px;
        padding:6px;
        background-color:Black;
        border:2px solid SILVER;
        border-radius:5px;
        text-align:center;
        font-weight:bold;
        font-family:Calibri;
        font-size:24px;
        color:Red;
     }
     .utxt
     {
         font-family:Verdana;
         color:White;
     }
     #next1
     {
         width:100%;
         height:100px;
         background-color:Silver;
         border:1px solid GRAY;
         margin:80px auto;
     }
     #boxx1
     {
         width:900px;
         height:auto;
         margin:0 auto;
     }
     .ix
     {
         width:90px;
         height:80px;
         border:2px solid GRAY;
         border-radius:10px;
     }
     .xb1
     {
         font-family:Georgia;
         font-size:16px;
         letter-spacing:2px;
     }
     #lbx
     {
         width:400px;
         height:auto;
         float:left;
     }
     #rbx
     {
         width:450px;
         height:80px;
         float:right;
         background-color:Gray;
         border:1px solid BLACK; 
         padding-top:10px;
         border-bottom-left-radius:30px;
         border-bottom-right-radius:30px;
         box-shadow:2px 2px 2px Black;
     }
     #rbx1
     {
     width:100%;
     height:500px;
     background-color:ThreeDDarkShadow;
     border-bottom-left-radius:30px;
     border-bottom-right-radius:30px;
     box-shadow:2px 2px Blue; 
      
     }
     #rbx2
     {
         width:100%;
         height:40px;
         background:linear-gradient(red,maroon);
         background:-webkit-linear-gradient(red,maroon);
         background:-moz-linear-gradient(red,maroon);
         box-shadow:2px 2px Solid Blue;
         border-top-left-radius:20px;
         border-top-right-radius:20px;
         
     }
     #rbx3
     {
     width:100%;
     height:30px;    
     }
     #rbx4
     {
         width:100%;
         height:40px;
         background:linear-gradient(red,maroon);
         background:-webkit-linear-gradient(red,maroon);
         background:-moz-linear-gradient(red,maroon);
         box-shadow:2px 2px Solid Blue;
         border-top-left-radius:20px;
         border-top-right-radius:20px;
         
     }
     #rbx5
      {
     width:100%;
     height:30px;    
     }
     #rbx6
     {
         width:100%;
         height:40px;
         background:linear-gradient(red,maroon);
         background:-webkit-linear-gradient(red,maroon);
         background:-moz-linear-gradient(red,maroon);
         box-shadow:2px 2px Solid Blue;
         border-top-left-radius:20px; 
         border-top-right-radius:20px;
         
     }
     #rbx8
      {
         width:100%;
         height:40px;
         background:linear-gradient(red,maroon);
         background:-webkit-linear-gradient(red,maroon);
         background:-moz-linear-gradient(red,maroon);
         box-shadow:2px 2px Blue;
     }
     #rbx9
     {
      width:99.5%;   
     }
     #tab1
     {
      float:right;
      padding-right:20px;   
     }
     #Button2
     {
     border-radius:5px;
     background-color:Red;    
     }
     #Button3
     {
     border-radius:5px;
     background-color:Red;    
     }
     #tab
     {
      float:left;   
      padding-left:80px;  
      }
      #outer2
      {
          width:840px;
          height:auto;
          padding:14px;
          border:1px solid SILVER;
          margin-left:30px;
          background:linear-gradient(orange,red);
          background:-moz-linear-gradient(orange,red);
          background:-webkit-linear-gradient(orange,red);
          box-shadow:1px 1px 10px BLACK;
      }
      #tx
      {
          width:98%;
          height:auto;
          text-align:center;
          background-color:Silver;
          border:1px solid GRAY;
          color:White;
          font-family:Verdana;
          font-weight:bold;
          letter-spacing:2px; 
      }
      .ctab
      {
          width:100%;
          height:auto;
          border-collapse:collapse;
      }
      .ctab tr
      {
          height:60px;
          
      }
      .ctab td
      {
          color:Black;
          font-weight:bold;
      }
      .ctxt
      {
          width:98%;
          padding:6px;
          border:1px solid SILVER;
          box-shadow:0px 0px 2px BLACK;
      }
      .ctxt1
      {
          width:98%;
          height:300px;
          padding:6px;
          border:1px solid SILVER;
          box-shadow:0px 0px 2px BLACK;
      }
      .cbt
      {
          width:100px;
          padding:6px;
          background-color:Maroon;
          border:2px solid SILVER;
          color:White;
          font-size:16px;
          font-weight:bold;
      }
         #chat1 {
             position: fixed;
             bottom: 60px;
             right: 20px;
             width: 250px;
             padding: 4px;
             height:300px;
             border:1px solid SILVER;
         }
         #chat2 {
             position: fixed;
             bottom: 10px;
             right: 20px;
             width: 250px;
             height: 40px;
             border:1px solid GRAY;
         }
         .chat {
             border: 1px solid RED;
             width:246px; 
             height:36px;
         }
         .grid
         {
             width:90%;
             text-align:center;
             margin:0 auto;
         }
         .grid img
         {
             border:1px solid BLACK;
             border-radius:10px;
         }
     #L
     {
      position:absolute;
      top:25px;
      float:right; 
      right:15px;  
      }
      #ImageButton5
      {
       position:absolute;
       float:right;
       right:10px;  
       top:5px; 
       }
        #b
         {
          position:absolute;
          float:right;
          right:40px;
          width:98px;
          height:auto;
          border-radius:4px;
          box-shadow:2px 2px 8px Yellow;
             
          }
          #Button3
          {
          background-color:Aqua; 
          }
          #ImageButton6
          {
         position:absolute;
         float:right;
         right:10px;  
         top:5px;   
           }
     </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
    
        <div id="title">Qmail</div>
        
        
        <div id="aboxr">
        <table cellpadding="5" cellspacing="5">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Logout" CssClass="bt" OnClick="Button1_Click" 
                     />
            </td>
        </tr>
        </table>
        </div> 

       
        
        
    </div>

    <div id="next1">
        <div id="boxx1">
        <div id="lbx">
        <table cellpadding="5" cellspacing="5">
        
            <tr>
                <td>
                  <a href="Default2.aspx"><asp:Image ID="Image1" runat="server" CssClass="ix" /></a>
                </td>
                <td valign="middle">
                
                    <asp:Label ID="Label2" runat="server" CssClass="xb1"></asp:Label>
                
                </td>
            </tr>
        
        </table>
        </div>

        <div id="rbx">
        <table id="tab" cellspacing="3" cellpadding="3">
        <tr>
        <td>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="mail_inbox.png" 
                Height="50px" Width="60px" OnClick="ImageButton1_Click" /><br />
            &nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Inbox"></asp:Label>
            </td>
            <td>
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="mail-sent.png" 
                    Height="50px" Width="60px" /><br />
                <asp:Label ID="Label8" runat="server" Text="Sent Items"></asp:Label>
            </td>
           <td>
              



 <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="mail-draft.png" 
                   Height="50px" Width="60px" OnClick="ImageButton3_Click" /><br />
               &nbsp;&nbsp;
               <asp:Label ID="Label9" runat="server" Text="Drafts"></asp:Label>
           </td> 
           <td>
               <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="mail-setting.png" 
                   Height="50px" Width="60px" OnClick="ImageButton4_Click" /><br />
               &nbsp;
               <asp:Label ID="Label10" runat="server" Text="Settings"></asp:Label>
           </td>
        </tr>
        </table>
        
        </div>
        </div>
    </div>
    
    
    <div id="x">
        <asp:GridView ID="GridView1" runat="server" Width="90%" margin-left="auto" margin-right="auto"
            CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="grid" AutoGenerateColumns="false">
             <AlternatingRowStyle BackColor="White" />

            <Columns>
        <asp:TemplateField HeaderText="Image">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("to_imgurl") %>' Width="100" Height="100" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="to_email" HeaderText="To Email" />
         <asp:TemplateField HeaderText="Title">
            <ItemTemplate>
                <asp:HyperLink ID="TitleLink" runat="server" Text='<%# Eval("title") %>'
                    NavigateUrl='<%# "inboxcontent.aspx?title=" + Server.UrlEncode(Eval("title").ToString()) %>' />
            </ItemTemplate>
        </asp:TemplateField>

        <asp:BoundField DataField="dt" HeaderText="Date" />
    </Columns>
            
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
             <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </div>
   



    </form>
</body>
</html>
