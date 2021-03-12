<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="urunarama.aspx.cs" Inherits="Lizay.crm.urunarama" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Ürün Ekranı</title>


    <link href="assets/barkodOkuma/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/barkodOkuma/css/carousel.css" rel="stylesheet" />
    <link href="assets/barkodOkuma/css/style.css" rel="stylesheet" />
    <link href="assets/barkodOkuma/css/font-awasome.css" rel="stylesheet" />
    <link href="assets/barkodOkuma/css/fonts.css" rel="stylesheet" />

    <link href="assets/css/icons/icomoon/styles.css" rel="stylesheet" type="text/css">
    <link href="assets/css/components.css" rel="stylesheet" type="text/css">
    <link href="assets/css/colors.css" rel="stylesheet" type="text/css">
    <link href="assets/barkodOkuma/css/loading.css" rel="stylesheet" />
    <link href="assets/barkodOkuma/css/UrunAramaCss.css" rel="stylesheet" />
    <link href="assets/barkodOkuma/css/sweetalert2.min.css" rel="stylesheet" />


    <script type="text/javascript" src="assets/js/plugins/loaders/pace.min.js"></script>
    <%--<script type="text/javascript" src="https://code.jquery.com/jquery-3.2.1.min.js"></script>--%>
    <script src="assets/js/jquery.min.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/bootstrap.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/loaders/blockui.min.js"></script>

    <!--[if lt IE 9]>

        <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->


</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <%-- <asp:UpdateProgress ID="updateProgress" runat="server">
                    <ProgressTemplate>
                        <div class="loadingBackground">
                            <asp:Image ID="imgUpdateProgress" CssClass="loadingImg" runat="server" ImageUrl="assets/images/loading1.gif" AlternateText="Lütfen Bekleyiniz ..." ToolTip="Lütfen Bekleyiniz ..." />
                            <br />
                            <span class="loadingText">Lütfen Bekleyiniz</span>
                        </div>
                    </ProgressTemplate>
                </asp:UpdateProgress>--%>
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


                                        <% if (CurrentUser.USER_TYPE == "FRANCHISE")
                                            { %>
                                        <a href="profile.aspx" class="sira1 waves-effect waves-light btn"><i class="icon-user" style="padding-top: 0px; font-size: 23px;"></i></a>
                                        <a href="logout.aspx" class="sira2 waves-effect waves-light btn red"><i class=" icon-exit3" style="padding-top: 0px; font-size: 23px;"></i></a>

                                        <%}
                                        else
                                        { %>
                                        <a href="profile.aspx" class="sira1 waves-effect waves-light btn"><i class="icon-user" style="padding-top: 0px; font-size: 23px;"></i></a>
                                        <a href="rozetsiralama.aspx" class="sira2 waves-effect waves-light btn"><i class="icon-trophy3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                        <a href="siralama.aspx" class="sira3 waves-effect waves-light btn"><i class=" icon-cash3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                        <a href="default.aspx" class="sira4 waves-effect waves-light btn"><i class=" icon-home" style="padding-top: 0px; font-size: 23px;"></i></a>

                                        <% if (CurrentUser.USER_TYPE == "ADMIN")
                                            { %>
                                        <a href="yonetim.aspx" class="sira5 waves-effect waves-light btn"><i class="icon-gear" style="padding-top: 0px; font-size: 23px;"></i></a>
                                        <%} %>
                                        <% if (CurrentUser.USER_TYPE == "PERSONEL" || CurrentUser.USER_TYPE == "MUDUR")
                                            { %>
                                        <a href="logout.aspx" class="sira5 waves-effect waves-light btn red"><i class=" icon-exit3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                        <%} %>

                                        <%}%>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>



                <div class="container" style="margin-bottom: 30px;">
                    <div class="row">

                        <div class="form-signin" runat="server">
                            <h2 class="form-signin-heading" style="margin-top: 20px; padding-bottom: 50px;">Ürün Arama Ekranı</h2>

                            <div style="display: flex">
                                <asp:TextBox runat="server" ID="txtBarkod" class="form-control" Style="text-transform: uppercase;" placeholder="Ürün Kodu Giriniz" autofocus=""></asp:TextBox>
                                <a href="http://lizay.btkurumsal.xyz/urunarama.aspx?BarcodeCamera=OK" class="yuvarlak"><i class="fa fa-camera fa-2x"></i></a>
                            </div>
                            <asp:Button ID="btnUrunAra" runat="server" class="btn btn-lg btn-primary btn-block" Style="margin-top: 20px;" Text="Ürün Ara" OnClick="btnUrunAra_OnClick" />
                            <div id="divMessage1" runat="server" visible="False">
                                <button type="button" class="btn btn-warning btn-block mb-3" id="alert-warning">Barkod Giriniz!</button>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <!-- ÜRÜN BÖLÜM -->
                        <div class="col-lg-4 col-xs-4"></div>
                        <div class="form-signin" style="margin-top: 15px;">
                            <asp:DropDownList runat="server" ID="drp1" OnSelectedIndexChanged="drp1_OnSelectedIndexChanged" AutoPostBack="True" CssClass="select-css" />
                        </div>
                        <div class="form-signin">
                            <asp:DropDownList runat="server" ID="drp2" OnSelectedIndexChanged="drp2_OnSelectedIndexChanged" AutoPostBack="True" CssClass="select-css" />
                        </div>
                        <div class="form-signin">
                            <asp:DropDownList runat="server" ID="drp3" OnSelectedIndexChanged="drp3_OnSelectedIndexChanged" AutoPostBack="True" CssClass="select-css" />
                        </div>
                        <div class="form-signin">
                            <asp:DropDownList runat="server" ID="drp4" OnSelectedIndexChanged="drp4_OnSelectedIndexChanged" AutoPostBack="True" CssClass="select-css" />
                        </div>
                        <div class="form-signin">
                            <asp:DropDownList runat="server" ID="drp5" CssClass="select-css" />
                        </div>
                        <div class="form-signin">
                            <asp:Button runat="server" CssClass="btn btn-primary btn-block" Style="padding: 13px 12px;" ID="btnUrunleriGetir" OnClick="btnUrunleriGetir_OnClick" Text="Ürünleri Getir" />
                            <div id="divMessage2" runat="server" visible="False">
                                <button type="button" class="btn btn-warning btn-block mb-3" id="alert-warning">En az birtane seçmelisiniz! </button>
                            </div>
                        </div>
                        <div class="col-lg-4 col-xs-4"></div>
                    </div>
                    <script src="assets/barkodOkuma/js/hover.js"></script>
                    <script src="assets/barkodOkuma/js/holder.min.js"></script>
                    <script src="assets/barkodOkuma/js/ie10-viewport-bug-workaround.js"></script>
                    <script src="assets/barkodOkuma/js/bootstrap.min.js"></script>
                    <script src="assets/barkodOkuma/js/sweetalert2.min.js"></script>
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

                    <script>

                        function PageLoad() {

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

                        }

                    </script>

                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
