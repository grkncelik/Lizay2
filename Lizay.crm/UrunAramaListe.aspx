<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UrunAramaListe.aspx.cs" Inherits="Lizay.crm.UrunAramaListe" %>

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
    <link href="assets/buttonLoader/buttonLoader.css" rel="stylesheet" />

    <script type="text/javascript" src="assets/js/plugins/loaders/pace.min.js"></script>
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.4/jquery.min.js"></script>--%>
    <%--<script src="assets/js/jquery.min.js"></script>--%>
    <script type="text/javascript" src="assets/js/core/libraries/bootstrap.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/loaders/blockui.min.js"></script>
    <script src="assets/buttonLoader/jquery.buttonLoader.js"></script>
    <!--[if lt IE 9]>

        <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->


    <link href="assets/barkodOkuma/css/UrunAramaListeCss.css" rel="stylesheet" />



    <script type="text/javascript">

        var pageIndex = 1;
        var isLoading = false;


        function ShowMore() {

            InfiniteScroll();
        }

        function InfiniteScroll() {

            //$('#content').html('<img id="loader-img" alt="" src="assets/images/loading.gif" width="50" height="50" align="center" />');
            $(".btnMore").attr("disabled", true);
            isLoading = true;
            //var scrollFromBottom;
            pageIndex++;
            var index = parseInt(pageIndex);
            var obj = { pageIndex: index };
            var param = JSON.stringify(obj);

            $.ajax({
                type: "POST",
                url: "UrunAramaListe.aspx/GetData",
                //data: param,
                data: "{pageIndex:" + index + "}",
                contentType: "application/json; charset=utf-8",
                async: true,
                cache: false,
                dataType: "json",
                beforeSend: function () {

                    // scrollFromBottom = $(document).height() - $(window).scrollTop();
                    //   $('#content').html('<img id="loader-img" alt="" src="assets/images/loading.gif" width="50" height="50" align="center" />');
                },
                success: function (data) {
                    if (data != "") {
                        $('.divLoadData:last').after(data.d);
                    }

                    isLoading = false;
                },
                complete: function (data) {
                    //   $('#content').html('');
                    // $(window).scrollTop($(document).height() - scrollFromBottom);
                    // $(".btnMore").html('Daha Fazla Göster');

                    $(".btnMore").attr("disabled", false);

                }
            });
        };

    </script>
</head>
<body>
    <form id="form1" runat="server">
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
        <div class="container" style="margin-bottom: 30px;">
            <div id="divLoadData" class="divLoadData" runat="server">
            </div>

            <div class="row">
                <div align="center">
                    <div class="row">
                        <div class="span6" style="float: none; margin: 0 auto;">
                            <div class="row">
                                <input type="button" class="btn btn-sm btn-primary btn-block btnMore" style="margin-top: 20px;" onclick="ShowMore();" value="Daha Fazla Göster" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="content">
                <%--<img src="assets/images/loading1.gif" id="loader" />--%>
            </div>
            <script>
            //$(document).ready(function () {
            //    // -----------------------------------------------------------------------
            //    $.each($('#navbar').find('li'), function () {
            //        $(this).toggleClass('active',
            //            window.location.pathname.indexOf($(this).find('a').attr('href')) > -1);
            //    });
            //    // -----------------------------------------------------------------------
            //});
            </script>
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
        </div>
    </form>
</body>
</html>
