<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Lizay.ticket.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script type="text/javascript" src="assets/js/pages/tasks_list.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Page header -->
				<div class="page-header page-header-default">
					<div class="page-header-content">
							<div class="page-title">
							<h4><span class="text-semibold">Ticket Yönetimi</span> - Liste</h4>

					
						</div>

						<div class="heading-elements">
							<div class="heading-btn-group">
								<a href="YeniTicket.aspx" class="btn btn-link btn-float text-size-small "><i class=" icon-pencil text-success" style="font-size:25px;"></i><span style="text-transform:capitalize">Yeni Ticket Aç</span></a>
								<a href="Dashboard.aspx" class="btn btn-link btn-float text-size-small "><i class=" icon-list text-primary" style="font-size:25px;"></i> <span style="text-transform:capitalize">Ticket Listesi</span></a>
								<a href="Logout.aspx" class="btn btn-link btn-float text-size-small "><i class=" icon-lock5 text-danger" style="font-size:25px;"></i> <span style="text-transform:capitalize">Çıkış Yap</span></a>
							</div>
						</div>
					</div>

					<div class="breadcrumb-line">
						<ul class="breadcrumb">
							<li><a href="/">Ticket Yönetimi</a></li>
								<li class="active">Liste</li>
						</ul>

						<ul class="breadcrumb-elements">
							<li><a href="#"><i class="icon-comment-discussion position-left"></i> Support</a></li>
							<li class="dropdown">
								<a href="#" class="dropdown-toggle" data-toggle="dropdown">
									<i class="icon-gear position-left"></i>
									Settings
									<span class="caret"></span>
								</a>

								<ul class="dropdown-menu dropdown-menu-right">
									<li><a href="#"><i class="icon-user-lock"></i> Account security</a></li>
									<li><a href="#"><i class="icon-statistics"></i> Analytics</a></li>
									<li><a href="#"><i class="icon-accessibility"></i> Accessibility</a></li>
									<li class="divider"></li>
									<li><a href="#"><i class="icon-gear"></i> All settings</a></li>
								</ul>
							</li>
						</ul>
					</div>
				</div>
				<!-- /page header -->


				<!-- Content area -->
				<div class="content">

					<!-- Task manager table -->
					<div class="panel panel-white">
						<div class="panel-heading">
							<h6 class="panel-title">Ticket Yönetimi</h6>
							<div class="heading-elements">
								<ul class="icons-list">
			                		<li><a data-action="collapse"></a></li>
			                		<li><a data-action="reload"></a></li>
			                		<li><a data-action="close"></a></li>
			                	</ul>
		                	</div>
						</div>

						<table class="table tasks-list table-lg">
							<thead>
								<tr>
									<th>#</th>
									<th>Period</th>
					                <th>Ticket Başlık</th>
					                <th>Öncelik</th>
					                <th>Oluşturulma Tarihi</th>
					                <th>Statü</th>
					                <th>Sorumlu Kişi</th>
									<th class="text-center text-muted" style="width: 30px;"><i class="icon-checkmark3"></i></th>
					            </tr>
							</thead>
							<tbody>
								<tr>
									<td>#25</td>
									<td>Today</td>
					                <td>
					                	<div class="text-semibold"><a href="task_manager_detailed.html">New blog layout</a></div>
					                	<div class="text-muted">Grumbled ripely eternal sniffed the when hello less much..</div>
					                </td>
					                <td>
					                	<div class="btn-group">
											<a href="#" class="label label-danger dropdown-toggle" data-toggle="dropdown">Highest <span class="caret"></span></a>
											<ul class="dropdown-menu dropdown-menu-right">
												<li class="active"><a href="#"><span class="status-mark position-left bg-danger"></span> Highest priority</a></li>
												<li><a href="#"><span class="status-mark position-left bg-info"></span> High priority</a></li>
												<li><a href="#"><span class="status-mark position-left bg-primary"></span> Normal priority</a></li>
												<li><a href="#"><span class="status-mark position-left bg-success"></span> Low priority</a></li>
											</ul>
										</div>
				                	</td>
					                <td>
					                	<div class="input-group input-group-transparent">
					                		<div class="input-group-addon"><i class="icon-calendar2 position-left"></i></div>
					                		<input type="text" class="form-control datepicker" value="22 January, 15">
					                	</div>
				                	</td>
					                <td>
					                	<select name="status" class="select" data-placeholder="Select status">
					                		<option value="open">Open</option>
					                		<option value="hold">On hold</option>
					                		<option value="resolved" selected="selected">Resolved</option>
					                		<option value="dublicate">Dublicate</option>
					                		<option value="invalid">Invalid</option>
					                		<option value="wontfix">Wontfix</option>
					                		<option value="closed">Closed</option>
					                	</select>
					                </td>
					                <td>
					                	<a href="#"><img src="assets/images/placeholder.jpg" class="img-circle img-xs" alt=""> İbrahim Yılmaz</a>

					                </td>
									<td class="text-center">
										<ul class="icons-list">
											<li class="dropdown">
												<a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-menu9"></i></a>
												<ul class="dropdown-menu dropdown-menu-right">
													<li><a href="#"><i class="icon-alarm-add"></i> Check in</a></li>
													<li><a href="#"><i class="icon-attachment"></i> Attach screenshot</a></li>
													<li><a href="#"><i class="icon-rotate-ccw2"></i> Reassign</a></li>
													<li class="divider"></li>
													<li><a href="#"><i class="icon-pencil7"></i> Edit task</a></li>
													<li><a href="#"><i class="icon-cross2"></i> Remove</a></li>
												</ul>
											</li>
										</ul>
									</td>
					            </tr>

								<tr>
									<td>#24</td>
									<td>Today</td>
					                <td>
					                	<div class="text-semibold"><a href="task_manager_detailed.html">Create UI design model</a></div>
					                	<div class="text-muted">One morning, when Gregor Samsa woke from troubled..</div>
					                </td>
					                <td>
					                	<div class="btn-group">
											<a href="#" class="label label-danger dropdown-toggle" data-toggle="dropdown">Highest <span class="caret"></span></a>
											<ul class="dropdown-menu dropdown-menu-right">
												<li class="active"><a href="#"><span class="status-mark position-left bg-danger"></span> Highest priority</a></li>
												<li><a href="#"><span class="status-mark position-left bg-info"></span> High priority</a></li>
												<li><a href="#"><span class="status-mark position-left bg-primary"></span> Normal priority</a></li>
												<li><a href="#"><span class="status-mark position-left bg-success"></span> Low priority</a></li>
											</ul>
										</div>
				                	</td>
					                <td>
					                	<div class="input-group input-group-transparent">
					                		<div class="input-group-addon"><i class="icon-calendar2 position-left"></i></div>
					                		<input type="text" class="form-control datepicker" value="22 January, 15">
					                	</div>
				                	</td>
					                <td>
					                	<select name="status" class="select" data-placeholder="Select status">
					                		<option value="open">Open</option>
					                		<option value="hold">On hold</option>
					                		<option value="resolved">Resolved</option>
					                		<option value="dublicate">Dublicate</option>
					                		<option value="invalid">Invalid</option>
					                		<option value="wontfix">Wontfix</option>
					                		<option value="closed">Closed</option>
					                	</select>
					                </td>
					                <td>
					                	<a href="#"><img src="assets/images/placeholder.jpg" class="img-circle img-xs" alt=""></a>
					      
					                </td>
									<td class="text-center">
										<ul class="icons-list">
											<li class="dropdown">
												<a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-menu9"></i></a>
												<ul class="dropdown-menu dropdown-menu-right">
													<li><a href="#"><i class="icon-alarm-add"></i> Check in</a></li>
													<li><a href="#"><i class="icon-attachment"></i> Attach screenshot</a></li>
													<li><a href="#"><i class="icon-rotate-ccw2"></i> Reassign</a></li>
													<li class="divider"></li>
													<li><a href="#"><i class="icon-pencil7"></i> Edit task</a></li>
													<li><a href="#"><i class="icon-cross2"></i> Remove</a></li>
												</ul>
											</li>
										</ul>
									</td>
					            </tr>

								<tr>
									<td>#23</td>
									<td>Today</td>
					                <td>
					                	<div class="text-semibold"><a href="task_manager_detailed.html">New icons set for an iOS app</a></div>
					                	<div class="text-muted">A collection of textile samples lay spread out on the table..</div>
					                </td>
					                <td>
					                	<div class="btn-group">
											<a href="#" class="label label-primary dropdown-toggle" data-toggle="dropdown">Normal <span class="caret"></span></a>
											<ul class="dropdown-menu dropdown-menu-right">
												<li><a href="#"><span class="status-mark position-left bg-danger"></span> Highest priority</a></li>
												<li><a href="#"><span class="status-mark position-left bg-info"></span> High priority</a></li>
												<li class="active"><a href="#"><span class="status-mark position-left bg-primary"></span> Normal priority</a></li>
												<li><a href="#"><span class="status-mark position-left bg-success"></span> Low priority</a></li>
											</ul>
										</div>
				                	</td>
					                <td>
					                	<div class="input-group input-group-transparent">
					                		<div class="input-group-addon"><i class="icon-calendar2 position-left"></i></div>
					                		<input type="text" class="form-control datepicker" value="22 January, 15">
					                	</div>
				                	</td>
					                <td>
					                	<select name="status" class="select" data-placeholder="Select status">
					                		<option value="open">Open</option>
					                		<option value="hold" selected="selected">On hold</option>
					                		<option value="resolved">Resolved</option>
					                		<option value="dublicate">Dublicate</option>
					                		<option value="invalid">Invalid</option>
					                		<option value="wontfix">Wontfix</option>
					                		<option value="closed">Closed</option>
					                	</select>
					                </td>
					                <td>
					                	<a href="#"><img src="assets/images/placeholder.jpg" class="img-circle img-xs" alt=""></a>
					              
					                </td>
									<td class="text-center">
										<ul class="icons-list">
											<li class="dropdown">
												<a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-menu9"></i></a>
												<ul class="dropdown-menu dropdown-menu-right">
													<li><a href="#"><i class="icon-alarm-add"></i> Check in</a></li>
													<li><a href="#"><i class="icon-attachment"></i> Attach screenshot</a></li>
													<li><a href="#"><i class="icon-rotate-ccw2"></i> Reassign</a></li>
													<li class="divider"></li>
													<li><a href="#"><i class="icon-pencil7"></i> Edit task</a></li>
													<li><a href="#"><i class="icon-cross2"></i> Remove</a></li>
												</ul>
											</li>
										</ul>
									</td>
					            </tr>

								<tr>
									<td>#22</td>
									<td>Today</td>
					                <td>
					                	<div class="text-semibold"><a href="task_manager_detailed.html">Create ad campaign banners set</a></div>
					                	<div class="text-muted">That he had recently cut out of an illustrated magazine..</div>
					                </td>
					                <td>
					                	<div class="btn-group">
											<a href="#" class="label label-primary dropdown-toggle" data-toggle="dropdown">Normal <span class="caret"></span></a>
											<ul class="dropdown-menu dropdown-menu-right">
												<li><a href="#"><span class="status-mark position-left bg-danger"></span> Highest priority</a></li>
												<li><a href="#"><span class="status-mark position-left bg-info"></span> High priority</a></li>
												<li class="active"><a href="#"><span class="status-mark position-left bg-primary"></span> Normal priority</a></li>
												<li><a href="#"><span class="status-mark position-left bg-success"></span> Low priority</a></li>
											</ul>
										</div>
				                	</td>
					                <td>
					                	<div class="input-group input-group-transparent">
					                		<div class="input-group-addon"><i class="icon-calendar2 position-left"></i></div>
					                		<input type="text" class="form-control datepicker" value="22 January, 15">
					                	</div>
				                	</td>
					                <td>
					                	<select name="status" class="select" data-placeholder="Select status">
					                		<option value="open">Open</option>
					                		<option value="hold">On hold</option>
					                		<option value="resolved" selected="selected">Resolved</option>
					                		<option value="dublicate">Dublicate</option>
					                		<option value="invalid">Invalid</option>
					                		<option value="wontfix">Wontfix</option>
					                		<option value="closed">Closed</option>
					                	</select>
					                </td>
					                <td>
				                		<a href="#"><img src="assets/images/placeholder.jpg" class="img-circle img-xs" alt=""></a>
				    
					                </td>
									<td class="text-center">
										<ul class="icons-list">
											<li class="dropdown">
												<a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-menu9"></i></a>
												<ul class="dropdown-menu dropdown-menu-right">
													<li><a href="#"><i class="icon-alarm-add"></i> Check in</a></li>
													<li><a href="#"><i class="icon-attachment"></i> Attach screenshot</a></li>
													<li><a href="#"><i class="icon-rotate-ccw2"></i> Reassign</a></li>
													<li class="divider"></li>
													<li><a href="#"><i class="icon-pencil7"></i> Edit task</a></li>
													<li><a href="#"><i class="icon-cross2"></i> Remove</a></li>
												</ul>
											</li>
										</ul>
									</td>
					            </tr>


							</tbody>
						</table>
					</div>
					<!-- /task manager table -->


					<!-- Footer -->
					<div class="footer text-muted">
						&copy; 2015. <a href="#">Limitless Web App Kit</a> by <a href="http://themeforest.net/user/Kopyov" target="_blank">Eugene Kopyov</a>
					</div>
					<!-- /footer -->

				</div>
				<!-- /content area -->
</asp:Content>
