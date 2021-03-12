<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="E_FoodCourt.User.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="services">
        <div class="container">
            <div class="row">
                <div class="text-center">
                    <h3>Search Resturants, Dishes</h3>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label></label>
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="col-md-10">
                                                    <asp:TextBox name="search" ID="txtSearch" type="search" class="form-control" placeholder="Search dish/resturant" required runat="server" />
                                                    <small id="txtAddressLine1hrlp" class="form-text text-muted">Search resturant and dishes here!</small>
                                                </div>
                                                <div class="col-md-2">
                                                <div class="col-md-12">
                                                    <asp:Button ID="btnSearch" runat="server" CssClass="form-control" Text="Search" OnClick="btnSearch_Click"/></div>
                                            </div>
                                            </div>
                                            
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <asp:ListView runat="server" ID="featuredProductList" OnDataBinding="featuredProductList_DataBinding" 
        OnItemDataBound="featuredProductList_ItemDataBound"  >
                        <EmptyDataTemplate>
                            <div class="col-md-4">
                                <div class="food-item">
                                    <h2>
                                        <asp:Label ID="lblCategory" runat="server"></asp:Label></h2>
                                    <img src="../img/close.png" alt="No items found">
                                    <div class="price">
                                        <asp:Label ID="lblPrice" runat="server"></asp:Label>
                                    </div>
                                    <div class="text-content">
                                        <h4>
                                            <asp:Label ID="lblH4Content" runat="server" Text="No Items found"></asp:Label></h4>
                                        <p>
                                            <asp:Label ID="lblDescription" runat="server"></asp:Label>
                                        </p>
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
                                        <asp:Label ID="lblPrice" runat="server"></asp:Label>
                                    </div>
                                    <div class="text-content">
                                        <h4>
                                            <asp:Label ID="lblH4Content" runat="server"></asp:Label></h4>
                                        <p>
                                            <asp:Label ID="lblDescription" runat="server"></asp:Label>
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <%# (Container.DataItemIndex != 0 && (Container.DataItemIndex+1) % 3 == 0) ? @"<div class='col-md-12'>&nbsp;</div>" : string.Empty %>
                        </ItemTemplate>

                    </asp:ListView>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
