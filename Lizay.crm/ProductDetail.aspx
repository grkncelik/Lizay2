<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="Lizay.crm.ProductDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Lizay Pırlanta </title>
    <meta charset="utf-8" />
    <meta content="IE=edge" http-equiv="x-ua-compatible" />
    <meta content="initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no" name="viewport" />
    <meta content="yes" name="apple-mobile-web-app-capable" />
    <meta content="yes" name="apple-touch-fullscreen" />
    <link rel="stylesheet" type="text/css" href="template/css/style.css" />
    <link rel="stylesheet" type="text/css" href="template/css/responsive.css" />
    <link rel="shortcut icon" href="template/template/images/favicon.png" />

    <style>
        .footer {
            position: fixed;
            left: 0px;
            bottom: 0px;
            height: auto;
            width: 100%;
        }

        #btnOrder {
        width:100%;
        
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">

            <div id="page">

                <div class="top-navbar">
                    <div class="top-navbar-left">
                  
                              <asp:Literal ID="ltrBack" runat="server"></asp:Literal>
                    </div>

                    <%--      <div class="top-navbar-right">
                        <a href="#" class="dropdown-button" data-activates="dropdown1"><i class="fa fa-lock"></i></a>
                        <ul id="dropdown1" class="dropdown-content">
                            <li><a href="Login.aspx"><i class="fa fa-sign-in"></i>Mağaza Girişi</a></li>

                        </ul>
                    </div>--%>
                    <div class="site-title">
                        <img src="https://www.lizaypirlanta.com/images/logo.png" style="width: 30%" />
                    </div>
                </div>
                <div class="content-container">
                    <div class="content-header">

                        <h2 class="product-title animated fadeIn">
                            <asp:Literal ID="ltrTitle" runat="server"></asp:Literal></h2>
                        <ul class="product-slider animated fadeInRight">

                            <asp:Literal ID="ltrImg" runat="server"></asp:Literal>


                        </ul>
                        <div class="slick-thumbs">
                            <ul>
                                <asp:Literal ID="ltrThumb" runat="server"></asp:Literal>


                            </ul>
                        </div>
                        <!-- You can also use static thumbnail (without slider) via HTML tag below---------------------------------------------------<div class="big-thumb"><img src="template/images/1.jpg" alt=""></div>--------------------------------------------------->
                        <div class="product-meta animated fadeInUp">
                            <div class="rating">
                                <asp:Literal ID="ltrCategory" runat="server"></asp:Literal></div>
                            <div class="price"><span class="price-before">
                                <asp:Literal ID="ltrPrice" runat="server"></asp:Literal>TL </span>
                                <asp:Literal ID="ltrDiscount" runat="server"></asp:Literal>
                                TL </div>
                            <div class="availability in-stock">  <asp:Literal ID="ltrProductCode" runat="server"></asp:Literal> </div>

                        </div>
                    </div>
                    <div class="product-tabs">
                        <ul class="tabs">
                            <li class="tab"><a class="active" href="#detail">Ürün Bilgisi </a></li>
                        </ul>
                    </div>
                    <div class="product-content">
                        <div class="tab-content" id="detail">
                            <p>
                                <asp:Literal ID="ltrDetail" runat="server"></asp:Literal></p>
                        </div>

                    </div>
               <%--     <div class="product-action " style="margin-bottom:20px;">
                        <asp:Literal ID="ltrUrl" runat="server"></asp:Literal>
                        </div>--%>
                            <div class="product-action" style="margin-bottom:20px;">
                        <asp:Button ID="btnOrder" OnClick="btnOrder_Click" runat="server" CssClass="btn orange btn-block margin-bottom_low" Text="SİPARİŞ VER" />

                    </div>
                    <div class="line"></div>
                    <div class="page-block margin-bottom">
                        <h2 class="block-title"><span>Benzer Ürünler</span></h2>
                        <ol class="product-list">
                            <asp:Repeater ID="listView" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <div class="thumb">
                                            <a href="productdetail.aspx?Id=<%# ((Lizay.dll.entity.PRODUCT)Container.DataItem).ID%>">
                                                <img src="<%# ((Lizay.dll.entity.PRODUCT)Container.DataItem).IMG%>" alt="" /></a>
                                        </div>
                                        <div class="product-ctn">
                                            <div class="product-name"><a href="productdetail.aspx?Id=<%# ((Lizay.dll.entity.PRODUCT)Container.DataItem).ID%>"><%# ((Lizay.dll.entity.PRODUCT)Container.DataItem).NAME%></a></div>
                                            <div class="rating"><%# GetCategoryName(((Lizay.dll.entity.PRODUCT)Container.DataItem).CATEGORY_ID.ToString())%></div>
                                            <div class="price"><span class="price-before"><%# ((Lizay.dll.entity.PRODUCT)Container.DataItem).PRICE%>TL </span><span class="price-current"><%# ((Lizay.dll.entity.PRODUCT)Container.DataItem).DISCOUNT%>TL </span></div>
                                        </div>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>

                        </ol>
                        <div class="clear"></div>
                    </div>
                </div>
 
                <div id="to-top" class="main-bg"><i class="fa fa-long-arrow-up"></i></div>
            </div>
        </div>

        <script type="text/javascript" src="template/js/jquery.js"></script>
        <script type="text/javascript" src="template/js/materialize.min.js"></script>
        <script type="text/javascript" src="template/js/slick.min.js"></script>
        <script type="text/javascript" src="template/js/jquery.slicknav.js"></script>
        <script type="text/javascript" src="template/js/jquery.swipebox.min.js"></script>
        <script type="text/javascript" src="template/js/custom.js"></script>
    </form>
</body>
</html>
