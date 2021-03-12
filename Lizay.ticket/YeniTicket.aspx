<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="YeniTicket.aspx.cs" Inherits="Lizay.ticket.YeniTicket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="assets/js/pages/form_layouts.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page header -->
    <div class="page-header page-header-default">
        <div class="page-header-content">
            <div class="page-title">
                <h4><span class="text-semibold">Ticket Yönetimi</span> - Yeni Kayıt</h4>


            </div>

            <div class="heading-elements">
                <div class="heading-btn-group">
                    <a href="YeniTicket.aspx" class="btn btn-link btn-float text-size-small "><i class=" icon-pencil text-success" style="font-size: 25px;"></i><span style="text-transform: capitalize">Yeni Ticket Aç</span></a>
                    <a href="Dashboard.aspx" class="btn btn-link btn-float text-size-small "><i class=" icon-list text-primary" style="font-size: 25px;"></i><span style="text-transform: capitalize">Ticket Listesi</span></a>
                    <a href="Logout.aspx" class="btn btn-link btn-float text-size-small "><i class=" icon-lock5 text-danger" style="font-size: 25px;"></i><span style="text-transform: capitalize">Çıkış Yap</span></a>
                </div>
            </div>
        </div>

        <div class="breadcrumb-line">
            <ul class="breadcrumb">
                <li><a href="/">Ticket Yönetimi</a></li>
                <li class="active">Yeni Kayıt</li>
            </ul>

            <ul class="breadcrumb-elements">
                <li><a href="#"><i class="icon-comment-discussion position-left"></i>Support</a></li>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                        <i class="icon-gear position-left"></i>
                        Settings
								
                        <span class="caret"></span>
                    </a>

                    <ul class="dropdown-menu dropdown-menu-right">
                        <li><a href="#"><i class="icon-user-lock"></i>Account security</a></li>
                        <li><a href="#"><i class="icon-statistics"></i>Analytics</a></li>
                        <li><a href="#"><i class="icon-accessibility"></i>Accessibility</a></li>
                        <li class="divider"></li>
                        <li><a href="#"><i class="icon-gear"></i>All settings</a></li>
                    </ul>
                </li>
            </ul>
        </div>
    </div>
    <!-- /page header -->


    <!-- Content area -->
    <div class="content">


        <!-- 2 columns form -->
        <div class="form-horizontal">
            <div class="panel panel-flat">


                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-6">
                            <fieldset>
                                <legend class="text-semibold"><i class="icon-pencil position-left"></i>TİCKET BAŞLIK</legend>

                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Departman:</label>
                                    <div class="col-lg-9">
                                        <select data-placeholder="" class="select">
                                            <option></option>

                                            <option value="AK">Alaska</option>
                                            <option value="HI">Hawaii</option>
                                            <option value="CA">California</option>
                                            <option value="NV">Nevada</option>
                                            <option value="WA">Washington</option>
                                            <option value="AZ">Arizona</option>
                                            <option value="CO">Colorado</option>
                                            <option value="WY">Wyoming</option>

                                        </select>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-lg-3 control-label">İstek Sahibi:</label>
                                    <div class="col-lg-9">
                                        <input type="text" class="form-control" placeholder="" value="IYILMAZ">
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-lg-3 control-label">İstek Tarihi:</label>
                                    <div class="col-lg-9">
                                        <input type="text" class="form-control" placeholder="" value="20.07.2018 15:33">
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Sorumlu Kişi:</label>
                                    <div class="col-lg-9">
                                        <select data-placeholder="" class="select">
                                            <option></option>

                                            <option value="AK">Alaska</option>
                                            <option value="HI">Hawaii</option>
                                            <option value="CA">California</option>
                                            <option value="NV">Nevada</option>
                                            <option value="WA">Washington</option>
                                            <option value="AZ">Arizona</option>
                                            <option value="CO">Colorado</option>
                                            <option value="WY">Wyoming</option>

                                        </select>
                                    </div>
                                </div>


                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Ekran Adı:</label>
                                    <div class="col-lg-9">
                                        <input type="text" class="form-control" placeholder="">
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Teslim Tarihi:</label>
                                    <div class="col-lg-9">
                                        <input type="text" placeholder=" " class="form-control">
                                    </div>
                                </div>


                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Açıklama:</label>
                                    <div class="col-lg-9">
                                        <textarea rows="5" cols="5" class="form-control" placeholder=""></textarea>
                                    </div>
                                </div>

                            </fieldset>
                        </div>

                        <div class="col-md-6">
                            <fieldset>
                                <legend class="text-semibold"><i class="icon-info22 position-left"></i>TİCKET DETAY</legend>



                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Başlangıç Tarihi:</label>
                                    <div class="col-lg-9">
                                        <input type="text" placeholder="" class="form-control">
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Bitiş Tarihi:</label>
                                    <div class="col-lg-9">
                                        <input type="text" placeholder="" class="form-control">
                                    </div>
                                </div>


                                <div class="form-group">
                                    <label class="col-lg-3 control-label">İş Tipi:</label>
                                    <div class="col-lg-9">


                                        <select data-placeholder="Select your country" class="select">
                                            <option>-</option>
                                            <option value="1">Canada</option>
                                            <option value="2">USA</option>
                                            <option value="3">Australia</option>
                                            <option value="4">Germany</option>
                                        </select>


                                    </div>
                                </div>



                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Statü:</label>
                                    <div class="col-lg-9">


                                        <select data-placeholder="Select your country" class="select">
                                            <option>AÇIK</option>
                                            <option value="1">Canada</option>
                                            <option value="2">USA</option>
                                            <option value="3">Australia</option>
                                            <option value="4">Germany</option>
                                        </select>


                                    </div>
                                </div>


                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Öncelik:</label>
                                    <div class="col-lg-9">


                                        <select data-placeholder="Select your country" class="select">
                                            <option>---</option>
                                            <option value="1">Canada</option>
                                            <option value="2">USA</option>
                                            <option value="3">Australia</option>
                                            <option value="4">Germany</option>
                                        </select>


                                    </div>
                                </div>


                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Resim Ekle:</label>
                                    <div class="col-lg-9">
                                        <input type="file" class="file-styled">
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-lg-3 control-label">Çözüm:</label>
                                    <div class="col-lg-9">
                                        <textarea rows="5" cols="5" class="form-control" placeholder=""></textarea>
                                    </div>
                                </div>



                            </fieldset>
                        </div>
                    </div>

                    <div class="text-right">
                        <button type="submit" class="btn btn-success">TİCKET OLUŞTUR</button>
                    </div>
                </div>
            </div>
        </div>
        <!-- /2 columns form -->


        <!-- Footer -->
        <div class="footer text-muted">
            &copy; 2015. <a href="#">Limitless Web App Kit</a> by <a href="http://themeforest.net/user/Kopyov" target="_blank">Eugene Kopyov</a>
        </div>
        <!-- /footer -->

    </div>
    <!-- /content area -->
</asp:Content>
