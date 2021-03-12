<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="Raporlama.aspx.cs" Inherits="Lizay.crm.Raporlama" %>

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
    <!-- Theme JS files -->
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <script type="text/javascript">
        // 3D pie chart
        // ------------------------------

        // Initialize chart
        google.load("visualization", "1", { packages: ["corechart"] });
        google.setOnLoadCallback(drawPie3d);


        // Chart settings
        function drawPie3d() {

            // Data
            var data = google.visualization.arrayToDataTable([
        ['Name', 'Value'],
        <asp:Repeater ID="rptCharts" runat="server">
<ItemTemplate>
        ['<%# Eval("Name") %>', <%# Eval("Value") %>]
</ItemTemplate>
<SeparatorTemplate>
    ,
</SeparatorTemplate>
</asp:Repeater>
    ]);


            // Options
            var options_pie_3d = {
                fontName: 'Roboto',
                sliceVisibilityThreshold: 0.05,
                is3D: true,
                height: 340,
                width: 340,
                backgroundColor: 'transparent',
                legend: { position: 'right', textStyle: { color: 'white', fontSize: 12} },
                chartArea: { left: 10, top: 30, width: '100%', height: '100%' }
            };


            // Instantiate and draw our chart, passing in some options.
            var pie_3d = new google.visualization.PieChart($('#google-pie-3d')[0]);
            pie_3d.draw(data, options_pie_3d);
        }
    
    </script>
    <script type="text/javascript">
        // 3D pie chart
        // ------------------------------

        // Initialize chart
        google.load("visualization", "1", { packages: ["corechart"] });
        google.setOnLoadCallback(drawPie3d_2);


        // Chart settings
        function drawPie3d_2() {

            // Data
            var data2 = google.visualization.arrayToDataTable([
        ['Name', 'Value'],
        <asp:Repeater ID="rptCharts2" runat="server">
<ItemTemplate>
        ['<%# Eval("Name") %>', <%# Eval("Value") %>]
</ItemTemplate>
<SeparatorTemplate>
    ,
</SeparatorTemplate>
</asp:Repeater>
    ]);


            // Options
            var options_pie_3d_2 = {
                fontName: 'Roboto',
                sliceVisibilityThreshold: 0.05,
                is3D: true,
                height: 340,
                width: 340,
                backgroundColor: 'transparent',
                legend: { position: 'right', textStyle: { color: 'white', fontSize: 12} },
                chartArea: { left: 10, top: 30, width: '100%', height: '100%' }
            };


            // Instantiate and draw our chart, passing in some options.
            var pie_3d_2 = new google.visualization.PieChart($('#google-pie-3d-2')[0]);
            pie_3d_2.draw(data2, options_pie_3d_2);
        }
    
    </script>
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
                <%--    <div class="panel-heading" style="padding-top: 10px; padding-bottom: 10px;">
                        <h5 class="panel-title" style="text-align: center; font-size: 20px; font-weight: bold;">
                            Raporlama</h5>
                    </div>--%>
                       <div class="card-content" style="padding: 20px;">
                        <h5 class="panel-title" style="text-align: center; font-size: 18px; font-weight: bold;color:white">
                            Mağaza Raporu (Ciro Bazında)</h5>
                        <div class="col-md-12">
                            <div class="chart-container text-center content-group">
                                <div class="display-inline-block" id="google-pie-3d">
                                </div>
                            </div>
                        </div>
                        <div class="col-md-12">
                              <h5 class="panel-title" style="text-align: center; font-size: 18px; font-weight: bold;color:white">
                           Mağaza Raporu (Kar Bazında)</h5>
                            <div class="chart-container text-center content-group">
                                <div class="display-inline-block" id="google-pie-3d-2">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
