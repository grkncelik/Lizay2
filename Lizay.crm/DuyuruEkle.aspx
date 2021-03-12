﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="DuyuruEkle.aspx.cs" Inherits="Lizay.crm.DuyuruEkle" %>

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
                                   <a href="yonetim.aspx"> <i class=" icon-backspace2 my-float" style="color:White"></i></a>
                                </div>
                            </div>
                            <!-- tile -->
                        </div>
                    </div>
                </div>
                                   <div class="card" style="margin-top: 60px; margin-left: 12px; margin-right: 12px;">

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
              <%--      <div class="panel-heading" style="padding-top: 10px; padding-bottom: 10px;">
                        <h5 class="panel-title" style="text-align: center; font-size: 20px; font-weight: bold;">
                            Duyuru Ekle</h5>
                    </div>--%>
                    <div class="card-content" style="padding: 20px;">
                        <div class="form-group">
                            <div class="row">
                                <div class="col-md-6">
                                    <label>
                                        Duyuru Başlığı</label>
                                    <input type="text" value="" class="form-control" id="txtTitle" runat="server">
                                </div>
                                <div class="col-md-6">
                                    <label>
                                        Duyuru Açıklaması</label>
                                    <textarea rows="5" cols="5" class="form-control" placeholder="" id="txtDescription" runat="server"></textarea>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="row">
                                <div class="col-md-6">
                                    <label>
                                       Duyuru Kapsamı</label>
                                    <asp:DropDownList ID="dropMagaza" cssclass="form-control"  runat="server">
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-6">
                                    <label class="display-block">
                                        Duyuru Görseli Yükle</label>
                                 <asp:FileUpload ID="FileUpload1" runat="server" cssclass="file-styled" />
                                    <span class="help-block">Accepted formats: gif, png, jpg. Max file size 2Mb</span>
                                </div>

                                 <div class="col-md-6">
                                    <label class="display-block">
                                        Duyuru Doküman Ekle</label>
                                 <asp:FileUpload ID="FileUpload2" runat="server" cssclass="file-styled" />
                                    <span class="help-block">Accepted formats: pdf, docx, xlsx. Max file size 2Mb</span>
                                </div>
                            </div>
                        </div>
                       <div class="text-right">

                            <asp:Button ID="btnKaydet" OnClick="btnKaydet_Click" runat="server" Text="Kaydet" cssclass="btn btn-success btn-block" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
