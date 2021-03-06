<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TicketDetay.aspx.cs" Inherits="Lizay.ticket.TicketDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        	<script type="text/javascript" src="assets/js/pages/task_detailed.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <!-- Page header -->
				<div class="page-header page-header-default">
					<div class="page-header-content">
							<div class="page-title">
							<h4><span class="text-semibold">Ticket Yönetimi</span> - Detay</h4>

					
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
								<li class="active">Detay</li>
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

					<!-- Detailed task -->
					<div class="row">
						<div class="col-lg-9">

							<!-- Task overview -->
							<div class="panel panel-flat">
								<div class="panel-heading mt-5">
									<h5 class="panel-title">#23: Support tickets list doesn't support commas</h5>
									<div class="heading-elements">
										<a href="#" class="btn bg-teal-400 btn-sm btn-labeled btn-labeled-right heading-btn">Check in <b><i class="icon-alarm-check"></i></b></a>
				                	</div>
								</div>

								<div class="panel-body">
									<h6 class="text-semibold">Overview</h6>
									<p class="content-group">Then sluggishly this camel learned woodchuck far stretched unspeakable notwithstanding the walked owing stung mellifluously glumly rooster more examined one that combed until a less less witless pouted up voluble timorously glared elaborate giraffe steady while grinned and got one beaver to walked. Connected picked rashly ocelot flirted while wherever unwound much more one inside emotionally well much woolly amidst upon far burned ouch sadistically became.</p>

									<h6 class="text-semibold">What we need</h6>
									<p class="content-group-lg">Some cow goose out and sweeping wow the skillfully goodness one crazily far some jeez darn well so peevish pending nudged categorically in between about much alas handsome intolerable devotedly helpfully smiled momentously next much this this next sweepingly far. Together prim and limpet much extravagantly quail longing a ouch that walking a jeepers flamingo more.</p>

									<div class="row container-fluid">
										<div class="col-sm-6">
											<div class="content-group">
												<dl>
					                                <dt class="text-size-small text-primary text-uppercase">1. Salamander much that on much</dt>
					                                <dd>Like partook magic this enthusiastic tasteful far crud otter this the ferret honey iguana.</dd>

					                                <dt class="text-size-small text-primary text-uppercase">2. Well far some raccoon</dt>
					                                <dd>Python laudably euphemistically since this copious much human this briefly hello ouch less one diligent however impotently made gave a slick up much.</dd>

					                                <dt class="text-size-small text-primary text-uppercase">3. Goldfish rapidly that far</dt>
					                                <dd>Well far some raccoon knew goose and crud behind salmon amenable oh the poignant sufficiently yikes a naked showed far reindeer imminently.</dd>
					                            </dl>
				                            </div>
										</div>

										<div class="col-sm-6">
											<div class="content-group">
												<dl>
					                                <dt class="text-size-small text-primary text-uppercase">1. Misunderstood cuffed more depending</dt>
					                                <dd>And earthworm dear arose bald agilely sad so below cowered within ceremonially therefore via much this symbolically and newt capably.</dd>

					                                <dt class="text-size-small text-primary text-uppercase">2. Voluble much saddled mechanic</dt>
					                                <dd>Much took between less goodness jay mallard kneeled gnashed this up strong cooperative.</dd>

					                                <dt class="text-size-small text-primary text-uppercase">3. Before some one more</dt>
					                                <dd>Pending some contrary rabbit up that the more conditionally ouch confidently far so was darn logic thus dove the juicily because that placed otter.</dd>
					                            </dl>
				                            </div>
										</div>
				                    </div>

				                    <h6 class="text-semibold">Requirements</h6>
									<p class="content-group">So slit more darn hey well wore submissive savage this shark aardvark fumed thoughtfully much drank when angelfish so outgrew some alas vigorously therefore warthog superb less oh groundhog less alas gibbered barked some hey despicably with aesthetic hamster jay by luckily.</p>

									<div class="table-responsive content-group">
										<table class="table table-framed">
											<thead>
												<tr>
													<th style="width: 20px;">#</th>
													<th class="col-xs-3">Task</th>
													<th class="col-xs-2">Due date</th>
													<th>Description</th>
												</tr>
											</thead>
											<tbody>
												<tr>
													<td>1</td>
													<td><span class="text-semibold">Design mockup</span></td>
													<td>
									                	<div class="input-group input-group-transparent">
									                		<div class="input-group-addon"><i class="icon-calendar22 position-left"></i></div>
									                		<input type="text" class="form-control datepicker" value="21 January, 15">
									                	</div>
													</td>
													<td>Create design mockups for a new app, must be delivered before 1st of March</td>
												</tr>
												<tr>
													<td>2</td>
													<td><span class="text-semibold">User interface research</span></td>
													<td>
									                	<div class="input-group input-group-transparent">
									                		<div class="input-group-addon"><i class="icon-calendar22 position-left"></i></div>
									                		<input type="text" class="form-control datepicker" value="24 January, 15">
									                	</div>
													</td>
													<td>Create a focus group with random people, provide a research statement</td>
												</tr>
												<tr>
													<td>3</td>
													<td><span class="text-semibold">New icons set</span></td>
													<td>
									                	<div class="input-group input-group-transparent">
									                		<div class="input-group-addon"><i class="icon-calendar22 position-left"></i></div>
									                		<input type="text" class="form-control datepicker" value="28 January, 15">
									                	</div>
													</td>
													<td>Create a full set of icons required for the iOS application, send them to team lead for review</td>
												</tr>
												<tr>
													<td>4</td>
													<td><span class="text-semibold">Loading optimization</span></td>
													<td>
									                	<div class="input-group input-group-transparent">
									                		<div class="input-group-addon"><i class="icon-calendar22 position-left"></i></div>
									                		<input type="text" class="form-control datepicker" value="1 February, 15">
									                	</div>
													</td>
													<td>Review image sizes, compress them as much as possible, make sure page loading time is less than 1 second</td>
												</tr>
											</tbody>
										</table>
									</div>

				                    <h6 class="text-semibold">Uploaded files</h6>
									<p>A much goodness between destructive that save stupid firefly destructively dog goldfinch continually alas pinched for outside flailed inescapably hey brought rid crud and awakened sobbed extraordinarily wherever deer before tenable yet into dalmatian opposite save close ahead next independent mindful but far.</p>

									<div class="row">
										<div class="col-md-3 col-sm-6">
											<div class="thumbnail">
												<div class="thumb">
													<img src="assets/images/placeholder.jpg" alt="">
													<div class="caption-overflow">
														<span>
															<a href="#" class="btn bg-success-300 btn-xs btn-icon"><i class="icon-zoomin3"></i></a>
															<a href="#" class="btn bg-success-300 btn-xs btn-icon"><i class="icon-download"></i></a>
														</span>
													</div>
												</div>

												<div class="caption text-center">
													 dashboard_draft.png
												</div>
											</div>
										</div>

										<div class="col-md-3 col-sm-6">
											<div class="thumbnail">
												<div class="thumb">
													<img src="assets/images/placeholder.jpg" alt="">
													<div class="caption-overflow">
														<span>
															<a href="#" class="btn bg-success-300 btn-xs btn-icon"><i class="icon-zoomin3"></i></a>
															<a href="#" class="btn bg-success-300 btn-xs btn-icon"><i class="icon-download"></i></a>
														</span>
													</div>
												</div>

												<div class="caption text-center">
													 profile_page.png
												</div>
											</div>
										</div>

										<div class="col-md-3 col-sm-6">
											<div class="thumbnail">
												<div class="thumb">
													<img src="assets/images/placeholder.jpg" alt="">
													<div class="caption-overflow">
														<span>
															<a href="#" class="btn bg-success-300 btn-xs btn-icon"><i class="icon-zoomin3"></i></a>
															<a href="#" class="btn bg-success-300 btn-xs btn-icon"><i class="icon-download"></i></a>
														</span>
													</div>
												</div>

												<div class="caption text-center">
													 shopping_cart.png
												</div>
											</div>
										</div>

										<div class="col-md-3 col-sm-6">
											<div class="thumbnail">
												<div class="thumb">
													<img src="assets/images/placeholder.jpg" alt="">
													<div class="caption-overflow">
														<span>
															<a href="#" class="btn bg-success-300 btn-xs btn-icon"><i class="icon-zoomin3"></i></a>
															<a href="#" class="btn bg-success-300 btn-xs btn-icon"><i class="icon-download"></i></a>
														</span>
													</div>
												</div>

												<div class="caption text-center">
													 sales_statistics.png
												</div>
											</div>
										</div>
									</div>
								</div>

						    	<div class="panel-footer">
									<div class="heading-elements">
										<ul class="list-inline list-inline-condensed heading-text">
											<li><span class="status-mark border-blue position-left"></span> Status:</li>
											<li class="dropdown">
												<a href="#" class="text-default text-semibold dropdown-toggle" data-toggle="dropdown">Open <span class="caret"></span></a>
												<ul class="dropdown-menu">
													<li class="active"><a href="#">Open</a></li>
													<li><a href="#">On hold</a></li>
													<li><a href="#">Resolved</a></li>
													<li><a href="#">Closed</a></li>
													<li class="divider"></li>
													<li><a href="#">Dublicate</a></li>
													<li><a href="#">Invalid</a></li>
													<li><a href="#">Wontfix</a></li>
												</ul>
											</li>
										</ul>

										<ul class="list-inline list-inline-condensed heading-text pull-right">
											<li><a href="#" class="text-default"><i class="icon-compose"></i></a></li>
											<li><a href="#" class="text-default"><i class="icon-trash"></i></a></li>
											<li class="dropdown">
												<a href="#" class="text-default dropdown-toggle" data-toggle="dropdown"><i class="icon-grid-alt"></i> <span class="caret"></span></a>
												<ul class="dropdown-menu dropdown-menu-right">
													<li><a href="#"><i class="icon-alarm-add"></i> Check in</a></li>
													<li><a href="#"><i class="icon-attachment"></i> Attach screenshot</a></li>
													<li><a href="#"><i class="icon-user-plus"></i> Assign users</a></li>
													<li><a href="#"><i class="icon-warning2"></i> Report</a></li>
												</ul>
											</li>
										</ul>
									</div>
								</div>
							</div>
							<!-- /task overview -->


							<!-- Comments -->
							<div class="panel panel-flat">
								<div class="panel-heading">
									<h5 class="panel-title text-semiold"><i class="icon-bubbles4 position-left"></i> Comments</h5>
									<div class="heading-elements">
										<a href="#" class="btn bg-blue btn-xs btn-icon"><i class="icon-plus2"></i></a>
				                	</div>
								</div>

								<div class="panel-body">
									<ul class="media-list content-group-lg stack-media-on-mobile">
										<li class="media">
											<div class="media-left">
												<a href="#"><img src="assets/images/placeholder.jpg" class="img-circle img-sm" alt=""></a>
											</div>

											<div class="media-body">
												<div class="media-heading">
													<a href="#" class="text-semibold">William Jennings</a>
													<span class="media-annotation dotted">Just now</span>
												</div>

												<p>He moonlight difficult engrossed an it sportsmen. Interested has all devonshire difficulty gay assistance joy. Unaffected at ye of compliment alteration to.</p>

												<ul class="list-inline list-inline-separate text-size-small">
													<li>114 <a href="#"><i class="icon-arrow-up22 text-success"></i></a><a href="#"><i class="icon-arrow-down22 text-danger"></i></a></li>
													<li><a href="#">Reply</a></li>
													<li><a href="#">Edit</a></li>
												</ul>
											</div>
										</li>

										<li class="media">
											<div class="media-left">
												<a href="#"><img src="assets/images/placeholder.jpg" class="img-circle img-sm" alt=""></a>
											</div>

											<div class="media-body">
												<div class="media-heading">
													<a href="#" class="text-semibold">Margo Baker</a>
													<span class="media-annotation dotted">5 minutes ago</span>
												</div>

												<p>Place voice no arise along to. Parlors waiting so against me no. Wishing calling are warrant settled was luckily. Express besides it present if at an opinion visitor.</p>

												<ul class="list-inline list-inline-separate text-size-small">
													<li>90 <a href="#"><i class="icon-arrow-up22 text-success"></i></a><a href="#"><i class="icon-arrow-down22 text-danger"></i></a></li>
													<li><a href="#">Reply</a></li>
													<li><a href="#">Edit</a></li>
												</ul>
											</div>
										</li>

										<li class="media">
											<div class="media-left">
												<a href="#"><img src="assets/images/placeholder.jpg" class="img-circle img-sm" alt=""></a>
											</div>

											<div class="media-body">
												<div class="media-heading">
													<a href="#" class="text-semibold">James Alexander</a>
													<span class="media-annotation dotted">7 minutes ago</span>
												</div>

												<p>Savings her pleased are several started females met. Short her not among being any. Thing of judge fruit charm views do. Miles mr an forty along as he.</p>

												<ul class="list-inline list-inline-separate text-size-small">
													<li>70 <a href="#"><i class="icon-arrow-up22 text-success"></i></a><a href="#"><i class="icon-arrow-down22 text-danger"></i></a></li>
													<li><a href="#">Reply</a></li>
													<li><a href="#">Edit</a></li>
												</ul>

												<div class="media">
													<div class="media-left">
														<a href="#"><img src="assets/images/placeholder.jpg" class="img-circle img-sm" alt=""></a>
													</div>

													<div class="media-body">
														<div class="media-heading">
															<a href="#" class="text-semibold">Jack Cooper</a>
															<span class="media-annotation dotted">10 minutes ago</span>
														</div>

														<p>She education get middleton day agreement performed preserved unwilling. Do however as pleased offence outward beloved by present. By outward neither he so covered.</p>

														<ul class="list-inline list-inline-separate text-size-small">
															<li>67 <a href="#"><i class="icon-arrow-up22 text-success"></i></a><a href="#"><i class="icon-arrow-down22 text-danger"></i></a></li>
															<li><a href="#">Reply</a></li>
															<li><a href="#">Edit</a></li>
														</ul>

														<div class="media">
															<div class="media-left">
																<a href="#"><img src="assets/images/placeholder.jpg" class="img-circle img-sm" alt=""></a>
															</div>

															<div class="media-body">
																<div class="media-heading">
																	<a href="#" class="text-semibold">Natalie Wallace</a>
																	<span class="media-annotation dotted">1 hour ago</span>
																</div>

																<p>Juvenile proposal betrayed he an informed weddings followed. Precaution day see imprudence sympathize principles. At full leaf give quit to in they up.</p>

																<ul class="list-inline list-inline-separate text-size-small">
																	<li>54 <a href="#"><i class="icon-arrow-up22 text-success"></i></a><a href="#"><i class="icon-arrow-down22 text-danger"></i></a></li>
																	<li><a href="#">Reply</a></li>
																	<li><a href="#">Edit</a></li>
																</ul>
															</div>
														</div>

														<div class="media">
															<div class="media-left">
																<a href="#"><img src="assets/images/placeholder.jpg" class="img-circle img-sm" alt=""></a>
															</div>

															<div class="media-body">
																<div class="media-heading">
																	<a href="#" class="text-semibold">Nicolette Grey</a>
																	<span class="media-annotation dotted">2 hours ago</span>
																</div>

																<p>Although moreover mistaken kindness me feelings do be marianne. Son over own nay with tell they cold upon are. Cordial village and settled she ability law herself.</p>

																<ul class="list-inline list-inline-separate text-size-small">
																	<li>41 <a href="#"><i class="icon-arrow-up22 text-success"></i></a><a href="#"><i class="icon-arrow-down22 text-danger"></i></a></li>
																	<li><a href="#">Reply</a></li>
																	<li><a href="#">Edit</a></li>
																</ul>
															</div>
														</div>
													</div>
												</div>
											</div>
										</li>

										<li class="media">
											<div class="media-left">
												<a href="#"><img src="assets/images/placeholder.jpg" class="img-circle img-sm" alt=""></a>
											</div>

											<div class="media-body">
												<div class="media-heading">
													<a href="#" class="text-semibold">Victoria Johnson</a>
													<span class="media-annotation dotted">3 hours ago</span>
												</div>

												<p>Finished why bringing but sir bachelor unpacked any thoughts. Unpleasing unsatiable particular inquietude did nor sir.</p>

												<ul class="list-inline list-inline-separate text-size-small">
													<li>32 <a href="#"><i class="icon-arrow-up22 text-success"></i></a><a href="#"><i class="icon-arrow-down22 text-danger"></i></a></li>
													<li><a href="#">Reply</a></li>
													<li><a href="#">Edit</a></li>
												</ul>
											</div>
										</li>
									</ul>

									<h6 class="text-semibold"><i class="icon-pencil7 position-left"></i> Your comment</h6>
									<div class="content-group">
										<div id="add-comment">Get his declared appetite distance his together now families. Friends am himself at on norland it viewing. Suspected elsewhere you belonging continued commanded she...</div>
									</div>
									
									<div class="text-right">
										<button type="button" class="btn bg-blue"><i class="icon-plus22"></i> Add comment</button>
									</div>
								</div>
							</div>
							<!-- /comments -->

						</div>

						<div class="col-lg-3">

							<!-- Timer -->
							<div class="panel panel-flat">
								<div class="panel-heading">
									<h6 class="panel-title"><i class="icon-watch position-left"></i> Task timer</h6>
									<div class="heading-elements">
										<ul class="icons-list">
					                		<li><a data-action="collapse"></a></li>
					                		<li><a data-action="reload"></a></li>
					                		<li><a data-action="close"></a></li>
					                	</ul>
				                	</div>
								</div>

								<div class="panel-body">
									<ul class="timer-weekdays mb-10">
										<li><a href="#" class="label label-default">Mon</a></li>
										<li class="active"><a href="#" class="label label-danger">Tue</a></li>
										<li><a href="#" class="label label-default">Wed</a></li>
										<li><a href="#" class="label label-default">Thu</a></li>
										<li><a href="#" class="label label-default">Fri</a></li>
										<li><a href="#" class="label label-default">Sat</a></li>
										<li><a href="#" class="label label-default">Sun</a></li>
									</ul>

								    <ul class="timer mb-10">
								        <li>
								        	09 <span>hours</span>
								        </li>
								        <li class="dots">:</li>
								        <li>
								        	54 <span>minutes</span>
								        </li>
								        <li class="dots">:</li>
								        <li>
								        	29 <span>seconds</span>
								        </li>
								    </ul>
							    </div>

						    	<div class="panel-footer panel-footer-transparent">
									<div class="heading-elements">
										<ul class="list-inline list-inline-condensed heading-text">
											<li><a href="#" class="text-default"><i class="icon-play3"></i></a></li>
											<li><a href="#" class="text-default"><i class="icon-pause"></i></a></li>
											<li><a href="#" class="text-default"><i class="icon-stop"></i></a></li>
										</ul>

										<ul class="list-inline list-inline-condensed heading-text pull-right">
											<li class="dropdown">
												<a href="#" class="text-default dropdown-toggle" data-toggle="dropdown">
													<span class="status-mark border-success position-left"></span>
													Open
													<span class="caret"></span>
												</a>

												<ul class="dropdown-menu dropdown-menu-right">
													<li class="active"><a href="#">Open</a></li>
													<li><a href="#">On hold</a></li>
													<li><a href="#">Resolved</a></li>
													<li><a href="#">Closed</a></li>
													<li class="divider"></li>
													<li><a href="#">Dublicate</a></li>
													<li><a href="#">Invalid</a></li>
													<li><a href="#">Wontfix</a></li>
												</ul>
											</li>
										</ul>
									</div>
								</div>
							</div>
							<!-- /timer -->


							<!-- Task details -->
							<div class="panel panel-flat">
								<div class="panel-heading">
									<h6 class="panel-title"><i class="icon-files-empty position-left"></i> Task details</h6>
									<div class="heading-elements">
										<ul class="icons-list">
					                		<li><a data-action="collapse"></a></li>
					                		<li><a data-action="reload"></a></li>
					                		<li><a data-action="close"></a></li>
					                	</ul>
				                	</div>
								</div>

								<table class="table table-borderless table-xs content-group-sm">
									<tbody>
										<tr>
											<td><i class="icon-briefcase position-left"></i> Project:</td>
											<td class="text-right"><span class="pull-right"><a href="#">Singular app</a></span></td>
										</tr>
										<tr>
											<td><i class="icon-alarm-add position-left"></i> Updated:</td>
											<td class="text-right">12 May, 2015</td>
										</tr>
										<tr>
											<td><i class="icon-alarm-check position-left"></i> Created:</td>
											<td class="text-right">25 Feb, 2015</td>
										</tr>
										<tr>
											<td><i class="icon-circles2 position-left"></i> Priority:</td>
											<td class="text-right">
												<div class="btn-group">
													<a href="#" class="label label-danger dropdown-toggle" data-toggle="dropdown">Highest <span class="caret"></span></a>
													<ul class="dropdown-menu dropdown-menu-right">
														<li><a href="#"><span class="status-mark position-left bg-danger"></span> Highest priority</a></li>
														<li><a href="#"><span class="status-mark position-left bg-info"></span> High priority</a></li>
														<li><a href="#"><span class="status-mark position-left bg-primary"></span> Normal priority</a></li>
														<li><a href="#"><span class="status-mark position-left bg-success"></span> Low priority</a></li>
													</ul>
												</div>
											</td>
										</tr>
										<tr>
											<td><i class="icon-history position-left"></i> Revisions:</td>
											<td class="text-right">29</td>
										</tr>
										<tr>
											<td><i class="icon-file-plus position-left"></i> Added by:</td>
											<td class="text-right"><a href="#">Winnie</a></td>
										</tr>
										<tr>
											<td><i class="icon-file-check position-left"></i> Status:</td>
											<td class="text-right">Published</td>
										</tr>
									</tbody>
								</table>

						    	<div class="panel-footer panel-footer-condensed">
									<div class="heading-elements">
										<ul class="list-inline list-inline-condensed heading-text">
											<li><a href="#" class="text-default"><i class="icon-pencil7"></i></a></li>
											<li><a href="#" class="text-default"><i class="icon-bin"></i></a></li>
										</ul>

										<ul class="list-inline list-inline-condensed heading-text pull-right">
											<li><a href="#" class="text-default"><i class="icon-statistics"></i></a></li>
											<li class="dropdown">
												<a href="#" class="text-default dropdown-toggle" data-toggle="dropdown"><i class="icon-gear"></i><span class="caret"></span></a>
												<ul class="dropdown-menu dropdown-menu-right">
													<li><a href="#"><i class="icon-alarm-add"></i> Check in</a></li>
													<li><a href="#"><i class="icon-attachment"></i> Attach screenshot</a></li>
													<li><a href="#"><i class="icon-user-plus"></i> Assign users</a></li>
													<li><a href="#"><i class="icon-warning2"></i> Report</a></li>
												</ul>
											</li>
										</ul>
									</div>
								</div>
							</div>
							<!-- /task details -->


							<!-- Task settings -->
							<div class="panel panel-flat">
								<div class="panel-heading">
									<h6 class="panel-title"><i class="icon-cog3 position-left"></i> Task settings</h6>
									<div class="heading-elements">
										<ul class="icons-list">
					                		<li><a data-action="collapse"></a></li>
					                		<li><a data-action="reload"></a></li>
					                		<li><a data-action="close"></a></li>
					                	</ul>
				                	</div>
								</div>

								<div class="panel-body">
									<form action="#">
										<div class="form-group">
											<div class="checkbox checkbox-switchery checkbox-right switchery-xs">
												<label class="display-block">
													<input type="checkbox" class="switchery" checked="checked">
													Publish after save
												</label>	
											</div>

											<div class="checkbox checkbox-switchery checkbox-right switchery-xs">
												<label class="display-block">
													<input type="checkbox" class="switchery">
													Allow comments
												</label>
											</div>

											<div class="checkbox checkbox-switchery checkbox-right switchery-xs">
												<label class="display-block">
													<input type="checkbox" class="switchery" checked="checked">
													Allow users to edit the task
												</label>
											</div>

											<div class="checkbox checkbox-switchery checkbox-right switchery-xs">
												<label class="display-block">
													<input type="checkbox" class="switchery" checked="checked">
													Use task timer
												</label>
											</div>

											<div class="checkbox checkbox-switchery checkbox-right switchery-xs">
												<label class="display-block">
													<input type="checkbox" class="switchery">
													Auto saving
												</label>
											</div>

											<div class="checkbox checkbox-switchery checkbox-right switchery-xs">
												<label class="display-block">
													<input type="checkbox" class="switchery" checked="checked">
													Allow attachments
												</label>
											</div>
										</div>

										<div class="row">
											<div class="col-md-6">
												<p><button class="btn btn-default btn-sm btn-block" type="button">Reset</button></p>
											</div>

											<div class="col-md-6">
												<p><button class="btn btn-primary btn-sm btn-block" type="button">Save</button></p>
											</div>
										</div>
									</form>
								</div>
							</div>
							<!-- /task settings -->


							<!-- Revisions -->
							<div class="panel panel-flat">
								<div class="panel-heading">
									<h6 class="panel-title"><i class="icon-git-commit position-left"></i> Revisions</h6>
									<div class="heading-elements">
										<ul class="icons-list">
					                		<li><a data-action="collapse"></a></li>
					                		<li><a data-action="reload"></a></li>
					                		<li><a data-action="close"></a></li>
					                	</ul>
				                	</div>
								</div>

								<div class="panel-body">
									<ul class="media-list">
										<li class="media">
											<div class="media-left"><a href="#" class="btn border-primary text-primary btn-icon btn-flat btn-sm btn-rounded"><i class="icon-git-pull-request"></i></a></div>
											<div class="media-body">
												Drop the IE <a href="#">specific hacks</a> for temporal inputs
												<div class="media-annotation">4 minutes ago</div>
											</div>
										</li>

										<li class="media">
											<div class="media-left"><a href="#" class="btn border-warning text-warning btn-icon btn-flat btn-sm btn-rounded"><i class="icon-git-commit"></i></a></div>
											<div class="media-body">
												Add full font overrides for popovers and tooltips
												<div class="media-annotation">36 minutes ago</div>
											</div>
										</li>

										<li class="media">
											<div class="media-left"><a href="#" class="btn border-info text-info btn-icon btn-flat btn-sm btn-rounded"><i class="icon-git-branch"></i></a></div>
											<div class="media-body">
												<a href="#">Chris Arney</a> created a new <span class="text-semibold">Design</span> branch
												<div class="media-annotation">2 hours ago</div>
											</div>
										</li>

										<li class="media">
											<div class="media-left"><a href="#" class="btn border-success text-success btn-icon btn-flat btn-sm btn-rounded"><i class="icon-git-merge"></i></a></div>
											<div class="media-body">
												<a href="#">Eugene Kopyov</a> merged <span class="text-semibold">Master</span> and <span class="text-semibold">Dev</span> branches
												<div class="media-annotation">Dec 18, 18:36</div>
											</div>
										</li>

										<li class="media">
											<div class="media-left"><a href="#" class="btn border-primary text-primary btn-icon btn-flat btn-sm btn-rounded"><i class="icon-git-pull-request"></i></a></div>
											<div class="media-body">
												Have Carousel ignore keyboard events
												<div class="media-annotation">Dec 12, 05:46</div>
											</div>
										</li>
									</ul>
								</div>
							</div>
							<!-- /revisions -->


							<!-- Attached files -->
							<div class="panel panel-flat">
								<div class="panel-heading">
									<h6 class="panel-title"><i class="icon-link position-left"></i> Attached files</h6>
									<div class="heading-elements">
										<ul class="icons-list">
					                		<li><a data-action="collapse"></a></li>
					                		<li><a data-action="reload"></a></li>
					                		<li><a data-action="close"></a></li>
					                	</ul>
				                	</div>
								</div>

								<div class="panel-body">
									<ul class="media-list">
										<li class="media">
											<div class="media-left media-middle">
												<i class="icon-file-word icon-2x text-muted"></i>
											</div>

											<div class="media-body">
												<a href="#" class="media-heading text-semibold">Overdrew_scowled.doc</a>
												<ul class="list-inline list-inline-separate list-inline-condensed text-size-mini text-muted">
													<li>Size: 1.2Mb</li>
													<li>Added by <a href="#">Winnie</a></li>
												</ul>
											</div>

											<div class="media-right media-middle">
												<ul class="icons-list">
													<li><a href="#"><i class="icon-download"></i></a></li>
												</ul>
											</div>
										</li>

										<li class="media">
											<div class="media-left media-middle">
												<i class="icon-file-stats icon-2x text-muted"></i>
											</div>

											<div class="media-body">
												<a href="#" class="media-heading text-semibold">And_less_maternally.pdf</a>
												<ul class="list-inline list-inline-separate list-inline-condensed text-size-mini text-muted">
													<li>Size: 0.9Mb</li>
													<li>Added by <a href="#">Eugene</a></li>
												</ul>
											</div>

											<div class="media-right media-middle">
												<ul class="icons-list">
													<li><a href="#"><i class="icon-download"></i></a></li>
												</ul>
											</div>
										</li>

										<li class="media">
											<div class="media-left media-middle">
												<i class="icon-file-pdf icon-2x text-muted"></i>
											</div>
											
											<div class="media-body">
												<a href="#" class="media-heading text-semibold">The_less_overslept.pdf</a>
												<ul class="list-inline list-inline-separate list-inline-condensed text-size-mini text-muted">
													<li>Size: 4.3Mb</li>
													<li>Added by <a href="#">Natalie</a></li>
												</ul>
											</div>
											
											<div class="media-right media-middle">
												<ul class="icons-list">
													<li><a href="#"><i class="icon-download"></i></a></li>
												</ul>
											</div>
										</li>

										<li class="media">
											<div class="media-left media-middle">
												<i class="icon-file-video icon-2x text-muted"></i>
											</div>
											
											<div class="media-body">
												<a href="#" class="media-heading text-semibold">Well_equitably.mov</a>
												<ul class="list-inline list-inline-separate list-inline-condensed text-size-mini text-muted">
													<li>Size: 14.8Mb</li>
													<li>Added by <a href="#">Jenny</a></li>
												</ul>
											</div>

											<div class="media-right media-middle">
												<ul class="icons-list">
													<li><a href="#"><i class="icon-download"></i></a></li>
												</ul>
											</div>
										</li>
									</ul>
								</div>
							</div>
							<!-- /attached files -->


							<!-- Assigned users -->
							<div class="panel panel-flat">
								<div class="panel-heading">
									<h6 class="panel-title"><i class="icon-users position-left"></i> Assigned users</h6>
									<div class="heading-elements">
										<ul class="icons-list">
					                		<li><a data-action="collapse"></a></li>
					                		<li><a data-action="reload"></a></li>
					                		<li><a data-action="close"></a></li>
					                	</ul>
				                	</div>
								</div>

								<div class="panel-body">
									<ul class="media-list">
										<li class="media">
											<div class="media-left">
												<a href="#">
													<img src="assets/images/placeholder.jpg" class="img-sm img-circle" alt="">
													<span class="badge bg-warning-400 media-badge">6</span>
												</a>
											</div>

											<div class="media-body media-middle text-semibold">
												Rebecca Jameson
												<div class="media-annotation">Web developer</div>
											</div>

											<div class="media-right media-middle">
												<ul class="icons-list text-nowrap">
													<li>
														<a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-more2"></i></a>
														<ul class="dropdown-menu dropdown-menu-right">
															<li><a href="#"><i class="icon-comment-discussion pull-right"></i> Start chat</a></li>
															<li><a href="#"><i class="icon-phone2 pull-right"></i> Make a call</a></li>
															<li><a href="#"><i class="icon-mail5 pull-right"></i> Send mail</a></li>
															<li class="divider"></li>
															<li><a href="#"><i class="icon-statistics pull-right"></i> Statistics</a></li>
														</ul>
													</li>
												</ul>
											</div>
										</li>

										<li class="media">
											<div class="media-left">
												<a href="#">
													<img src="assets/images/placeholder.jpg" class="img-sm img-circle" alt="">
													<span class="badge bg-warning-400 media-badge">9</span>
												</a>
											</div>

											<div class="media-body media-middle text-semibold">
												Walter Sommers
												<div class="media-annotation">Lead developer</div>
											</div>

											<div class="media-right media-middle">
												<ul class="icons-list text-nowrap">
													<li>
														<a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-more2"></i></a>
														<ul class="dropdown-menu dropdown-menu-right">
															<li><a href="#"><i class="icon-comment-discussion pull-right"></i> Start chat</a></li>
															<li><a href="#"><i class="icon-phone2 pull-right"></i> Make a call</a></li>
															<li><a href="#"><i class="icon-mail5 pull-right"></i> Send mail</a></li>
															<li class="divider"></li>
															<li><a href="#"><i class="icon-statistics pull-right"></i> Statistics</a></li>
														</ul>
													</li>
												</ul>
											</div>
										</li>

										<li class="media">
											<div class="media-left">
												<a href="#"><img src="assets/images/placeholder.jpg" class="img-sm img-circle" alt=""></a>
											</div>

											<div class="media-body media-middle text-semibold">
												Otto Gerwald
												<div class="media-annotation">Front end developer</div>
											</div>

											<div class="media-right media-middle">
												<ul class="icons-list text-nowrap">
													<li>
														<a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-more2"></i></a>
														<ul class="dropdown-menu dropdown-menu-right">
															<li><a href="#"><i class="icon-comment-discussion pull-right"></i> Start chat</a></li>
															<li><a href="#"><i class="icon-phone2 pull-right"></i> Make a call</a></li>
															<li><a href="#"><i class="icon-mail5 pull-right"></i> Send mail</a></li>
															<li class="divider"></li>
															<li><a href="#"><i class="icon-statistics pull-right"></i> Statistics</a></li>
														</ul>
													</li>
												</ul>
											</div>
										</li>

										<li class="media">
											<div class="media-left">
												<a href="#"><img src="assets/images/placeholder.jpg" class="img-sm img-circle" alt=""></a>
											</div>

											<div class="media-body media-middle text-semibold">
												Vince Satmann
												<div class="media-annotation">UX expert</div>
											</div>

											<div class="media-right media-middle">
												<ul class="icons-list text-nowrap">
													<li>
														<a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-more2"></i></a>
														<ul class="dropdown-menu dropdown-menu-right">
															<li><a href="#"><i class="icon-comment-discussion pull-right"></i> Start chat</a></li>
															<li><a href="#"><i class="icon-phone2 pull-right"></i> Make a call</a></li>
															<li><a href="#"><i class="icon-mail5 pull-right"></i> Send mail</a></li>
															<li class="divider"></li>
															<li><a href="#"><i class="icon-statistics pull-right"></i> Statistics</a></li>
														</ul>
													</li>
												</ul>
											</div>
										</li>

										<li class="media">
											<div class="media-left">
												<a href="#"><img src="assets/images/placeholder.jpg" class="img-sm img-circle" alt=""></a>
											</div>

											<div class="media-body media-middle text-semibold">
												Jason Leroy
												<div class="media-annotation">SEO specialist</div>
											</div>

											<div class="media-right media-middle">
												<ul class="icons-list text-nowrap">
													<li>
														<a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-more2"></i></a>
														<ul class="dropdown-menu dropdown-menu-right">
															<li><a href="#"><i class="icon-comment-discussion pull-right"></i> Start chat</a></li>
															<li><a href="#"><i class="icon-phone2 pull-right"></i> Make a call</a></li>
															<li><a href="#"><i class="icon-mail5 pull-right"></i> Send mail</a></li>
															<li class="divider"></li>
															<li><a href="#"><i class="icon-statistics pull-right"></i> Statistics</a></li>
														</ul>
													</li>
												</ul>
											</div>
										</li>
									</ul>
								</div>
							</div>
							<!-- /assigned users -->


							<!-- Latest comments -->
							<div class="panel panel-flat">
								<div class="panel-heading">
									<h6 class="panel-title"><i class="icon-bubbles3 position-left"></i> Latest comments</h6>
									<div class="heading-elements">
										<ul class="icons-list">
					                		<li><a data-action="collapse"></a></li>
					                		<li><a data-action="reload"></a></li>
					                		<li><a data-action="close"></a></li>
					                	</ul>
				                	</div>
								</div>

								<ul class="media-list media-list-linked">
									<li class="media">
										<a href="#" class="media-link">
											<div class="media-left"><img src="assets/images/placeholder.jpg" class="img-sm img-circle" alt=""></div>
											<div class="media-body">
												<div class="media-heading"><span class="text-semibold">Will Samuel</span> <span class="media-annotation pull-right">Just now</span></div>
												<span class="text-muted">And he looked over at the alarm clock, ticking..</span>
											</div>
										</a>
									</li>

									<li class="media">
										<a href="#" class="media-link">
											<div class="media-left"><img src="assets/images/placeholder.jpg" class="img-sm img-circle" alt=""></div>
											<div class="media-body">
												<div class="media-heading"><span class="text-semibold">Margo Baker</span> <span class="media-annotation pull-right">1 hour ago</span></div>
												<span class="text-muted">However hard he threw himself onto..</span>
												
											</div>
										</a>
									</li>

									<li class="media">
										<a href="#" class="media-link">
											<div class="media-left"><img src="assets/images/placeholder.jpg" class="img-sm img-circle" alt=""></div>
											<div class="media-body">
												<div class="media-heading"><span class="text-semibold">Monica Smith</span> <span class="media-annotation pull-right">2 days ago</span></div>
												<span class="text-muted">Yes, but was it possible to quietly sleep through..</span>
											</div>
										</a>
									</li>

									<li class="media">
										<a href="#" class="media-link">
											<div class="media-left"><img src="assets/images/placeholder.jpg" class="img-sm img-circle" alt=""></div>
											<div class="media-body">
												<div class="media-heading"><span class="text-semibold">Jordana Mills</span> <span class="media-annotation pull-right">Monday</span></div>
												<span class="text-muted">What should he do now? The next train went at..</span>
											</div>
										</a>
									</li>

									<li class="media">
										<a href="#" class="media-link">
											<div class="media-left"><img src="assets/images/placeholder.jpg" class="img-sm img-circle" alt=""></div>
											<div class="media-body">
												<div class="media-heading"><span class="text-semibold">John Craving</span> <span class="media-annotation pull-right">May 24</span></div>
												<span class="text-muted">Gregor then turned to look out the window..</span>
											</div>
										</a>
									</li>
								</ul>
							</div>
							<!-- /latest comments -->

						</div>
					</div>
					<!-- /detailed task -->


					<!-- Footer -->
					<div class="footer text-muted">
						&copy; 2015. <a href="#">Limitless Web App Kit</a> by <a href="http://themeforest.net/user/Kopyov" target="_blank">Eugene Kopyov</a>
					</div>
					<!-- /footer -->

				</div>
				<!-- /content area -->
</asp:Content>
