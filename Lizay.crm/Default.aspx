<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Lizay.crm.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../dist/css/swiper.min.css">
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


        .swiper-container {
            width: 100%;
            height: 100%;
        }

        .swiper-slide {
            text-align: center;
            font-size: 18px;
            background: #fff;
            /* Center slide text vertically */
            display: -webkit-box;
            display: -ms-flexbox;
            display: -webkit-flex;
            display: flex;
            -webkit-box-pack: center;
            -ms-flex-pack: center;
            -webkit-justify-content: center;
            justify-content: center;
            -webkit-box-align: center;
            -ms-flex-align: center;
            -webkit-align-items: center;
            align-items: center;
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content area -->
    <div class="content" style="padding: 0px;">
        <!-- User profile -->
        <div class="row" style="padding: 0px; margin-left: 0px; margin-right: 0px;">
            <div class="col-lg-12" style="padding-left: 0px; padding-right: 0px;">
                <div class="panel panel-flat">
                    <div class="panel-heading">
                        <div class="tile pull-right " style="padding-bottom: 20px;">
                            <div class="float menu-share ">
                                <i class=" icon-menu my-float"></i>
                            </div>
                            <div class="soc">
                                <a href="urunarama.aspx" class="facebook waves-effect waves-light btn"><i class="icon-barcode2" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <%--<a href="urunlisteleme.aspx" class="google-plus waves-effect waves-light btn"><i class="icon-list" style="padding-top: 0px; font-size: 23px;"></i></a>--%>
                                <a href="profile.aspx" class="google-plus waves-effect waves-light btn"><i class="icon-user" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <a href="rozetsiralama.aspx" class="twitter waves-effect waves-light btn"><i class="icon-trophy3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <a href="siralama.aspx" class="linkedin waves-effect waves-light btn"><i class=" icon-cash3" style="padding-top: 0px; font-size: 23px;"></i></a>

                          
                              
                                <% if (CurrentUser.USER_TYPE == "ADMIN")
                                    { %>
                                <a href="yonetim.aspx" class="home waves-effect waves-light btn"><i class="icon-gear" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <%} %>
                                <% if (CurrentUser.USER_TYPE == "PERSONEL" || CurrentUser.USER_TYPE == "MUDUR")
                                    { %>
                                <a href="logout.aspx" class="home waves-effect waves-light btn red"><i class=" icon-exit3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                <%} %>
                            </div>
                        </div>
                        <!-- tile -->
                    </div>
                    <div class="card" style="margin-top: 60px; margin-left: 12px; margin-right: 12px;">
                        <div class="card-content" style="padding: 2px;">
                            <!-- Swiper -->
                            <div class="swiper-container">
                                <div class="swiper-wrapper">
                                    <asp:Repeater ID="listViewbanner" runat="server">
                                        <ItemTemplate>
                                            <div class="swiper-slide" style="width: 100%">
                                                <img src="<%# ((Lizay.dll.entity.SLIDER)Container.DataItem).IMG%>" style="width: 100%" />
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-flat" style="margin-top: 20px; margin-left: 0px; margin-right: 0px; background-color: transparent;">
                        <div class="card-content" style="padding: 0px;">
                            <div class="row">
                                <div class="col s12">
                                    <ul class="tabs">
                                        <li class="tab col s3"><a class="active" href="#test1">Genel Duyuru (<asp:Literal
                                            ID="ltrcount1" runat="server"></asp:Literal>)</a></li>
                                        <li class="tab col s3"><a href="#test2">Özel Duyuru (<asp:Literal ID="ltrcount2" runat="server"></asp:Literal>)</a></li>
                                    </ul>
                                </div>
                                <div id="test1" class="col s12" style="margin-top: 5px; padding-left: 10px; padding-right: 10px;">
                                    <ul class="collapsible" data-collapsible="accordion">
                                        <asp:Repeater ID="listView" runat="server">
                                            <ItemTemplate>
                                                <li>
                                                    <div class="collapsible-header">
                                                        <i class="material-icons">announcement</i><%# ((Lizay.dll.entity.ANNOUNCEMENT)Container.DataItem).TITLE%>
                                                        <span style="padding-left: 5rem">
                                                            <%# ((Lizay.dll.entity.ANNOUNCEMENT)Container.DataItem).PUB_DATE.ToShortDateString()%></span>
                                                    </div>
                                                    <div class="collapsible-body" style="background-color: white">
                                                        <img src="<%# ((Lizay.dll.entity.ANNOUNCEMENT)Container.DataItem).IMG%>" alt="" class="img-rounded img-preview" />
                                                        <%# ((Lizay.dll.entity.ANNOUNCEMENT)Container.DataItem).DESCRIPTION%>
                                                        <%# ((Lizay.dll.entity.ANNOUNCEMENT)Container.DataItem).DOCFILE!=""?"<a href='"+((Lizay.dll.entity.ANNOUNCEMENT)Container.DataItem).DOCFILE+"' target='_blank'>Dokümanı İndir / Görüntüle</a>":""%>
                                                    </div>
                                                </li>



                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                                <div id="test2" class="col s12" style="margin-top: 5px; padding-left: 10px; padding-right: 10px;">
                                    <ul class="collapsible" data-collapsible="accordion">
                                        <asp:Repeater ID="listView2" runat="server">
                                            <ItemTemplate>
                                                <li>
                                                    <div class="collapsible-header">
                                                        <i class="material-icons">announcement</i><%# ((Lizay.dll.entity.ANNOUNCEMENT)Container.DataItem).TITLE%>
                                                        <span style="padding-left: 5rem">
                                                            <%# ((Lizay.dll.entity.ANNOUNCEMENT)Container.DataItem).PUB_DATE.ToShortDateString()%></span>
                                                    </div>
                                                    <div class="collapsible-body" style="background-color: white">
                                                        <img src="<%# ((Lizay.dll.entity.ANNOUNCEMENT)Container.DataItem).IMG%>" alt="" class="img-rounded img-preview" />
                                                        <%# ((Lizay.dll.entity.ANNOUNCEMENT)Container.DataItem).DESCRIPTION%>
                                                        <%# ((Lizay.dll.entity.ANNOUNCEMENT)Container.DataItem).DOCFILE!=""?"<a href='"+((Lizay.dll.entity.ANNOUNCEMENT)Container.DataItem).DOCFILE+"' target='_blank'>Dokümanı İndir / Görüntüle</a>":""%>
                                                    </div>
                                                </li>



                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                            </div>
                            <%--          <div class="tabbable">
                                <ul class="nav nav-tabs nav-tabs-highlight nav-justified">
                                    <li class="active" style="float:left; padding-left:40px;"><a href="#highlighted-justified-tab1" data-toggle="tab" style="font-size:16px;">Genel Duyuru (<asp:Literal ID="ltrcount1" runat="server"></asp:Literal>)</a></li>
                                    <li style="float:right; padding-right:40px;"><a href="#highlighted-justified-tab2" data-toggle="tab" style="font-size:16px;">Özel Duyuru </a></li>
                                </ul>
                                <div class="tab-content">
                                    <div class="tab-pane active" id="highlighted-justified-tab1">
                                        <div class="panel-group content-group-lg" id="accordion1">
                                       
                                        </div>
                                    </div>
                                    <div class="tab-pane " id="highlighted-justified-tab2">
                                        <div class="panel-group content-group-lg" id="accordion1">
                                            
                                        </div>
                                    </div>
                                </div>
                            </div>--%>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Swiper JS -->
    <script src="../dist/js/swiper.min.js"></script>
    <!-- Initialize Swiper -->
    <script>
        var swiper = new Swiper('.swiper-container', {
            spaceBetween: 30,
            centeredSlides: true,
            autoplay: {
                delay: 2500,
                disableOnInteraction: false,
            },
            pagination: {
                el: '.swiper-pagination',
                clickable: true,
            },
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            },
        });
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
</asp:Content>
