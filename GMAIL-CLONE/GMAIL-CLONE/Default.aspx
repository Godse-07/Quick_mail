<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Gmail_clone.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

  <!DOCTYPE html>
<html lang="en" dir="ltr">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Sign up page</title>
  <link rel="stylesheet" href="StyleSheet1.css">
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
</head>

<body>
  <div class="wrapper">
    <div class="about-us">
      <h2>About Us</h2>
      <img src="a-fotor-bg-remover-2023062220753.png" alt="Mail">
      <p><span id="element"></span></p>
    </div>
    <div class="signup-form">
      <h2>Sign up page</h2>
      <form id="form1" runat="server">
        <div class="input-box">
          
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter your name"></asp:TextBox>
        </div>
        <div class="input-box">
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter your email"></asp:TextBox>
        </div>
        <div class="input-box">
            <asp:TextBox ID="TextBox3" runat="server" placeholder="Create password" type="password"></asp:TextBox>
        </div>
        <div class="input-box">
            <asp:TextBox ID="TextBox4" runat="server" placeholder="Confirm password" type="password"></asp:TextBox>
        </div>
        <div class="input-box">
          <label for="Gender">Choose a gender:</label>
          <select name="gender" id="gender">
            <option value="Male">Male</option>
            <option value="Female">Female</option>
            
              <br />
              <asp:FileUpload ID="FileUpload1" runat="server" />
              <br />
        </div>
        <div class="policy">
            
            <asp:CheckBox ID="CheckBox1" runat="server" />
          <label for="terms">I accept all terms &amp; conditions</label>
        </div>
        <div class="input-box box" style="height: 24px">
          
            <asp:Button ID="Button1" runat="server" Text="LOG IN NOW" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="AlREADY HAVE ACCOUNT" OnClick="Button2_Click"  />
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
