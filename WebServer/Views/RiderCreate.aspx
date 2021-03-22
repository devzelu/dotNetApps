<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RiderCreate.aspx.cs" Inherits="WebServer.Views.RiderCreate" %>


<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="utf-8" />
  <link rel="apple-touch-icon" sizes="76x76" href="../assets/img/apple-icon.png">
  <link rel="icon" type="image/png" href="../assets/img/favicon.png">
  <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
  <title>
    MotoGP Riders Create
  </title>
  <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
  <!--     Fonts and icons     -->
  <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700,200" rel="stylesheet" />
  <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.1/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
  <!-- CSS Files -->
  <link href="../assets/css/bootstrap.min.css" rel="stylesheet" />
  <link href="../assets/css/now-ui-dashboard.css?v=1.3.0" rel="stylesheet" />
  <!-- CSS Just for demo purpose, don't include it in your project -->
  <link href="../assets/demo/demo.css" rel="stylesheet" />

</head>

<body class="user-profile">
  <div class="wrapper ">
    <div class="sidebar" data-color="orange">
      <!--
        Tip 1: You can change the color of the sidebar using: data-color="blue | green | orange | red | yellow"
    -->
      <div class="logo">
        <a href="RidersTable.aspx" class="simple-text logo-normal">
          MotoGP
        </a>
      </div>
      <div class="sidebar-wrapper" id="sidebar-wrapper">
        <ul class="nav">
          <li class="active ">
            <a href="#">
              <i class="now-ui-icons users_single-02"></i>
              <p>Rider Profile</p>
            </a>
          </li>
          <li>
            <a href="./RidersTable.aspx">
              <i class="now-ui-icons design_bullet-list-67"></i>
              <p>MOTOGP RIDERS</p>
            </a>
          </li>
        </ul>
      </div>
    </div>
    <div class="main-panel" id="main-panel">
      <div class="panel-header panel-header-sm">
      </div>
      <div class="content">
        <div class="row">
          <div class="col-md-12" >
            <div class="card">
              <div class="card-header">
                <h5 class="title">Create Rider Profile</h5>
              </div>
              <div class="card-body">
                <form runat="server">
                  <div class="row">
                    <div class="col-md-5 pr-1">
                      <div class="form-group">
                        <label>RiderID</label>
                           <asp:TextBox ID="txtIdRider" CssClass="form-control" Enabled="false"  runat="server"></asp:TextBox>
                        <%--<input type="text" class="form-control" disabled="" placeholder="Company" value="Creative Code Inc.">--%>
                      </div>
                    </div>
                    <div class="col-md-3 px-1">
                      <div class="form-group">
                        <label>First Name</label>
                        <asp:TextBox ID="txtFirstName" CssClass="form-control" runat="server"></asp:TextBox>
                        <%--<input type="text" class="form-control" placeholder="Username" value="michael23">--%>
                      </div>
                    </div>
                    <div class="col-md-4 pl-1">
                      <div class="form-group">
                        <label>Last Name</label>
                          <asp:TextBox ID="txtLastName" CssClass="form-control" runat="server"></asp:TextBox>
                        <%--<input type="email" class="form-control" placeholder="Email">--%>
                      </div>
                    </div>
                  </div>
                  <div class="row">
                    <div class="col-md-6 pr-1">
                      <div class="form-group">
                        <label>Nationality</label>
                          <asp:TextBox ID="txtNationality" CssClass="form-control" runat="server"></asp:TextBox>
                        <%--<input type="text" class="form-control" placeholder="Company" value="Mike">--%>
                      </div>
                    </div>
                    <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Weight</label>
                          <asp:TextBox ID="txtWeight" CssClass="form-control" runat="server"></asp:TextBox>
                        <%--<input type="text" class="form-control" placeholder="Last Name" value="Andrew">--%>
                      </div>
                    </div>
                  </div>
                  <div class="row">
                    <div class="col-md-12">
                      <div class="form-group">
                        <label>Height</label>
                          <asp:TextBox ID="txtHeight" CssClass="form-control" runat="server"></asp:TextBox>
                        <%--<input type="text" class="form-control" placeholder="Home Address" value="Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09">--%>
                      </div>
                    </div>
                  </div>
                  <div class="row">
                    <div class="col-md-12">
                      <div class="form-group">
                        <label>Team</label>
                          <%--<asp:DropDownList ID="ddlTeam" CssClass="dropdown" runat="server"></asp:DropDownList>--%>

                        <%--<input type="text" class="form-control" placeholder="Home Address" value="Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09">--%>
                      
                           <ul class="navbar-nav">
                              <li class="nav-item dropdown">
                                <a class="nav-link dropdown-toggle" id="navbarDropdownMenuLink2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                  Team..
                                </a>
                                <div id="dvListaTeamow" class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink2">
                                
                                    <%--  <a class="dropdown-item" href="#">Action</a>
                                  <a class="dropdown-item" href="#">Another action</a>
                                  <a class="dropdown-item" href="#">Something else here</a>--%>
                               
                                    </div>
                              </li>
                            </ul>

                      
                      
                      </div>
                    </div>
                  </div>

                    <asp:Button ID="btnSave" OnClick="btnSave_Click" CssClass="btn btn-primary btn-block" runat="server" Text="Save" />

                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
      <footer class="footer">
        <div class="container-fluid">
          <nav>
            <ul>
              <li>
                <a href="https://www.creative-tim.com">
                  Creative Tim
                </a>
              </li>
              <li>
                <a href="http://presentation.creative-tim.com">
                  About Us
                </a>
              </li>
              <li>
                <a href="http://blog.creative-tim.com">
                  Blog
                </a>
              </li>
            </ul>
          </nav>
          <div class="copyright" id="copyright">
            &copy;
            <script>
              document.getElementById('copyright').appendChild(document.createTextNode(new Date().getFullYear()))
            </script>, Designed by
            <a href="https://www.creative-tim.com" target="_blank">Creative Tim</a>. Coded by
            <a href="#" target="_blank">Krystian Bęben</a>.
          </div>
        </div>
      </footer>
    </div>
  </div>
  <!--   Core JS Files   -->
  <script src="../assets/js/core/jquery.min.js"></script>
  <script src="../assets/js/core/popper.min.js"></script>
  <script src="../assets/js/core/bootstrap.min.js"></script>
  <script src="../assets/js/plugins/perfect-scrollbar.jquery.min.js"></script>
  <!--  Google Maps Plugin    -->
  <script src="https://maps.googleapis.com/maps/api/js?key=YOUR_KEY_HERE"></script>
  <!-- Chart JS -->
  <script src="../assets/js/plugins/chartjs.min.js"></script>
  <!--  Notifications Plugin    -->
  <script src="../assets/js/plugins/bootstrap-notify.js"></script>
  <!-- Control Center for Now Ui Dashboard: parallax effects, scripts for the example pages etc -->
  <script src="../assets/js/now-ui-dashboard.min.js?v=1.3.0" type="text/javascript"></script>
  <!-- Now Ui Dashboard DEMO methods, don't include it in your project! -->
  <script src="../assets/demo/demo.js"></script>
  <script src="../scriptsJS/RiderEdit/RiderEditScript.js"></script>
</body>

</html>