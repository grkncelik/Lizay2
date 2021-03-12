<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="Yonetim.aspx.cs" Inherits="Lizay.crm.Yonetim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
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

        .btn-primary {
            color: #fff;
            background-color: #304352;
            border-color: #304352;
        }

        .tile, .tile1 {
            position: relative;
        }

        .float {
            position: relative;
            display: inline-block;
            width: 60px;
            height: 60px;
            line-height: 70px;
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

        a.facebook {
            background-color: #4E71A8;
            animation-delay: .5s;
        }

        a.google-plus {
            animation-delay: .7s;
            background-color: #E3411F;
        }

        a.twitter {
            animation-delay: .15s;
            background-color: #1CB7EB;
        }

        a.linkedin {
            animation-delay: .15s;
            background-color: #ef9a00;
        }

        a.home {
            animation-delay: .15s;
            background-color: #26a69a;
        }

        a.yonetim {
            animation-delay: .15s;
            background-color: #52504c;
        }

        .pad .facebook {
            left: -60px;
        }

        .pad .google-plus {
            left: -120px;
        }

        .pad .twitter {
            left: -180px;
        }

        .pad .linkedin {
            left: -240px;
        }

        .pad .home {
            left: -300px;
        }

        .pad .yonetim {
            left: -360px;
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


        .btn, .btn-large, .btn-flat {
            border: none;
            border-radius: 2px;
            display: inline-block;
            height: 100px;
            line-height: 36px;
            padding: 15px 0;
            font-size: 12px;
            text-transform: uppercase;
            vertical-align: middle;
            -webkit-tap-highlight-color: transparent;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content area -->
    <div class="content" style="padding: 0px;">
        <!-- User profile -->
        <div class="row" style="padding: 0px; margin-left: 0px; margin-right: 0px;">
            <div class="col-lg-12" style="padding-left: 0px; padding-right: 0px;">
                <div class="panel panel-flat">
                    <div class="panel-heading">
                        <div class="tile pull-right" style="padding-bottom: 20px;">
                            <div class="float menu-share">
                                <i class=" icon-menu my-float"></i>
                            </div>
                            <div class="soc">
                                
                                <a href="urunarama.aspx" class="facebook waves-effect waves-light btn"><i class="icon-barcode2" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <a href="urunlisteleme.aspx" class="google-plus waves-effect waves-light btn"><i class="icon-list" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <a href="profile.aspx" class="google-plus waves-effect waves-light btn"><i class="icon-user" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <a href="rozetsiralama.aspx" class="twitter waves-effect waves-light btn"><i class="icon-trophy3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <a href="siralama.aspx" class="linkedin waves-effect waves-light btn"><i class=" icon-cash3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <a href="default.aspx" class="home waves-effect waves-light btn"><i class=" icon-home" style="padding-top: 0px; font-size: 23px;"></i></a> 

                              <%--  <a href="profile.aspx" class="facebook waves-effect waves-light btn"><i class="icon-user" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <a href="rozetsiralama.aspx" class="twitter waves-effect waves-light btn"> <i class="icon-trophy3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <a href="siralama.aspx" class="linkedin waves-effect waves-light btn"><i class=" icon-cash3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <a href="default.aspx" class="yonetim waves-effect waves-light btn"><i class="icon-home" style="padding-top: 0px; font-size: 23px;"></i></a>--%>
                            </div>
                        </div>
                        <!-- tile -->
                    </div>
                </div>
                <div class="panel panel-flat" style="margin-top: 30px;">
                    <div class="panel-heading" style="padding-top: 30px; padding-bottom: 10px;">
                        <h5 class="panel-title" style="text-align: center; font-size: 20px; font-weight: bold; color: White">Yönetim Sayfası</h5>
                    </div>
                    <div class="panel-body" style="padding: 10px;">
                        <div class="row" style="padding: 10px;">
                            <div class="col-xs-6">
                                <a href="personelekle.aspx" class="btn btn-primary  btn-float btn-block"><b><i class="icon-user-plus icon-2x"></i></b>PERSONEL EKLE</a>
                            </div>
                            <div class="col-xs-6">
                                <a href="personellistesi.aspx" class="btn btn-primary  btn-float btn-block"><b><i
                                    class=" icon-users icon-2x"></i></b>PERSONEL LİSTESİ</a>
                            </div>
                        </div>
                        <div class="row" style="padding: 10px;">
                            <div class="col-xs-6">
                                <a href="duyuruekle.aspx" class="btn btn-primary  btn-float btn-block"><b><i class="icon-pencil4 icon-2x"></i></b>DUYURU EKLE</a>
                            </div>
                            <div class="col-xs-6">
                                <a href="duyurulistesi.aspx" class="btn btn-primary  btn-float btn-block"><b><i class="icon-list2 icon-2x"></i></b>DUYURU LİSTESİ</a>
                            </div>
                        </div>
                        <div class="row" style="padding: 10px;">
                            <div class="col-xs-6">
                                <a href="sliderekle.aspx" class="btn btn-primary  btn-float btn-block"><b><i class="icon-image2 icon-2x"></i></b>SLİDER EKLE</a>
                            </div>
                            <div class="col-xs-6">
                                <a href="sliderlistesi.aspx" class="btn btn-primary  btn-float btn-block"><b><i class=" icon-images2 icon-2x"></i></b>SLİDER LİSTESİ </a>
                            </div>
                        </div>
                        <div class="row" style="padding: 10px;">
                            <div class="col-xs-6">
                                <a href="urunekle.aspx" class="btn btn-primary  btn-float btn-block"><b><i class="icon-pencil4 icon-2x"></i></b>ÜRÜN EKLE</a>
                            </div>
                            <div class="col-xs-6">
                                <a href="urunlistesi.aspx" class="btn btn-primary  btn-float btn-block"><b><i class="icon-list2 icon-2x"></i></b>ÜRÜN LİSTESİ</a>
                            </div>
                        </div>
                        <div class="row" style="padding: 10px;">
                            <div class="col-xs-6">
                                <a href="denetimodulu.aspx" class="btn btn-primary  btn-float btn-block"><b><i class=" icon-medal-star icon-2x"></i></b>DENETİM ÖDÜLÜ EKLE</a>
                            </div>
                            <div class="col-xs-6">
                                <a href="denetimodullistesi.aspx" class="btn btn-primary  btn-float btn-block"><b><i class=" icon-stars icon-2x"></i></b>ÖDÜL LİSTESİ</a>
                            </div>
                        </div>
                        <div class="row" style="padding: 10px;">
                            <div class="col-xs-6">
                                <a href="raporlama.aspx" class="btn btn-primary  btn-float btn-block"><b><i class=" icon-graph icon-2x"></i></b>RAPORLAMA</a>
                            </div>
                            <div class="col-xs-6">
                                <a href="logout.aspx" class="btn btn-danger red  btn-float btn-block"><b><i class="icon-exit3 icon-2x"></i></b>ÇIKIŞ YAP</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
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
</asp:Content>
