    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="log-in.aspx.cs" Inherits="GMAIL_CLONE.log_in" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <html lang="en" dir="ltr">


<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Login Page</title>
  <link rel="stylesheet" href="login-css.css">
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <style type="text/css">
        .auto-style1 {
            margin-top: 15px;
        }
    </style>
</head>


<body>
    <div class="wrapper">
    <div class="about-us">
      <h2>About Us</h2>
      <img src="a-fotor-bg-remover-2023062220753.png" alt="Mail">
      <p><span id="element"></span></p>
    </div>
    <div class="login-form">
      <h2>Login Page</h2>
      <form id="form2" runat="server">
        <div class="input-box">
          <%--<input type="text" id="email" name="email" placeholder="Enter your email" required>--%>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter your email" ></asp:TextBox>

        </div>
        <div class="input-box">
          <%--<input type="password" id="password" name="password" placeholder="Enter your password" required>--%>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter your password" ></asp:TextBox>


        </div>
        <div class="input-box button">
          <%--<input type="submit" value="LOG IN">--%>
            <asp:Button ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click" Height="41px"/>
            <asp:Button ID="Button2" runat="server" Text="Create Account" OnClick="Button2_Click" CssClass="auto-style1" Height="41px" />
        </div>
      </form>
    </div>
  </div>
  <script src="https://unpkg.com/typed.js@2.0.16/dist/typed.umd.js"></script>
  <script>
    var typed = new Typed('#element', {
      strings: ["Now connect anyone from anywhere"],
      typeSpeed: 70
    });
  </script>
</body>
</html>
