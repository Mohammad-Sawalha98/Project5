﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project5.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="Login.css"/>

</head>
<body>
    <form id="form1" runat="server">
        <div id="information">
            <div id="login">
                <asp:Image ID="Image1" runat="server" src="\images\Mobail Zone Logo.png" />

                <div class="inputbox">
                    <input id="Email" class="Email" name="Email" value="" placeholder="Email" runat="server"/>
                </div>

                <div class="inputbox">
                    <input id="Password1" class="Passward1" name="Passward1" value="" type="password" placeholder="Password" runat="server" />
                </div>



                    <div class="signup">
                        <p>Don't have an account?<a href="Registration.aspx">Register here</a></p>
                    </div>

                  <div id="Lable2">
                <asp:Button ID="Button1" class="Button1" runat="server" Text="Log in" OnClick="Button1_Click" />
                      
                      <br />
                      <br />
                      <br />
                      <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

            </div>
            </div>

        </div>
        <div class="imagebox">
     <asp:Image ID="Image2" runat="server" src="\images\log in (1).jpg" />

        </div>

    </form>
</body>
</html>