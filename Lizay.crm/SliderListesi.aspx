<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="SliderListesi.aspx.cs" Inherits="Lizay.crm.SliderListesi" %>

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
        
        .media v
        {
            border: 1px solid rgba(0, 0, 0, 0.1);
            -webkit-box-shadow: 1px 1px rgba(0, 0, 0, 0.1);
            box-shadow: 1px 1px rgba(0, 0, 0, 0.1);
        }
        .thumbnail .caption
        {
            padding: 17px;
            padding-top: 20px;
        }
        
        
                 .tile,.tile1
		{
		  position:relative;
		}
        .float
        {
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
        
        .menu-share i
        {
            animation: rotate-in 0.5s;
        }
        	.my-float{
			font-size:24px;
			margin-top:20px;
		}
			@keyframes rotate-in {
		    from {transform: rotate(0deg);}
		    to {transform: rotate(360deg);}
		}

		@keyframes rotate-out {
		    from {transform: rotate(360deg);}
		    to {transform: rotate(0deg);}
		}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content area -->
    <div class="content" style="padding: 0px;">
        <div class="row" style="padding: 0px; margin-left: 0px; margin-right: 0px;">
            <div class="col-lg-12" style="padding-left: 0px; padding-right: 0px;">
                <div class="panel panel-flat">
                    <div class="panel panel-flat">
                        <div class="panel-heading">
                            <div class="tile pull-right" style="padding-bottom: 20px;">
                                <div class="float menu-share">
                                    <a href="yonetim.aspx"><i class=" icon-backspace2 my-float" style="color: White"></i>
                                    </a>
                                </div>
                            </div>
                            <!-- tile -->
                        </div>
                    </div>
                </div>
                            <div class="panel panel-flat" style="margin-top: 60px; margin-left: 0px; margin-right: 0px;">

          <%--          <div class="panel-heading" style="padding-top: 10px; padding-bottom: 10px;">
                        <h5 class="panel-title" style="text-align: center; font-size: 20px; font-weight: bold;">
                            Slider Listesi</h5>
                    </div>--%>
         <div class="panel-body" style="padding: 20px;">
                       <asp:Repeater ID="listView" runat="server">
                                    <ItemTemplate>
                        <div class="col-lg-3 col-sm-6">
                            <div class="thumbnail">
                                <div class="thumb">
                                    <img src=" <%# ((Lizay.dll.entity.SLIDER)Container.DataItem).IMG%>" alt="">
                                    <div class="caption-overflow">
                                        <span><a href="<%# ((Lizay.dll.entity.SLIDER)Container.DataItem).IMG%>" data-popup="lightbox" class="btn border-white text-white btn-flat btn-icon btn-rounded">
                                            <i class="icon-plus3"></i></a><a href="#" class="btn border-white text-white btn-flat btn-icon btn-rounded ml-5">
                                                <i class="icon-link2"></i></a></span>
                                    </div>
                                </div>
                                <div class="caption">
                                    <h6 class="no-margin">
                                        <a href="SliderListesi.aspx?SId=<%# ((Lizay.dll.entity.SLIDER)Container.DataItem).BANNER_ID%>" class="btn btn-danger"><i class=" icon-trash"></i> Görseli Kaldır</a> 
                                    </h6>
                                </div>
                            </div>
                        </div>
                                  </ItemTemplate>
                                </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
