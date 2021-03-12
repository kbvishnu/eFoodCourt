<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="E_FoodCourt.User.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="banner" style="display: none">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <h4></h4>
                    <h2></h2>
                    <p></p>
                    <div class="primary-button">
                        <a href="#" class="scroll-link" data-id="book-table"></a>
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
                        <a href="menu.aspx?filter=breakfast">
                            <img src="../img/cook_breakfast.png" alt="Breakfast">
                            <h4>Breakfast</h4>
                        </a>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="service-item">
                        <a href="menu.html?filter=lunch">
                            <img src="../img/cook_lunch.png" alt="Lunch">
                            <h4>Lunch</h4>
                        </a>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="service-item">
                        <a href="menu.html?filter=dinner">
                            <img src="../img/cook_dinner.png" alt="Dinner">
                            <h4>Dinner</h4>
                        </a>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="service-item">
                        <a href="menu.html?filter=desserts">
                            <img src="../img/cook_dessert.png" alt="Desserts">
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

            <div class="row">
                <asp:DataGrid ID="grdDataGrid" runat="server" AutoGenerateColumns="false"
                    GridLines="None" ShowFooter="false" ShowHeader="false" Visible="false">
                    <Columns>
                        <asp:TemplateColumn>
                            <HeaderTemplate></HeaderTemplate>
                            <ItemTemplate>
                                <div class="col-md-4">
                                    <div class="food-item">
                                        <h2>
                                            <asp:Label ID="Category" runat="server"></asp:Label></h2>
                                        <img src="../img/breakfast_item.jpg" alt="">
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
                            <FooterTemplate></FooterTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                    <%--     <Columns>
                        <asp:TemplateColumn>
                            <HeaderTemplate></HeaderTemplate>
                            <ItemTemplate>
                                <div class="col-md-4">
                                    <div class="food-item">
                                        <h2>Lunch</h2>
                                        <img src="../img/lunch_item.jpg" alt="">
                                        <div class="price">$7.50</div>
                                        <div class="text-content">
                                            <h4>Taiyaki Gastro Tousled</h4>
                                            <p>Dreamcatcher squid ennui cliche chicharros nes echo  small batch jean shorts hexagon street art knausgaard wolf...</p>
                                        </div>
                                    </div>
                                </div>

                            </ItemTemplate>
                            <FooterTemplate></FooterTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                    <Columns>
                        <asp:TemplateColumn>
                            <HeaderTemplate></HeaderTemplate>
                            <ItemTemplate>
                                <div class="col-md-4">
                                    <div class="food-item">
                                        <h2>Dinner</h2>
                                        <img src="../img/dinner_item.jpg" alt="">
                                        <div class="price">$12.50</div>
                                        <div class="text-content">
                                            <h4>Batch Squid Jean Shorts</h4>
                                            <p>Dreamcatcher squid ennui cliche chicharros nes echo  small batch jean shorts hexagon street art knausgaard wolf...</p>
                                        </div>
                                    </div>
                                </div>

                            </ItemTemplate>
                            <FooterTemplate></FooterTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                    <Columns>
                        <asp:TemplateColumn>
                            <HeaderTemplate></HeaderTemplate>
                            <ItemTemplate>
                                <div class="col-md-4">
                                    <div class="food-item">
                                        <h2>Dinner</h2>
                                        <img src="../img/dinner_item.jpg" alt="">
                                        <div class="price">$12.50</div>
                                        <div class="text-content">
                                            <h4>Batch Squid Jean Shorts</h4>
                                            <p>Dreamcatcher squid ennui cliche chicharros nes echo  small batch jean shorts hexagon street art knausgaard wolf...</p>
                                        </div>
                                    </div>
                                </div>

                            </ItemTemplate>
                            <FooterTemplate></FooterTemplate>
                        </asp:TemplateColumn>
                    </Columns>--%>
                </asp:DataGrid>


            </div>
        </div>
    </section>
</asp:Content>
