<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Lizay.crm.Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Lizay Pırlanta </title>
    <meta charset="utf-8" />
    <meta content="IE=edge" http-equiv="x-ua-compatible" />
    <meta content="initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no" name="viewport" />
    <meta content="yes" name="apple-mobile-web-app-capable" />
    <meta content="yes" name="apple-touch-fullscreen" />
    <link rel="stylesheet" type="text/css" href="template/css/style.css" />
    <link rel="stylesheet" type="text/css" href="template/css/responsive.css" />
    <link rel="shortcut icon" href="template/images/favicon.png" />

    <style>
        .footer {
            position: fixed;
            left: 0px;
            bottom: 0px;
            height: auto;
            width: 100%;
        }

                #btnTamamla {
        width:100%;
        
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">
            <div id="slide-out-left" class="side-nav">
                <div class="top-left-nav" style="padding-left: 30%;">

                    <img src="template/sidebarlogo.png" style="width: 40%" />
                </div>
                <div id="main-menu">
                    <ul>
                        <li><a href="HomePage.aspx"><i class="fa fa-home"></i>Anasayfa </a></li>
                        <li class="has-sub"><a href="#"><i class="fa fa-th-list"></i>Kategoriler </a>
                            <ul>
                                <li class="has-sub"><a href="#">Yüzük </a>
                                    <ul>
                                        <asp:Repeater ID="rptyuzuk" runat="server">
                                            <ItemTemplate>
                                                <li><a href="CategoryList.aspx?Id=<%# ((Lizay.dll.entity.CATEGORY)Container.DataItem).ID%> "><%# ((Lizay.dll.entity.CATEGORY)Container.DataItem).NAME%>  </a></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </li>

                                <li class="has-sub"><a href="#">Kolye </a>
                                    <ul>
                                        <asp:Repeater ID="rptkolye" runat="server">
                                            <ItemTemplate>
                                                <li><a href="CategoryList.aspx?Id=<%# ((Lizay.dll.entity.CATEGORY)Container.DataItem).ID%>"><%# ((Lizay.dll.entity.CATEGORY)Container.DataItem).NAME%>  </a></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </li>

                                <li class="has-sub"><a href="#">Küpe </a>
                                    <ul>
                                        <asp:Repeater ID="rptkupe" runat="server">
                                            <ItemTemplate>
                                                <li><a href="CategoryList.aspx?Id=<%# ((Lizay.dll.entity.CATEGORY)Container.DataItem).ID%>"><%# ((Lizay.dll.entity.CATEGORY)Container.DataItem).NAME%>  </a></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </li>

                                <li class="has-sub"><a href="#">Bileklik </a>
                                    <ul>
                                        <asp:Repeater ID="rptbileklik" runat="server">
                                            <ItemTemplate>
                                                <li><a href="CategoryList.aspx?Id=<%# ((Lizay.dll.entity.CATEGORY)Container.DataItem).ID%>"><%# ((Lizay.dll.entity.CATEGORY)Container.DataItem).NAME%> </a></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </li>

                            </ul>
                        </li>
                        <li class="has-sub"><a href="#"><i class="fa fa-users"></i>Kurumsal </a>
                            <ul>
                                <li><a href="BaskanMesaji.aspx">Başkanın Mesajı </a></li>
                                <li><a href="Tarihce.aspx">Tarihçe </a></li>
                                <li><a href="Degerlerimiz.aspx">Değerlerimiz </a></li>
                                <li><a href="CalismaPolitika.aspx">Çalışma Politikamız </a></li>
                                <li><a href="Franchise.aspx">Franchise </a></li>
                            </ul>
                        </li>
                        <li class="has-sub"><a href="#"><i class="fa fa-file-text-o"></i>Müşteri Hizmetleri </a>
                            <ul>
                                <li><a href="HesapNumaralari.aspx">Hesap Numaraları </a></li>
                                <li><a href="YuzukOlcu.aspx">Yüzük Ölçüsü Hakkında</a></li>
                                <li><a href="TeslimatBilgileri.aspx">Teslimat Bilgileri </a></li>
                                <li><a href="GarantiSartlari.aspx">Garanti Şartları </a></li>
                                <li><a href="IadeBilgileri.aspx">İade Bilgileri </a></li>
                            </ul>
                        </li>
                        <li class="has-sub"><a href="#"><i class="fa fa-file"></i>Mağazalarımız </a>
                            <ul>
                                <asp:Repeater ID="rptmagaza" runat="server">
                                    <ItemTemplate>
                                        <li><a href="StoreDetail.aspx?Id=<%# ((Lizay.dll.entity.STORE)Container.DataItem).ID%>"><%# ((Lizay.dll.entity.STORE)Container.DataItem).NAME%> </a></li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </li>
                        <li><a href="Contact.aspx"><i class="fa fa-envelope"></i>İletişim </a></li>
                    </ul>
                </div>
            </div>

            <div id="page">
                <div class="top-navbar">
                    <div class="top-navbar-left">
                   <asp:Literal ID="ltrBack" runat="server"></asp:Literal>
                    </div>
                    <%--   <div class="top-navbar-right">
                        <a href="#" class="dropdown-button" data-activates="dropdown1"><i class="fa fa-lock"></i></a>
                        <ul id="dropdown1" class="dropdown-content">
                            <li><a href="Login.aspx"><i class="fa fa-sign-in"></i>Mağaza Girişi</a></li>

                        </ul>
                    </div>--%>
                    <div class="site-title">
                        <img src="https://www.lizaypirlanta.com/images/logo.png" style="width: 30%" />
                    </div>
                </div>

                <div class="content-container animated fadeInUp">
                    <div class="page-block margin-bottom">
                        <h1 class="page-title">Sipariş Ekranı</h1>
                        <div class="shofy-form">
                            <div class="input-field">
                                <h3 class="out-label">Sipariş Tarihi </h3>
                                <input type="text" id="txtOrderDate" runat="server" readonly="true" />
                            </div>
                            <div class="input-field">
                                <h3 class="out-label">Sipariş No </h3>
                                <input type="text" id="txtOrderno" runat="server" readonly="true" />
                            </div>
                            <div class="input-field">
                                <h3 class="out-label">Ürün Adı </h3>
                                <input type="text" id="txtProductName" runat="server" readonly="true" />
                            </div>
                            <div class="input-field">
                                <h3 class="out-label">Ürün Kodu </h3>
                                <input type="text" id="txtProductCode" runat="server" readonly="true" />
                            </div>
                            <div class="input-field">
                                <h3 class="out-label">Fiyat </h3>
                                <input type="text" id="txtAmount" runat="server" readonly="true" />
                            </div>
                            <div class="input-field" id="divolcu" runat="server" visible="false">
                                <h3 class="out-label">Yüzük Ölçüsü </h3>
                                <%--     <span class="desc">Yüzük Ölçüsü Hakkında </span>--%>
                                <asp:DropDownList ID="dropOlcu" runat="server"></asp:DropDownList>
                                
                            </div>
                            <div class="input-field" id="divyazi" runat="server" visible="false">
                                <h3 class="out-label">Ürüne Yazı Yazdırabilirsiniz </h3>
                                <input type="text" id="txtText" runat="server" />
                            </div>


                                    <div class="input-field">
                                        <h3 class="out-label">Ödeme Tipi (*)</h3>
                                        <asp:DropDownList ID="dropOdemeTip" runat="server" AutoPostBack="true" OnSelectedIndexChanged="OnSelectedIndexChanged"></asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="reqdropOdemeTip" runat="server" ControlToValidate="dropOdemeTip" ErrorMessage="Lütfen ödeme tipi seçiniz." ForeColor="red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>

                                    <div class="input-field" id="divmagaza" runat="server" visible="false">
                                        <h3 class="out-label">Mağaza </h3>
                                        <asp:DropDownList ID="dropMagaza" runat="server"></asp:DropDownList>

                                    </div>

                       
                            <div class="input-field">
                                <h3 class="out-label">Adınız Soyadınız (*)</h3>
                                <input type="text" id="txtFullName" runat="server" />
                                <asp:RequiredFieldValidator ID="reqtxtFullName" runat="server" ControlToValidate="txtFullName" ErrorMessage="Lütfen ad soyad giriniz." ForeColor="red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field">
                                <h3 class="out-label">Telefon Numaranız (*)</h3>
                                <input type="text" id="txtPhone" runat="server" />
                                <asp:RequiredFieldValidator ID="reqtxtPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="Lütfen telefon numarası giriniz." ForeColor="red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field">
                                <h3 class="out-label">Email Adresiniz (*)</h3>
                                <input type="text" id="txtEmail" runat="server" />
                                <asp:RequiredFieldValidator ID="reqtxtEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Lütfen email adresi giriniz." ForeColor="red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                            <div class="input-field">
                                <h3 class="out-label">Adresiniz (*)</h3>
                                <input type="text" id="txtAddress" runat="server" />
                                <asp:RequiredFieldValidator ID="reqtxtAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="Lütfen adres giriniz." ForeColor="red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>

                            <div class="input-field">
                                <h3 class="out-label">Sipariş Notunuz </h3>
                                <input type="text" id="txtOrdernote" runat="server" />
                            </div>

                            <asp:Button ID="btnTamamla" OnClick="btnTamamla_Click" CssClass="btn block green" runat="server" Text="SİPARİŞİ TAMAMLA " />
                        </div>
                        <div class="clear"></div>
                    </div>
                </div>

                <div id="to-top" class="main-bg"><i class="fa fa-long-arrow-up"></i></div>
            </div>
        </div>
        <script type="text/javascript" src="template/js/jquery.js"></script>
        <script type="text/javascript" src="template/js/materialize.min.js"></script>
        <script type="text/javascript" src="template/js/slick.min.js"></script>
        <script type="text/javascript" src="template/js/jquery.slicknav.js"></script>
        <script type="text/javascript" src="template/js/jquery.swipebox.min.js"></script>
        <script type="text/javascript" src="template/js/custom.js"></script>
    </form>
</body>
</html>

