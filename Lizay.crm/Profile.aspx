<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="Profile.aspx.cs" Inherits="Lizay.crm.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .panel
        {
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
        
        .media
        {
            border: 1px solid rgba(0, 0, 0, 0.1);
            -webkit-box-shadow: 1px 1px rgba(0, 0, 0, 0.1);
            box-shadow: 1px 1px rgba(0, 0, 0, 0.1);
        }
        
               
            .tile,.tile1
		{
		  position:relative;
		}
		.float
		{
			position:relative;
			display:inline-block;
			width:60px;
			height:60px;
			line-height:70px;
			background-color:#26a69a;
			color:#FFF;
			cursor:pointer;
			border-radius:50px;
			text-align:center;
			z-index:1000;
			animation: bot-to-top 2s ease-out;
		}
		.tile .float
		{
			box-shadow:0px 0px 8px 2px rgba(57, 206, 206, 0.3);
			    -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);
    box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);
}

.waves-effect
{
    			    -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);
    box-shadow: 0 2px 2px 0 rgba(0,0,0,0.7), 0 1px 5px 0 rgba(0,0,0,0.7), 0 3px 1px -2px rgba(0,0,0,0.7);
    
    }
    
    .tabs
{
    			    -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.14), 0 1px 5px 0 rgba(0,0,0,0.12), 0 3px 1px -2px rgba(0,0,0,0.2);
    box-shadow: 0 2px 2px 0 rgba(0,0,0,0.14), 0 1px 5px 0 rgba(0,0,0,0.12), 0 3px 1px -2px rgba(0,0,0,0.2);
    
    }
		.tile1 .float
		{
		  background-color:#e75b5b;
		  box-shadow:0px 0px 8px 2px rgba(231, 91, 91, 0.3);
		}
		.soc a
		{
			color:#FFF;
			border-radius:50%;
			text-align:center;
			width:50px;
			height:50px;
			line-height:53px;
			padding:0px;
			font-size:20px;
			display:inline-block;
			position:absolute;
			top:5px;
			left:6px;
			transition:all .5s;
		}
		.soc a:hover
		{
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
		.my-float{
			font-size:24px;
			margin-top:20px;
		}
		.tile1 .float
		{
		  font-size:24px;
		}
		.menu-share i{
			animation: rotate-in 0.5s;
		}

		/* .tile .menu-share:hover > i{
			animation: rotate-out 0.5s;
		} */

		@keyframes rotate-in {
		    from {transform: rotate(0deg);}
		    to {transform: rotate(360deg);}
		}

		@keyframes rotate-out {
		    from {transform: rotate(360deg);}
		    to {transform: rotate(0deg);}
		}
		
		.btn-primary
		{
		    padding: 0px 5px;
    text-transform: capitalize;
		    }
		    
		    
		    .media {
    border: 0px solid rgba(0, 0, 0, 0.1);
    -webkit-box-shadow: 0px 0px rgba(0, 0, 0, 0.1);
    box-shadow: 0px 0px rgba(0, 0, 0, 0.1);
}

span.badge {
    min-width: 3rem;
    padding: 0 6px;
    margin-left: 14px;
    text-align: center;
    font-size: 1rem;
    line-height: 22px;
    height: 22px;
    color: #ffffff;
    float: right;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
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
                                
                                <% if (CurrentUser.USER_TYPE == "FRANCHISE"){ %>
                                    
                                    <a href="urunarama.aspx" class="facebook waves-effect waves-light btn"><i class="icon-barcode2" style="padding-top: 0px; font-size: 23px;"></i></a>
                                    <a href="logout.aspx" class="google-plus waves-effect waves-light btn red"><i class=" icon-exit3" style="padding-top: 0px; font-size: 23px;"></i></a>

                                <%}else{ %>
                                
                                    <a href="urunarama.aspx" class="facebook waves-effect waves-light btn"><i class="icon-barcode2" style="padding-top: 0px; font-size: 23px;"></i></a>
                                    <a href="siralama.aspx" class="google-plus waves-effect waves-light btn"><i class=" icon-cash3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                    <a href="rozetsiralama.aspx" class="linkedin waves-effect waves-light btn"><i class="icon-trophy3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                    <a href="default.aspx" class="twitter waves-effect waves-light btn"><i class=" icon-home" style="padding-top: 0px; font-size: 23px;"></i></a>
                                
                                    <% if (CurrentUser.USER_TYPE == "ADMIN" )
                                       { %>
                                        <a href="yonetim.aspx" class="home waves-effect waves-light btn"><i class="icon-gear"
                                                                                                            style="padding-top: 0px; font-size: 23px;"></i></a>
                                    <%} %>
                                    <% if (CurrentUser.USER_TYPE == "PERSONEL" || CurrentUser.USER_TYPE == "MUDUR")
                                       { %>
                                        <a href="logout.aspx" class="home waves-effect waves-light btn red"><i class=" icon-exit3" style="padding-top: 0px; font-size: 23px;"></i></a>
                                    <%} %>
                                
                                <%}%>

                               
                                

                            </div>
                        </div>
                        <!-- tile -->
                    </div>
                      <div class="card" style="margin-top: 60px; margin-left: 10px; margin-right: 10px;">
                        <asp:Panel runat="server" ID="MessageBox" Visible="false">
                            <div class="alert alert-danger alert-styled-left alert-bordered">
                                <button type="button" class="close" data-dismiss="alert">
                                    <span>×</span><span class="sr-only">Kapat</span></button>
                                <asp:Literal ID="ltWarningBox" runat="server" />
                            </div>
                        </asp:Panel>
                        <asp:Panel runat="server" ID="MessageBox2" Visible="false">
                            <div class="alert alert-success alert-styled-left alert-bordered">
                                <button type="button" class="close" data-dismiss="alert">
                                    <span>×</span><span class="sr-only">Kapat</span></button>
                                <asp:Literal ID="ltWarningBox2" runat="server" />
                            </div>
                        </asp:Panel>
                        <%--             <div class="panel-heading" style="padding-top: 10px; padding-bottom: 10px;">
                        <h5 class="panel-title" style="text-align: center">
                            Profil Sayfası</h5>
                    </div>--%>
                      <div class="card-content" style="padding: 2px;">
                        <!-- Cover area -->
                        <div class="profile-cover">
                            <div class="profile-cover-img" style="background-image: url('profilebg.jpg')">
                            </div>
                            <div class="media">
                                <div class="media-left">
                                    <a href="#" class="profile-thumb">
                                        <asp:Literal ID="ltrimg" runat="server"></asp:Literal>
                                    </a>
                                </div>
                                <div class="media-body">
                                    <h1 style="font-size:1.8rem">
                                        <asp:Literal ID="ltrname" runat="server"></asp:Literal>
                                    </h1>
                                </div>
                                <div class="media-right media-middle">
                                    <ul class="list-inline list-inline-condensed no-margin-bottom text-nowrap">
                                        <li>
                                            <asp:Button ID="btnProfile" OnClick="btnProfile_Click" CssClass="btn btn-primary" 
                                                runat="server" Text="P. Bilgileri" /></li>
                                        <li>
                                            <asp:Button ID="btnGenel" OnClick="btnGenel_Click" CssClass="btn btn-primary" runat="server"
                                                Text="G. İstatistikler" /></li>
                                        <li><a href="sifredegistir.aspx" class="btn btn-primary" style="padding: 0px 5px; text-transform: capitalize;">Şifre Değiştir</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <!-- /cover area -->
                        <!-- Content area -->
                        <div class="content" style="padding: 0px;">
                            <!-- User profile -->
                            <div class="row" style="padding: 0px; margin-left: 0px; margin-right: 0px;">
                                <asp:Panel ID="pnlProfile" runat="server" Visible="false">
                                    <div class="col-lg-12" style="padding-left: 0px; padding-right: 0px;">
                                        <div class="tabbable">
                                            <div class="tab-content">
                                                <div class="tab-pane fade in active" id="settings">
                                                    <!-- Profile info -->
                                                    <div class="panel panel-flat">
                                                        <div class="panel-heading">
                                                            <h6 class="panel-title" style="font-weight: bold;padding-left: 20px;">
                                                                Profil Bilgileri</h6>
                                                        </div>
                                                        <div class="panel-body">
                                                            <div class="form-group">
                                                                <div class="row">
                                                                    <div class="col-md-6">
                                                                        <label>
                                                                            Email Adresi</label>
                                                                        <input type="text" class="form-control" id="txtEmail" runat="server"/>
                                                                    </div>
                                                                    <div class="col-md-6">
                                                                        <label>
                                                                            Gsm Numarası</label>
                                                                        <input type="text" class="form-control" id="txtGsm" runat="server"/>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="form-group">
                                                                <div class="row">
                                                                    <div class="col-md-6">
                                                                        <label>
                                                                            Doğum Tarihi</label>
                                                                        <input type="text" class="form-control" id="txtBirthday" runat="server"/>
                                                                    </div>
                                                                    <div class="col-md-6">
                                                                        <label class="display-block">
                                                                            Profil Fotoğrafı Yükle</label>
                                                                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="file-styled" />
                                                                        <span class="help-block">Accepted formats: gif, png, jpg. Max file size 2Mb</span>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="text-right">
                                                                <asp:Button ID="btnKaydet" OnClick="btnKaydet_Click" runat="server" Text="Kaydet"
                                                                    CssClass="btn btn-success btn-block" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <!-- /profile info -->
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </asp:Panel>
                                <asp:Panel ID="pnlGenel" runat="server" Visible="true">
                                    <div class="col-lg-12" style="padding-left: 0px; padding-right: 0px;">
                                        <!-- Navigation -->
                                        <div class="panel panel-flat">
                                            <div class="panel-heading">
                                                <h6 class="panel-title" style="font-weight: bold;padding-left: 20px;">
                                                    Genel İstatistikler</h6>
                                            </div>
                                            <div class="list-group no-border no-padding-top">
                                                <a href="Siralama.aspx" class="list-group-item"><i class=" icon-stars"></i>Toplam Puan
                                                    <span class="badge bg-danger pull-right">
                                                        <asp:Literal ID="ltpuan" runat="server"></asp:Literal>
                                                    </span></a>
                                                <div class="list-group-divider">
                                                </div>
                                                <a href="Rozetler.aspx" class="list-group-item"><i class=" icon-trophy2"></i>Toplam Rozet 
                                                    <span class="badge bg-warning pull-right"><asp:Literal ID="ltrozet" runat="server"></asp:Literal></span></a>
                                                <div class="list-group-divider">
                                                </div>
                                                <%--       <a href="CanliPrim.aspx" class="list-group-item"><i class=" icon-coins"></i>Canlı Prim
                                                <span class="badge bg-success pull-right">12.700 TL</span></a>--%>
                                            </div>
                                        </div>
                                        <!-- /navigation -->
                                    </div>
                                </asp:Panel>
                            </div>
                            <!-- /user profile -->
                        </div>
                        <!-- /content area -->
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
