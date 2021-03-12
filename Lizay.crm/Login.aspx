<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Lizay.crm.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Meta tags -->
    <title>Lizay Pırlanta Login</title>
    <meta name="keywords" content="Winter Login Form Responsive widget, Flat Web Templates, Android Compatible web template, 
	Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- stylesheets -->
    <link rel="stylesheet" href="css/font-awesome.css">
    <link rel="stylesheet" href="css/style.css">
    <!-- google fonts  
	<link href="//fonts.googleapis.com/css?family=Open+Sans" rel="stylesheet">
	<link href="//fonts.googleapis.com/css?family=Raleway:400,500,600,700" rel="stylesheet">-->
    <style>
	/* Animation stuff */
@keyframes fade-in {
    0% { opacity: 0; }
    100% { opacity: 1; }
}


@keyframes fade-out {
    0% { opacity: 1; }
    100% { opacity: 0; }
}

.fade-in {
    animation: fade-in 2s 2s forwards linear;
}

.fade-out {
    animation: fade-out 1s 1s forwards linear;
}


	
	</style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="agile-login" style="padding-top: 250px;">
        <h1>
            <img src="images/lizay_logo.png" class="fade-out" style="width: 50%; height: 50%;
                opacity: 1;" /></h1>

        <div class="wrapper fade-in" style="opacity: 0; margin-top: -250px;">
            <h2>
                <img src="images/lizay_logo.png" style="width: 25%; height: 25%;" /></h2>
            <div class="w3ls-form">
                <label>
                    Kullanıcı Adı</label>
                <input type="text" name="name" placeholder="****************" id="txtUsername" runat="server" />
                <input type="hidden" name="DeviceId" placeholder="****************" id="DeviceId" runat="server" />
                <input type="hidden" name="DeviceType" placeholder="****************" id="DeviceType" runat="server" />
                <label>
                    Parola</label>
                <input type="password" name="password" placeholder="****************" id="txtPassword"  runat="server" />
              <%--  <a href="#" class="pass">Parolamı Unuttum</a>--%>
                <asp:Button ID="btnLogin" OnClick="btnLogin_Click" runat="server" Text="Giriş Yap" />
                  <asp:Button ID="btnBack" OnClick="btnBack_Click" runat="server" Text="Ürün Sayfasına Dön" />
                <asp:Literal ID="ltWarningBox" runat="server" />
               
            </div>
        </div>
        <br>
    </div>
  
    </form>
</body>
</html>
