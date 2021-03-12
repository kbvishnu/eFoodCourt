<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="E_FoodCourt.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section class="banner">
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-md-offset-3">
                    <h4>Connecting people with cusines!</h4>
                    <h2>E-Food Court</h2>
                    <p></p>
                    <div class="primary-button">
                        <a href="#" class="scroll-link" data-id="book-table">Order Right Now</a>
                    </div>
                </div>
            </div>
        </div>
    </section>



   



    <section class="services">
        <div class="container">
            <div class="row">
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="service-item">
                        <a href="menu.html">
                        <img src="img/cook_breakfast.png" alt="Breakfast">
                        <h4>Breakfast</h4>
                        </a>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="service-item">
                        <a href="menu.html">
                        <img src="img/cook_lunch.png" alt="Lunch">
                        <h4>Lunch</h4>
                        </a>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="service-item">
                        <a href="menu.html">
                        <img src="img/cook_dinner.png" alt="Dinner">
                        <h4>Dinner</h4>
                        </a>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="service-item">
                        <a href="menu.html">
                        <img src="img/cook_dessert.png" alt="Desserts">
                        <h4>Desserts</h4>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="featured-food">
        <div class="container">
            <div class="row">
                <div class="heading">
                    <h2>Weekly Featured Food </h2>
                    <asp:ListView runat="server" ID="featuredProductList" OnDataBinding="featuredProductList_DataBinding" OnItemDataBound="featuredProductList_ItemDataBound">
                        <EmptyDataTemplate>
                            <div class="col-md-4">
                                <div class="food-item">
                                    <h2>
                                        <asp:Label ID="lblCategory" runat="server"></asp:Label></h2>
                                    <img src="../img/close.png" alt="No items found">
                                    <div class="price">
                                        <asp:Label ID="lblPrice" runat="server"></asp:Label></div>
                                    <div class="text-content">
                                        <h4>
                                            <asp:Label ID="lblH4Content" runat="server" Text="No Items found"></asp:Label></h4>
                                        <p>
                                            <asp:Label ID="lblDescription" runat="server"></asp:Label></p>
                                    </div>
                                </div>
                            </div>
                        </EmptyDataTemplate>
                        <ItemTemplate>
                            <div class="col-md-4">
                                <div class="food-item">
                                    <h2>
                                        <asp:Label ID="lblCategory" runat="server"></asp:Label></h2>
                                  
                                    <asp:Image ID="Img1" runat="server" alt="image" Width="105" ImageUrl="~/img/cook_breakfast.png" />
                                    <div class="price">
                                        <asp:Label ID="lblPrice" runat="server"></asp:Label></div>
                                    <div class="text-content">
                                        <h4>
                                            <asp:Label ID="lblH4Content" runat="server"></asp:Label></h4>
                                        <p>
                                            <asp:Label ID="lblDescription" runat="server"></asp:Label></p>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>

                    </asp:ListView>

                </div>
            </div>
        </div>
    </section>



     


</asp:Content>
