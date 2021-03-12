<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UrunDetay.aspx.cs" Inherits="Lizay.crm.UrunDetay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Ürün Ekranı</title>

    <link rel="shortcut icon" href="https://www.lizaypirlanta.com/ico/favicon2.ico">

    <link href="assets/barkodOkuma/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/barkodOkuma/css/carousel.css" rel="stylesheet" />
    <link href="assets/barkodOkuma/css/style.css" rel="stylesheet" />
    <link href="assets/barkodOkuma/css/font-awasome.css" rel="stylesheet" />
    <link href="assets/barkodOkuma/css/fonts.css" rel="stylesheet" />
    <link href="assets/barkodOkuma/css/lightslider.css" rel="stylesheet" />

    <link href="assets/css/icons/icomoon/styles.css" rel="stylesheet" type="text/css">
    <link href="assets/css/components.css" rel="stylesheet" type="text/css">
    <link href="assets/css/colors.css" rel="stylesheet" type="text/css">
    
    <link href="assets/barkodOkuma/css/loading.css" rel="stylesheet" />

    <script type="text/javascript" src="assets/js/plugins/loaders/pace.min.js"></script>
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/bootstrap.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/loaders/blockui.min.js"></script>
    
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>        
    <![endif]-->
    <style>
        ul {
            list-style: none outside none;
            padding-left: 0;
            margin: 0;
        }

        .item {
            margin-bottom: 60px;
        }

        .content-slider li {
            background-color: #ed3020;
            text-align: center;
            color: #FFF;
        }

        .content-slider h3 {
            margin: 0;
            padding: 70px 0;
        }
    </style>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script src="assets/barkodOkuma/js/lightslider.js"></script>
    <script>
        $(document).ready(function () {
            $("#content-slider").lightSlider({
                loop: true,
                keyPress: true
            });
            $('#image-gallery').lightSlider({
                gallery: true,
                item: 1,
                thumbItem: 9,
                slideMargin: 0,
                speed: 500,
                auto: true,
                loop: true,
                onSliderLoad: function () {
                    $('#image-gallery').removeClass('cS-hidden');
                }
            });
        });
    </script>

    <style>
        .navbar-inverse {
            background-color: #304352;
            border-color: #304352;
        }

        .thumbnail .caption {
            padding: 12px;
            padding-top: 0px;
        }

        .page-container {
            position: relative;
            background-color: white;
        }

        .panel-flat > .panel-heading {
            padding-top: 20px;
            padding-bottom: 20px;
            background-color: transparent !important;
        }

        .panel {
            margin-bottom: 20px;
            background-color: transparent !important;
            border: 1px;
            border-radius: 3px;
            -webkit-box-shadow: 1px 1px rgba(0, 0, 0, 0);
            box-shadow: 1px 1px rgba(0, 0, 0, 0);
        }

        .tabs .tab a:hover, .tabs .tab a.active {
            background-color: transparent;
            color: #000000;
        }

        .tabs .tab a {
            color: rgba(72, 62, 62, 0.7);
            display: block;
            width: 100%;
            height: 100%;
            padding: 0 24px;
            font-size: 14px;
            text-overflow: ellipsis;
            overflow: hidden;
            -webkit-transition: color .28s ease;
            transition: color .28s ease;
        }

        .tabs .indicator {
            position: absolute;
            bottom: 0;
            height: 2px;
            background-color: #372829;
            will-change: left, right;
        }
    </style>
    <style>
        .text-muted {
            color: #ff0000;
            font-weight: 500;
        }

        .panel {
            margin-bottom: 20px;
            background-color: #fff;
            border: 1px; /* 1px solid #fafafa; */
            border-radius: 3px;
            -webkit-box-shadow: 1px 1px rgba(0, 0, 0, 0);
            box-shadow: 1px 1px rgba(0, 0, 0, 0);
        }

        .panel-heading {
            padding: 15px 8px;
            border-bottom: 1px solid transparent;
            border-top-right-radius: 2px;
            border-top-left-radius: 2px;
        }

        .media {
            border: 1px solid rgba(0, 0, 0, 0.1);
            -webkit-box-shadow: 1px 1px rgba(0, 0, 0, 0.1);
            box-shadow: 1px 1px rgba(0, 0, 0, 0.1);
        }

        .nav-tabs:before {
            content: '';
            color: inherit;
            font-size: 12px;
            line-height: 1.6666667;
            margin-top: 0px;
            margin-left: 0px;
            margin-bottom: 0px;
            text-transform: uppercase;
            opacity: 0.5;
            filter: alpha(opacity=50);
        }


        .tile, .tile1 {
            position: relative;
        }

        .float {
            position: relative;
            display: inline-block;
            width: 60px;
            height: 60px;
            line-height: 45px;
            background-color: #26a69a;
            color: #FFF;
            cursor: pointer;
            border-radius: 50px;
            text-align: center;
            z-index: 1000;
            animation: bot-to-top 2s ease-out;
        }

        .tile .float {
            box-shadow: 0px 0px 8px 2px rgba(57, 206, 206, 0.3);
            -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);
            box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);
        }

        .waves-effect {
            -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);
            box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);
        }

        .tabs {
            -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.14), 0 1px 5px 0 rgba(0,0,0,0.12), 0 3px 1px -2px rgba(0,0,0,0.2);
            box-shadow: 0 2px 2px 0 rgba(0,0,0,0.14), 0 1px 5px 0 rgba(0,0,0,0.12), 0 3px 1px -2px rgba(0,0,0,0.2);
        }

        .tile1 .float {
            background-color: #e75b5b;
            box-shadow: 0px 0px 8px 2px rgba(231, 91, 91, 0.3);
        }

        .soc a {
            color: #FFF;
            border-radius: 50%;
            text-align: center;
            width: 50px;
            height: 50px;
            line-height: 53px;
            padding: 0px;
            font-size: 20px;
            display: inline-block;
            position: absolute;
            top: 5px;
            left: 6px;
            transition: all .5s;
        }

            .soc a:hover {
                box-shadow: 2px 2px 3px #999;
            }

        a.sira1 {
            background-color: #4E71A8;
            animation-delay: .5s;
        }

        a.sira2 {
            animation-delay: .7s;
            background-color: #E3411F;
        }

        a.sira3 {
            animation-delay: .15s;
            background-color: #1CB7EB;
        }

        a.sira4 {
            animation-delay: .15s;
            background-color: #ef9a00;
        }

        a.sira5 {
            animation-delay: .15s;
            background-color: #26a69a;
        }

        a.sira6 {
            animation-delay: .15s;
            background-color: #e75b5b;
        }

        a.sira7 {
            animation-delay: .15s;
            background-color: #52504c;
        }

        .pad .sira1 {
            left: -60px;
        }

        .pad .sira2 {
            left: -120px;
        }

        .pad .sira3 {
            left: -180px;
        }

        .pad .sira4 {
            left: -240px;
        }

        .pad .sira5 {
            left: -300px;
        }

        .pad .sira6 {
            left: -360px;
        }

        .pad .sira7 {
            left: -420px;
        }

        .my-float {
            font-size: 24px;
            margin-top: 20px;
        }

        .tile1 .float {
            font-size: 24px;
        }

        .menu-share i {
            animation: rotate-in 0.5s;
        }

        /* .tile .menu-share:hover > i{
			animation: rotate-out 0.5s;
		} */

        @keyframes rotate-in {
            from {
                transform: rotate(0deg);
            }

            to {
                transform: rotate(360deg);
            }
        }

        @keyframes rotate-out {
            from {
                transform: rotate(360deg);
            }

            to {
                transform: rotate(0deg);
            }
        }

        .nav-tabs > li.active > a:after, .nav-tabs > li.active > a:hover:after, .nav-tabs > li.active > a:focus:after {
            content: '';
            position: absolute;
            top: 0;
            left: -1px;
            bottom: 0;
            width: 0px;
            background-color: #2196F3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:UpdateProgress ID="updateProgress" runat="server">
                    <ProgressTemplate>
                        <div class="loadingBackground">
                            <asp:Image ID="imgUpdateProgress" CssClass="loadingImg" runat="server" ImageUrl="assets/images/loading1.gif" AlternateText="Lütfen Bekleyiniz ..." ToolTip="Lütfen Bekleyiniz ..." />
                            <br />
                            <span class="loadingText">Lütfen Bekleyiniz</span>
                        </div>
                    </ProgressTemplate>
                </asp:UpdateProgress>
                <div class="navbar navbar-inverse">
                    <div class="navbar-header">
                        <a class="navbar-brand" href="/">
                            <img src="assets/images/lizay_logo.png" style="width: 18%; height: auto; margin-left: 45%; margin-top: -5px;" alt="" /></a>
                    </div>
                </div>
                <div class="row" style="padding: 0px; margin-left: 0px; margin-right: 0px;">
                    <div class="col-lg-12" style="padding-left: 0px; padding-right: 0px;">
                        <div class="panel panel-flat">
                            <div class="panel-heading">
                                <div class="tile pull-right" style="padding-bottom: 20px;">
                                    <div class="float menu-share">
                                        <i class=" icon-menu my-float"></i>
                                    </div>
                                    <div class="soc">
                                        <a href="urunarama.aspx" class="sira1 waves-effect waves-light btn"><i class="icon-barcode2" style="padding-top: 0px; font-size: 23px;"></i></a>
                                        <%--<a href="urunlisteleme.aspx" class="sira1 waves-effect waves-light btn"><i class="icon-list" style="padding-top: 0px; font-size: 23px;"></i></a>--%>
                                        <a href="profile.aspx" class="sira2 waves-effect waves-light btn"><i class="icon-user" style="padding-top: 0px; font-size: 23px;"></i></a>
                                        <a href="rozetsiralama.aspx" class="sira3 waves-effect waves-light btn"><i class="icon-trophy3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                        <a href="siralama.aspx" class="sira4 waves-effect waves-light btn"><i class=" icon-cash3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                        <a href="default.aspx" class="sira5 waves-effect waves-light btn"><i class=" icon-home" style="padding-top: 0px; font-size: 23px;"></i></a>

                                        <% if (CurrentUser.USER_TYPE == "ADMIN")
                                            { %>
                                        <a href="yonetim.aspx" class="sira6 waves-effect waves-light btn"><i class="icon-gear" style="padding-top: 0px; font-size: 23px;"></i></a>
                                        <%} %>
                                        <% if (CurrentUser.USER_TYPE == "PERSONEL" || CurrentUser.USER_TYPE == "MUDUR")
                                            { %>
                                        <a href="logout.aspx" class="sira6 waves-effect waves-light btn red"><i class=" icon-exit3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                        <%} %>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="container p15">
                    <div class="row">
                        <div class="col-lg-6 col-xs-6 magazalar">
                            <a href="https://www.lizaypirlanta.com/magazalar/istanbul-Merkez"><i class="fa fa-map-marker" style="padding-right: 6px;"></i>MAĞAZALARIMIZ</a>
                        </div>

                        <div class="col-lg-6 col-xs-6">
                            <span class="phone pull-right">
                                <i class="fa fa-phone" aria-hidden="true" style="padding-right: 6px;"></i>0212 514 67 64</span>
                        </div>
                    </div>
                </div>
                <div class="cizgi"></div>
                <div class="container">
                    <div class="row">
                        <div class="col-lg-5 col-xs-12"></div>
                        <div class="col-lg-2 col-xs-12">
                            <img src="https://www.lizaypirlanta.com/images/logo.png" class="img-responsive p10 ortala" />
                        </div>
                        <div class="col-lg-5 col-xs-12"></div>
                    </div>
                </div>
                <div class="cizgi"></div>
                <div class="container" style="margin-top: 30px;">
                    <div class="row">
                        <div class="col-md-5 col-xs-12">
                            <div class="item">
                                <div class="clearfix" style="max-width: 474px;">
                                    <asp:Literal runat="server" ID="ltMainProductPicture"></asp:Literal>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-xs-12 borderr">
                            <asp:Literal runat="server" ID="ltMainProduct"></asp:Literal>
                        </div>
                    </div>

                    <%--Benzer Ürünler--%>
                    <div class="row" style="margin-top: 30px;">
                        <div class="col-lg-12 col-xs-12" style="text-align: center;">
                            <p style="font-size: 22px; font-weight: bold;">BENZER ÜRÜNLER</p>
                        </div>
                    </div>
                    <asp:Literal runat="server" ID="ltAlternativeProduct"></asp:Literal>
                    <%--   <div class="row" style="margin-top: 30px;">
            <div class="col-lg-3 col-xs-12">
                <div class="col-lg-12">
                    <img src="https://www.lizaypirlanta.com/resim/urun/lizay-pirlanta-tektas-yuzukler-DR23047-1558691500-1.jpg" class="img-responsive shadow" />
                </div>
                <div class="col-lg-12 col-xs-12" style="margin-top: 15px; margin-bottom: 7px;">
                    0.08 Karat Pırlanta Tektaş Yüzük
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Taş:</div>
                    <p class="sag1">Pırlanta</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Taş Özellikleri:</div>
                    <p class="sag1">Pırlanta</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Montür:</div>
                    <p class="sag1">Beyaz Altın</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Ağırlık:</div>
                    <p class="sag1">1.86gr</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Kesim:</div>
                    <p class="sag1">Yuvarlak</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Fiyat:</div>
                    <p class="sag1">1500 TL</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Son Satılamaz Kuru:</div>
                    <p class="sag1">$</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Etiket:</div>
                    <p class="sag1 ustucizik">1800$</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Maliyet Kuru:</div>
                    <p class="sag1">$</p>
                </div>
            </div>
            <div class="col-lg-3 col-xs-12">
                <div class="col-lg-12">
                    <img src="https://www.lizaypirlanta.com/resim/urun/lizay-pirlanta-tektas-yuzukler-DR23047-1558691500-1.jpg" class="img-responsive shadow" />
                </div>
                <div class="col-lg-12 col-xs-12" style="margin-top: 15px; margin-bottom: 7px;">
                    0.08 Karat Pırlanta Tektaş Yüzük
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Taş:</div>
                    <p class="sag1">Pırlanta</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Taş Özellikleri:</div>
                    <p class="sag1">Pırlanta</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Montür:</div>
                    <p class="sag1">Beyaz Altın</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Ağırlık:</div>
                    <p class="sag1">1.86gr</p>
                </div>

                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Kesim:</div>
                    <p class="sag1">Yuvarlak</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Fiyat:</div>
                    <p class="sag1">1500 TL</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Son Satılamaz Kuru:</div>
                    <p class="sag1">$</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Etiket:</div>
                    <p class="sag1 ustucizik">1800$</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Maliyet Kuru:</div>
                    <p class="sag1">$</p>
                </div>
            </div>
            <div class="col-lg-3 col-xs-12">
                <div class="col-lg-12">
                    <img src="https://www.lizaypirlanta.com/resim/urun/lizay-pirlanta-tektas-yuzukler-DR23047-1558691500-1.jpg" class="img-responsive shadow" />
                </div>
                <div class="col-lg-12 col-xs-12" style="margin-top: 15px; margin-bottom: 7px;">
                    0.08 Karat Pırlanta Tektaş Yüzük
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Taş:</div>
                    <p class="sag1">Pırlanta</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Taş Özellikleri:</div>
                    <p class="sag1">Pırlanta</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Montür:</div>
                    <p class="sag1">Beyaz Altın</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Ağırlık:</div>
                    <p class="sag1">1.86gr</p>
                </div>

                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Kesim:</div>
                    <p class="sag1">Yuvarlak</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Fiyat:</div>
                    <p class="sag1">1500 TL</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Son Satılamaz Kuru:</div>
                    <p class="sag1">$</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Etiket:</div>
                    <p class="sag1 ustucizik">1800$</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Maliyet Kuru:</div>
                    <p class="sag1">$</p>
                </div>
            </div>
            <div class="col-lg-3 col-xs-12">
                <div class="col-lg-12">
                    <img src="https://www.lizaypirlanta.com/resim/urun/lizay-pirlanta-tektas-yuzukler-DR23047-1558691500-1.jpg" class="img-responsive shadow" />
                </div>
                <div class="col-lg-12 col-xs-12" style="margin-top: 15px; margin-bottom: 7px;">
                    0.08 Karat Pırlanta Tektaş Yüzük
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Taş:</div>
                    <p class="sag1">Pırlanta</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Taş Özellikleri:</div>
                    <p class="sag1">Pırlanta</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Montür:</div>
                    <p class="sag1">Beyaz Altın</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Ağırlık:</div>
                    <p class="sag1">1.86gr</p>
                </div>

                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Kesim:</div>
                    <p class="sag1">Yuvarlak</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Fiyat:</div>
                    <p class="sag1">1500 TL</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Son Satılamaz Kuru:</div>
                    <p class="sag1">$</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Etiket:</div>
                    <p class="sag1 ustucizik">1800$</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Maliyet Kuru:</div>
                    <p class="sag1">$</p>
                </div>
            </div>
            <div class="col-lg-3 col-xs-12">
                <div class="col-lg-12">
                    <img src="https://www.lizaypirlanta.com/resim/urun/lizay-pirlanta-tektas-yuzukler-DR23047-1558691500-1.jpg" class="img-responsive shadow" />
                </div>
                <div class="col-lg-12 col-xs-12" style="margin-top: 15px; margin-bottom: 7px;">
                    0.08 Karat Pırlanta Tektaş Yüzük
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Taş:</div>
                    <p class="sag1">Pırlanta</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Taş Özellikleri:</div>
                    <p class="sag1">Pırlanta</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Montür:</div>
                    <p class="sag1">Beyaz Altın</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Ağırlık:</div>
                    <p class="sag1">1.86gr</p>
                </div>

                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Kesim:</div>
                    <p class="sag1">Yuvarlak</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Fiyat:</div>
                    <p class="sag1">1500 TL</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Son Satılamaz Kuru:</div>
                    <p class="sag1">$</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Etiket:</div>
                    <p class="sag1 ustucizik">1800$</p>
                </div>
                <div class="col-lg-12 col-xs-12">
                    <div class="sol1">Maliyet Kuru:</div>
                    <p class="sag1">$</p>
                </div>
            </div>




        </div>--%>
                </div>


                <script src="assets/barkodOkuma/js/hover.js"></script>
                <script src="assets/barkodOkuma/js/holder.min.js"></script>
                <script src="assets/barkodOkuma/js/lightslider.js"></script>
                <script src="assets/barkodOkuma/js/ie10-viewport-bug-workaround.js"></script>
                <script src="assets/barkodOkuma/js/bootstrap.min.js"></script>


                <script>
                    window.onscroll = function () { myFunction() };

                    var navbar = document.getElementById("sabitmenu");
                    var sticky = navbar.offsetTop;

                    function myFunction() {
                        if (window.pageYOffset >= sticky) {
                            navbar.classList.add("sticky")
                        } else {
                            navbar.classList.remove("sticky");
                        }
                    }
                </script>

                <script>
                    $(document).ready(function () {
                        // -----------------------------------------------------------------------
                        $.each($('#navbar').find('li'), function () {
                            $(this).toggleClass('active',
                                window.location.pathname.indexOf($(this).find('a').attr('href')) > -1);
                        });
                        // -----------------------------------------------------------------------
                    });
                </script>
                <script src="assets/barkodOkuma/js/up.js"></script>

                <script>
                    $(".tile .float").click(function () {
                        $(this).html($(this).html() == '<i class="icon-cross2 my-float"></i>' ? '<i class="icon-menu my-float"></i>' : '<i class="icon-cross2 my-float"></i>');
                        $(".tile .soc").toggleClass("pad");
                    });
                    /* 2nd button */
                    $(".tile1 .float").click(function () {
                        $(this).html($(this).html() == '<i class="icon-close2"></i>' ? '<i class="fa fa-ellipsis-h"></i>' : '<i class="icon-close2"></i>');
                        $(".tile1 .soc").toggleClass("pad1");
                    });
                    /* 3rd button */
                    $(".tile2 .float").click(function () {
                        $(this).html($(this).html() == '<i class="icon-close2 my-float"></i>' ? '<i class="fa fa-th my-float"></i>' : '<i class="icon-close2 my-float"></i>');
                        $(".tile2 .soc").toggleClass("active");
                    });

                </script>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
