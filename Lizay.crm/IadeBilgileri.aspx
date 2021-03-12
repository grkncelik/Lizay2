<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IadeBilgileri.aspx.cs" Inherits="Lizay.crm.IadeBilgileri" %>

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
                            <h1 class="entry-title page">İade Bilgileri</h1>
                 
                            <div class="entry-content">
                                <p>
                                    Siparişinizi iptal ve iade etmek için öncelikle 0(212) 511 32 22 numaralı destek hattımıza bu talebinizi bildirmeniz ve paketi geri göndermek için gerekli olan adres bilgilerini almanız gerekmektedir. Paketin bize gelişi sırasındaki tüm sorumluluk tüketiciye aittir. Ürün tarafımıza ulaştıktan sonra gerekli incelemelerin ardından siparişiniz iptal edilecektir. Eğer siparişiniz size gönderilmemiş ise, destek hattımıza talebinizi belirttiğiniz anda siparişiniz iptal edilecektir.
                                </p>
                                <p>
                                    Ürün iadesi işlemlerinde, 4077 Sayılı Tüketicinin Korunması Hakkındaki Kanun hükümleri uygulanır. Müşteri, sözleşme konusu ürünün kendisine veya gösterdiği adresteki kişi/kuruluşa tesliminden itibaren 7 gün içinde cayma hakkına sahiptir. Cayma hakkının kullanılması için müşterinin, bu süre içinde Lizaypirlanta.com’a faks, e-posta veya telefon ile bildirimde bulunması ve ürünün kullanılmamış olması şarttır. Cayma hakkının kullanılması halinde, 3. kişiye veya Müşteri'ye teslim edilen ürünün Lizaypirlanta.com'a gönderildiğine ilişkin kargo teslim tutanağı örneği ile fatura aslının iadesi zorunludur. Bu belgelerin ulaşmasını takip eden 7 gün içinde ürün bedeli müşteriye iade edilir. Fatura aslı gönderilmez ise KDV ve varsa diğer yasal yükümlülükler iade edilemez. Cayma hakkı nedeni ile iade edilen ürünün kargo bedeli müşteri tarafından karşılanır.
                                </p>
                                <p>
                                    Müşterinin özel istek ve talepleri uyarınca üretilen veya üzerinde değişiklik ya da ilaveler yapılarak kişiye özel hale getirilen ürünlerde müşteri cayma hakkını kullanamaz. Bu nedenle müşterinin sipariş sırasında seçeceği parmak ölçüsüne göre ayarlanacağı için tüm yüzükler, müşterinin istekleri doğrultusunda, altın kısımların üzerine ya da içine yazı yazılan ürünler, müşterinin istekleri doğrultusunda üretilen tüm ürünler cayma hakkının kullanılamayacağı ürünler kapsamında yer alır.
                                </p>
                                <p>
                                    İade etmek istediğiniz siparişlerinizin, size gönderilen şekliyle, ürün, fatura, irsaliye, sertifika, ürün kutusu, ambalajı ve diğer tüm evrak ve materyallerin, eksiksiz olarak, size bildireceğimiz adrese gönderilmesi gerekmektedir. İade gönderimi sırasında, kargo firmalarından, ya da iade işlemini gerçekleştiren müşteriden kaynaklanan sebeplerle, ürün ve ürünle birlikte gönderilen evrak ve materyallerde meydana gelen bozulma ya da benzeri değer kaybettirici her türlü durumun sorumluluğu iadeyi gerçekleştiren müşteriye aittir. Bildirim için müşteri ilişkileri iletişim formunu kullanabilir, ya da siparis@lizaypirlanta.com adresine e-posta gönderebilirsiniz. Lizaypirlanta.com’dan onay alınmadan iade işlemini gerçekleştirmeniz durumunda, iade işleminiz kabul edilmeyerek gönderiniz teslim alınmayacaktır.
                                </p>
                                <p>
                                    İade alındıktan sonra, iade şartlarının yerine getirilip getirilmediği uzmanlar tarafından incelenir. İade onaylanırsa, 7 gün içinde ürünlerin bedeli sipariş kredi kartı kullanılarak verildiyse kredi kartına, havale/EFT yoluyla verildiyse banka hesabına iade edilir. İadenizin kredi kartı hesabınıza yansıması 1-4 hafta arasında sürmektedir.
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

