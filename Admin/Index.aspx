<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Index.aspx.vb" Inherits="Project_WebClassroom.Index1" %>

<!--
=========================================================
* Argon Dashboard - v1.2.0
=========================================================
* Product Page: https://www.creative-tim.com/product/argon-dashboard


* Copyright  Creative Tim (http://www.creative-tim.com)
* Coded by www.creative-tim.com



=========================================================
* The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
-->
<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="Start your development with a Dashboard for Bootstrap 4.">
    <meta name="author" content="Creative Tim">
    <title>Argon Dashboard - Free Dashboard for Bootstrap 4</title>
    <!-- Favicon -->
    <link rel="icon" href="assets/img/brand/favicon.png" type="image/png">
    <!-- Fonts -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700">
    <!-- Icons -->
    <link rel="stylesheet" href="assets/vendor/nucleo/css/nucleo.css" type="text/css">
    <link rel="stylesheet" href="assets/vendor/@fortawesome/fontawesome-free/css/all.min.css" type="text/css">
    <!-- Page plugins -->
    <!-- Argon CSS -->
    <link rel="stylesheet" href="assets/css/argon.css?v=1.2.0" type="text/css">
    <link href="../User/assets/css/style.css" rel="stylesheet">
</head>

<body>
    <form runat="server" id="form2">
        <!-- Sidenav -->
        <nav class="sidenav navbar navbar-vertical  fixed-left  navbar-expand-xs navbar-light bg-white" id="sidenav-main">
            <div class="scrollbar-inner">
                <!-- Brand -->
                <div class="sidenav-header  align-items-center">
                    <a class="navbar-brand" href="javascript:void(0)">
                        <img src="assets/img/brand/blue.png" class="navbar-brand-img" alt="...">
                    </a>
                </div>
                <div class="navbar-inner">
                    <!-- Collapse -->
                    <div class="collapse navbar-collapse" id="sidenav-collapse-main">
                        <!-- Nav items -->
                        <ul class="navbar-nav">
                            <li class="nav-item">
                                <a class="nav-link active" href="Index.aspx">
                                    <i class="ni ni-tv-2 text-primary"></i>
                                    <span class="nav-link-text">Dashboard</span>
                                </a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="../User/Logout.aspx">
                                    <i class="ni ni-planet text-orange"></i>
                                    <span class="nav-link-text">Logout</span>
                                </a>
                            </li>
        </nav>
        <!-- Main content -->
        <div class="main-content" id="panel">
            <!-- Header -->
            <!-- Header -->
            <div class="header bg-primary pb-6 mb--5">
                <div class="container-fluid">
                    <div class="header-body">
                        <div class="row align-items-center py-4">
                            <div class="col-lg-6 col-7">
                                <h6 class="h2 text-white d-inline-block mb-0">Default</h6>
                                <nav aria-label="breadcrumb" class="d-none d-md-inline-block ml-md-4">
                                    <ol class="breadcrumb breadcrumb-links breadcrumb-dark">
                                        <li class="breadcrumb-item"><a href="#"><i class="fas fa-home"></i></a></li>
                                        <li class="breadcrumb-item"><a href="#">Dashboards</a></li>
                                        <li class="breadcrumb-item active" aria-current="page">Default</li>
                                    </ol>
                                </nav>
                            </div>
                            <div class="col-lg-6 col-5 text-right">
                                <a href="#" class="btn btn-sm btn-neutral">New</a>
                                <a href="#" class="btn btn-sm btn-neutral">Filters</a>
                            </div>
                        </div>
                        <!-- Card stats -->
                    </div>
                </div>
            </div>
            <!-- Page content -->
            <div class="container-fluid mt--10">
                <div class="row">
                    <div class="col-xl-10" style="right: auto; margin: 70px;">
                        <div class="card">
                            <div class="card-header border-0">
                                <div class="row align-items-center">
                                    <div class="col">
                                        <h3 class="mb-0">Daftar Kelas</h3>
                                    </div>
                                    <div class="col text-right">
                                        <a data-toggle="modal" data-target="#modalSubscriptionForm" class="btn btn-sm btn-primary">Tambah Kelas</a>
                                    </div>
                                </div>
                            </div>
                            <!-- Projects table -->
                            <section id="team" class="team section-bg">
                                <div class="container">

                                    <div class="row">
                                        <%For Each datakelas In Listkelas %>
                                        <div class="col-lg-3 col-md-6 d-flex align-items-stretch">
                                            <div class="member">
                                                <div class="member-img">
                                                    <img src="../User/<%=datakelas.foto%>" class="img-fluid" alt="" />
                                                </div>
                                                <div class="member-info">
                                                    <h6 style="font-size: 13px"><a href="detailKelas.aspx?id_dosen=<%=datakelas.idDosen %>&id_makul=<%=datakelas.id_makul %>"><%=datakelas.nama %></a></h6>
                                                    <span><%=datakelas.namaMakul %></span><br />
                                                    <span><a href="hapusKelas.aspx?id_makul=<%=datakelas.id_makul %>&id_dosen=<%=datakelas.idDosen %>" class="btn btn-danger btn-sm">Hapus Kelas</a></span><br />
                                                    <span><a href="tambahTugas?id_makul=<%=datakelas.id_makul %>&id_dosen=<%=datakelas.idDosen %>" class="btn btn-success btn-sm">Tambah Tugas</a></span>
                                                </div>
                                            </div>
                                        </div>
                                        <%Next %>
                                    </div>

                                </div>
                            </section>
                        </div>
                    </div>
                    <!-- Footer -->
                </div>

                <!-- modal tambah buku -->

                <div class="modal fade" id="modalSubscriptionForm" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"
                    aria-hidden="true">
                    <div class="modal-dialog" role="document">
                        <div class="modal-content">
                            <div class="modal-header text-center">
                                <h4 class="modal-title w-100 font-weight-bold">Tambah Data Buku Baru</h4>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body mx-3">                                
                                <div class="md-form mb-2">
                                    <label data-error="wrong" data-success="right" for="form2">Dosen</label>
                                    <asp:DropDownList ID="dosen" CssClass="form-control" runat="server" DataSourceID="SqlDataSource1" DataTextField="nama" DataValueField="id_dosen">
                                    </asp:DropDownList>
                                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:DB_ClassroomConnectionString %>' SelectCommand="SELECT * FROM [Dosen] WHERE ([id_makul] IS NULL)"></asp:SqlDataSource>
                                </div>
                                <div class="md-form mb-2">
                                    <label data-error="wrong" data-success="right" for="form2">Mata Kuliah</label>
                                    <asp:DropDownList ID="makul" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="nama" DataValueField="id_makul">
                                    </asp:DropDownList>
                                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:DB_ClassroomConnectionString %>' SelectCommand="SELECT * FROM [Makul]"></asp:SqlDataSource>
                                </div>
                            </div>
                            <div class="modal-footer d-flex justify-content-center">
                                <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Text="Tambah Kelas" OnClick="btnAdd_Click" />
                            </div>
                        </div>
                    </div>
                </div>

                <!-- end of modal tambah buku -->
               
            </div>
            <!-- Argon Scripts -->
            <!-- Core -->
            <script src="assets/vendor/jquery/dist/jquery.min.js"></script>
            <script src="assets/vendor/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
            <script src="assets/vendor/js-cookie/js.cookie.js"></script>
            <script src="assets/vendor/jquery.scrollbar/jquery.scrollbar.min.js"></script>
            <script src="assets/vendor/jquery-scroll-lock/dist/jquery-scrollLock.min.js"></script>
            <!-- Optional JS -->
            <script src="assets/vendor/chart.js/dist/Chart.min.js"></script>
            <script src="assets/vendor/chart.js/dist/Chart.extension.js"></script>
            <!-- Argon JS -->
            <script src="assets/js/argon.js?v=1.2.0"></script>
    </form>
</body>

</html>

