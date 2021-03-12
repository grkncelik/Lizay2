<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="CanliPrim.aspx.cs" Inherits="Lizay.crm.CanliPrim" %>

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
            line-height: 70px;
            background-color: #39cece;
            color: #FFF;
            cursor: pointer;
            border-radius: 50px;
            text-align: center;
            z-index: 1000;
            animation: bot-to-top 2s ease-out;
        }

        .tile .float {
            box-shadow: 0px 0px 8px 2px rgba(57, 206, 206, 0.3);
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content area -->
    <div class="content" style="padding: 0px;">
        <!-- User profile -->
        <div class="row" style="padding: 0px; margin-left: 0px; margin-right: 0px;">
            <div class="col-lg-12" style="padding-left: 0px; padding-right: 0px;">
                <!-- List with text -->
                <div class="panel panel-flat">
                    <div class="panel-heading">
                        <div class="tile pull-right" style="padding-bottom: 20px;">
                            <div class="float menu-share">
                                <i class=" icon-menu my-float"></i>
                            </div>
                            <div class="soc">
                                <a href="profile.aspx" class="facebook"><i class="icon-user" style="padding-top: 14px; font-size: 23px;"></i></a>
                                <a href="rozetsiralama.aspx" class="twitter"><i class="icon-trophy3" style="padding-top: 14px; font-size: 23px;"></i></a>
                                <a href="siralama.aspx" class="linkedin"><i class=" icon-cash3" style="padding-top: 14px; font-size: 23px;"></i> </a>
                                <a href="default.aspx" class="google-plus"><i class="icon-home" style="padding-top: 14px; font-size: 23px;"></i></a>
                                <% if (CurrentUser.USER_TYPE.ToString() == "ADMIN" || CurrentUser.USER_TYPE.ToString() == "MUDUR")
                                    { %>
                                <a href="yonetim.aspx" class="yonetim"><i class="icon-gear" style="padding-top: 14px; font-size: 23px;"></i></a>
                                <%} %>
                                <% if (CurrentUser.USER_TYPE.ToString() == "PERSONEL")
                                    { %>
                                <a href="logout.aspx" class="yonetim"><i class=" icon-exit3" style="padding-top: 14px; font-size: 23px;"></i></a>
                                <%} %>
                            </div>
                        </div>
                        <!-- tile -->
                    </div>
                </div>
                <div class="panel panel-flat" style="margin-top: 50px;">
                    <div class="panel-heading" style="padding-top: 10px; padding-bottom: 10px;">
                        <h5 class="panel-title" style="text-align: center">Canlı Prim Sıralaması</h5>
                    </div>
                    <div class="panel-body" style="padding: 10px;">
                        <div class="tabbable">
                            <ul class="nav nav-tabs nav-tabs-highlight nav-justified">
                                <li class="active"><a href="#highlighted-justified-tab1" data-toggle="tab">Mağaza Bazlı</a></li>
                                <li><a href="#highlighted-justified-tab2" data-toggle="tab">Personel Bazlı</a></li>
                            </ul>
                            <div class="tab-content">
                                <div class="tab-pane active" id="highlighted-justified-tab1">
                                    <ul class="media-list media-list-linked">
                                        <asp:Repeater ID="listView" runat="server">
                                            <ItemTemplate>
                                                <li class="media"><span class="media-link">
                                                    <div class="media-left">
                                                        <img src="assets/images/placeholder.jpg" class="img-circle" alt="">
                                                    </div>
                                                    <div class="media-body">
                                                        <div class="media-heading text-semibold">
                                                            <%# Container.ItemIndex + 1 %>-
                                                           
                                                            <%# ((Lizay.dll.entity.MOBILEXPENSELIST)Container.DataItem).SALDEPTX%>
                                                        </div>
                                                        <span class="text-muted">000</span>
                                                    </div>
                                                    <div class="media-right media-middle text-nowrap">
                                                        <span class="text-muted"><i class=" icon-coins text-size-base"></i>
                                                            <%# ((Lizay.dll.entity.MOBILEXPENSELIST)Container.DataItem).PUAN%>
                                                        </span>
                                                    </div>
                                                </span></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                                <div class="tab-pane" id="highlighted-justified-tab2">
                                    <ul class="media-list media-list-linked">
                                        <asp:Repeater ID="listView2" runat="server">
                                            <ItemTemplate>
                                                <li class="media"><a href="#" class="media-link">
                                                    <div class="media-left">
                                                        <img src="assets/images/placeholder.jpg" class="img-circle" alt="">
                                                    </div>
                                                    <div class="media-body">
                                                        <div class="media-heading text-semibold">
                                                            <%# Container.ItemIndex + 1 %>-
                                                           
                                                            <%# ((Lizay.dll.entity.MOBILEXPENSELIST)Container.DataItem).SALDEPTX%>
                                                        </div>
                                                        <span class="text-muted">000</span>
                                                    </div>
                                                    <div class="media-right media-middle text-nowrap">
                                                        <span class="text-muted"><i class=" icon-coins text-size-base"></i>
                                                            <%# ((Lizay.dll.entity.MOBILEXPENSELIST)Container.DataItem).PUAN%>
                                                        </span>
                                                    </div>
                                                </a></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /list with text -->
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
