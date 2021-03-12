<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="E_FoodCourt.User.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="services">
        <div class="container">
            <div class="row">                 
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="service-item">
                        <a href="Address.aspx?filter=breakfast">
                            <img src="../img/addr.svg" alt="Breakfast">
                            <h4>Address</h4>
                        </a>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="service-item">
                        <a href="ordersearch.html?filter=lunch">
                            <img src="../img/orderHis.png" alt="Lunch">
                            <h4>Order History</h4>
                        </a>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="service-item">
                        <a href="bookinghistory.html?filter=dinner">
                            <img src="../img/bookHis.png" alt="Dinner">
                            <h4>Booking History</h4>
                        </a>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="service-item">
                        <a href="transactions.html?filter=desserts">
                            <img src="../img/transHis.jpg" alt="Desserts">
                            <h4>Transaction History</h4>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
