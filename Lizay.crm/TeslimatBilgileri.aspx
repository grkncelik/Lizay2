<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeslimatBilgileri.aspx.cs" Inherits="Lizay.crm.TeslimatBilgileri" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">
            <div id="slide-out-left" class="side-nav">
                 <div class="top-left-nav" style="padding-left: 30%;">
            
                    <img src="template/sidebarlogo.png" style="width: 40%"/>
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
                        <a href="#" id="menu-left" data-activates="slide-out-left"><i class="fa fa-bars"></i></a>
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
                        <div class="content-article">
                            <h1 class="entry-title page">Teslimat Bilgileri</h1>
                    
                            <div class="entry-content">
                                <p>
                                    Lizaypirlanta.com’dan yaptığınız alışverişlerde siparişiniz anlaşmalı kargo firması aracılığı ile sigortalı olarak teslimat adresinize gönderilmektedir. Siparişinizin durumunu, sipariş takibi sayfasından inceleyebilirsiniz. Siparişiniz kargo firmasına teslim edildiğinde e-posta ile bilgilendirilirsiniz. Hazırlanan siparişler kargo firmasına Cumartesi, Pazar, resmi tatil ve bayram günleri dışında teslim edilmekte olup, kargo firması resmi tatil ve bayram günleri dışında teslimat yapmaktadır.
                                </p>
                                <p>
                                    Kargo firmasına teslim edilen siparişlerin, kargo firmasının teslimat yapmadığı günler dışında 48 saat içinde elinizde olması beklenmektedir. Bu süre sonunda siparişiniz elinize ulaşmazsa iletişim formunu kullanarak bizimle iletişim kurabilirsiniz.
                                </p>
                                <p>
                                    Siparişinizin, alışveriş sırasında belirttiğiniz teslimat adresine teslim edilebilmesi için, ödemenizi kredi kartı kullanarak gerçekleştirdiyseniz, 3D Secure güvenlik sisteminin onayının alınmış olması gerekmektedir. Ödeme için havale/EFT seçeneğini tercih ettiyseniz, havale/EFT’yi banka hesaplarımıza göndermeniz ve ardından dekontunuzu siparis@lizaypirlanta.com adresine mail yolu ile bildirmeniz ve ayrıca havale/eft açıklama kısmına sipariş numaranızı ve adınızı soyadınızı belirtmeniz gerekmektedir.
                                </p>
                                <p>
                                    Ödemeniz onaylandıktan sonra, ikinci aşama olarak ürünler, sipariş sırasında belirttiğiniz tercihleriniz doğrultusunda size özel olarak hazırlanır. Ürünlerin hazırlanması, ödemenin onaylanmasından sonra 1-10 gün arasında sürmektedir. Hazırlık safhasının, bu süreyi aşması durumunda e-posta veya telefon ile bilgilendirilirsiniz. Lizaypirlanta.com’dan aldığınız her ürün, LİZAY markasını taşır, LİZAY standartlarında üretilir, kalite ayar sertifikası ile birlikte sunulur.
                                </p>
                                <p>
                                    Teslimat adresi ve fatura adresinin aynı olduğu siparişlerde, ürün, fatura ve irsaliye belgeleriyle birlikte teslim edilecektir. Teslimat adresi ve fatura adresinin farklı olduğu siparişlerde, ürünün faturası, fatura adresine gönderilecek, ürünün irsaliyesi ise, ürünle birlikte teslimat adresine gönderilecektir.
                                </p>
                                <p>
                                    Teslimat adresinde alıcının bulunamaması halinde, kargo firması ziyaret ihbar notu bırakmaktadır. Adresine, ziyaret ihbar notu bırakılan alıcının 3 gün içinde kargo firmasıyla irtibata geçmemesi halinde, kargo firması paketi Lizaypirlanta.com’a geri getirecektir.
                                </p>

                                <p>
                                    Siparişlerinizi teslim almadan önce kesinlikle ürününüzü kontrol ediniz. Ürünlerinizi kontrol ettikten sonra teslim alınız. Ürünlerin eksik ya da hasarlı olduğunu düşündüğünüz durumda, kargo yetkilisine tutanak tutturarak paketi teslim almayınız ve Lizaypirlanta.com yetkilisi ile iletişime geçiniz. Sigorta şartı ürün kapıda teslim alındığı anda son bulunmaktadır. Bu sebeple ürünü kontrol ederek teslim almanız kendi lehinize olacaktır. Ürünü teslim aldığınızda, kargo firmasının görevini tam olarak yerine getirdiğini kabul etmiş olursunuz.
                                </p>
                            </div>
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

