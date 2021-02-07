<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="detailKelas.aspx.vb" Inherits="Project_WebClassroom.detailKelas" %>

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

    <link href="../User/assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="../User/assets/vendor/icofont/icofont.min.css" rel="stylesheet">
    <link href="../User/assets/vendor/boxicons/css/boxicons.min.css" rel="stylesheet">
    <link href="../User/assets/vendor/remixicon/remixicon.css" rel="stylesheet">
    <link href="../User/assets/vendor/venobox/venobox.css" rel="stylesheet">
    <link href="../User/assets/vendor/owl.carousel/assets/owl.carousel.min.css" rel="stylesheet">
    <link href="../User/assets/css/style.css" rel="stylesheet">
</head>

<body>
    <form runat="server" id="form1">
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
                                <a class="nav-link active" href="examples/dashboard.html">
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
            <section id="team" class="team section-bg">
                <div class="container">

                    <div class="section-title">
                        </br><br />
                        <h2><%=detailKelas.nama %></h2>
                        <h3><%=detailKelas.namaMakul %></h3>
                    </div>

                    <div class="row">

                        <div class="col-lg-3 col-md-6 d-flex align-items-stretch">
                            <div class="member">
                                <div class="member-img">
                                    <img src="../User/<%=detailKelas.foto%>" class="img-fluid" alt="" />
                                </div>
                                <div class="member-info">
                                    <h6 style="font-size: 13px"><%=detailKelas.nama %></h6>
                                    <span><%=detailKelas.namaMakul %></span>
                                </div>
                            </div>
                        </div>
                        <div class="card w-75 d-flex align-items-stretch shadow p-3 mb-5 bg-white rounded">
                            <div class="card-body">
                                <h5 class="card-title">Detail Kelas</h5>
                                <div class="member">
                                    <div class="card-body">
                                        <h5 class="card-title" style="font-size: 10px;">Detail Dosen</h5>
                                        <p class="card-text" style="font-size: 10px;">Nama : <%=detailKelas.nama %></p>
                                        <p class="card-text" style="font-size: 10px;">HP : <%=detailKelas.hp %></p>
                                        <p class="card-text" style="font-size: 10px;">Email : <%=detailKelas.email %></p>
                                    </div>
                                </div>
                                <div class="member mt-4">
                                    <div class="card-body">
                                        <h5 class="card-title" style="font-size: 10px;">Detail Kelas</h5>
                                        <p class="card-text" style="font-size: 10px;">Mata Kuliah : <%=detailKelas.namaMakul %></p>
                                        <p class="card-text" style="font-size: 10px;">SKS : <%=detailKelas.sks %></p>
                                        <p class="card-text" style="font-size: 10px;">Jam : <%=detailKelas.jam %></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <section id="features" class="features mt-4 m-1 ">
                            <div class="card w-100 d-flex align-items-stretch shadow p-3 mb-5 bg-white rounded">
                                <div class="card-body">
                                    <h5 class="card-title">List Tugas</h5>
                                    <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>

                                    <span><a href="tambahTugas?id_makul=<%=detailKelas.id_makul %>&id_dosen=<%=detailKelas.idDosen %>" class="btn btn-success btn-sm">Tambah Tugas</a></span>
                                    <div class="row" data-aos="fade-up" data-aos-delay="300">
                                        <%For Each tugas In ListTugas %>
                                        <div class="col-md-8 mt-4">
                                            <div class="icon-box">
                                                <i class="ri-calendar-todo-line" style="color: #5578ff;"></i>
                                                <h3><a href="detailTugas.aspx?id_tugas=<%=tugas.id_tugas%>&id_dosen=<%=tugas.id_dosen%>&id_mhs=<%=Session("id") %>&id_makul=<%=tugas.id_makul %>"><%=tugas.judul + "<br><br>tengat : <br><br>" + tugas.tengat %></a></h3>
                                            </div>
                                        </div>
                                        <%next %>
                                    </div>
                                </div>

                            </div>
                        </section>
                    </div>
                </div>
            </section>
            <!-- End Team Section -->
            <!-- Footer -->

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


