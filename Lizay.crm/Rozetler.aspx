<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="Rozetler.aspx.cs" Inherits="Lizay.crm.Rozetler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
.panel {
    margin-bottom: 20px;
    background-color: #fff;
    border:1px;/* 1px solid #fafafa; */
    border-radius: 3px;
    -webkit-box-shadow: 1px 1px rgba(0, 0, 0, 0); 
     box-shadow:  1px 1px rgba(0, 0, 0, 0); 
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
     box-shadow:  1px 1px rgba(0, 0, 0, 0.1); 
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
		a.facebook
		{
		  background-color:#4E71A8;
		  animation-delay:.5s;
		}
		a.google-plus
		{
		  animation-delay:.7s;
		  background-color:#E3411F;
		}
		a.twitter
		{
		  animation-delay:.15s;
		  background-color:#1CB7EB;
		}
		a.linkedin
		{
		  animation-delay:.15s;
		  background-color:#ef9a00;
		}
			a.yonetim
		{
		  animation-delay:.15s;
		  background-color:#52504c;
		  
		}
.pad .facebook
		{
		  left:-60px;
		}
		.pad .google-plus
		{
		  left:-120px;
		}
		.pad .twitter
		{
		  left:-120px;
		}
		.pad .linkedin
		{
		  left:-180px;
		}
		.pad .yonetim
		{
		  left:-240px;
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


span.badge {
    min-width: 2rem;
    padding: 0px 0px; 
    margin-left: 14px;
    text-align: center;
    font-size: 1rem;
    line-height: 25px;
    height: 2rem;
    color: #ffffff;
    float: right;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
}

.media-badge {
    position: absolute;
    left: -20px;
    top: -10px;
}


.card {
    -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.14), 0 1px 5px 0 rgba(0,0,0,0.12), 0 3px 1px -2px rgba(0,0,0,0.2);
    box-shadow: 0 2px 2px 0 rgba(0,0,0,0.5), 0 1px 5px 0 rgba(0,0,0,0.5), 0 3px 1px -2px rgba(0,0,0,0.5);
}

small {
    font-size: 80%;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content area -->
    <div class="content" style="padding: 0px;">
        <div class="row" style="padding: 0px; margin-left: 0px; margin-right: 0px;">
            <div class="col-lg-12" style="padding-left: 0px; padding-right: 0px;">
                <div class="panel panel-flat">
                    <div class="panel-heading">
                        <div class="tile pull-right" style="padding-bottom: 20px;">
                            <div class="float menu-share">
                                <i class=" icon-menu my-float"></i>
                            </div>
                            <div class="soc">
                              
                                <a href="profile.aspx" class="facebook waves-effect waves-light btn""><i class="icon-user" style="padding-top: 0px;
                                    font-size: 23px;"></i></a><a href="default.aspx" class="twitter waves-effect waves-light btn""><i class="icon-home"
                                        style="padding-top: 0px; font-size: 23px;"></i></a><a href="siralama.aspx" class="linkedin waves-effect waves-light btn"">
                                            <i class=" icon-cash3" style="padding-top: 0px; font-size: 23px;"></i>
                                </a><%--<a href="canliprim.aspx" class="google-plus"><i class="icon-coins" style="padding-top: 14px;
                                    font-size: 23px;"></i></a>--%>
                                <% if (CurrentUser.USER_TYPE.ToString() == "ADMIN" )
                                   { %>
                                <a href="yonetim.aspx" class="yonetim waves-effect waves-light btn""><i class="icon-gear" style="padding-top: 0px;
                                    font-size: 23px;"></i></a>
                                <%} %>
                                <% if (CurrentUser.USER_TYPE.ToString() == "PERSONEL" || CurrentUser.USER_TYPE.ToString() == "MUDUR")
                                   { %>
                                <a href="logout.aspx" class="yonetim waves-effect waves-light btn red"><i class=" icon-exit3" style="padding-top: 0px;
                                    font-size: 23px;"></i></a>
                                <%} %>
                            </div>
                        </div>
                        <!-- tile -->
                    </div>
              
                 <div class="panel panel-flat" style="margin-top: 60px; margin-left: 0px; margin-right: 0px;">
               <%--     <div class="panel-heading" style="padding-top: 10px; padding-bottom: 10px;">
                        <h5 class="panel-title" style="text-align: center">
                            Kazanılan Rozet Listesi</h5>
                    </div>--%>
                                         <div class="panel-heading" style="padding-top: 10px; padding-bottom: 10px;">
                        <h5 class="panel-title" style="text-align: center; font-size: 20px; font-weight: bold;color:White">
                       Kazanılan Rozet Listesi</h5>
                    </div>
                       <div class="card-content" style="padding: 1px; ">
                    <!-- Rounded thumbs -->
                    <div class="row" style="padding: 0px; margin-left: 10px; margin-right: 10px;">
                        <asp:Literal ID="ltrozetler" runat="server"></asp:Literal>
                  
                    </div>
                    </div>
                </div>
                <!-- /rounded thumbs-->
            </div>
              </div>
        </div>
    </div>
    <!-- /content area -->
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
