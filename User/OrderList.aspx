<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="E_FoodCourt.User.OrderList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <section class="services">
        <div class="container">
            <div class="row">
                <div class="heading">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-12 text-center">
                                <h3>Your Orders</h3>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-md-12"><div class="table-responsive table-hover">
                        <asp:DataGrid ID="grdViewAddress" runat="server" AutoGenerateColumns="false" OnDataBinding="grdViewAddress_DataBinding"
                            OnItemDataBound="grdViewAddress_ItemDataBound" CssClass="table table-striped table-bordered" AllowPaging="true" AllowSorting="true" PageSize="3">
                            <Columns>
                                <asp:TemplateColumn>
                                    <HeaderTemplate>
                                        Order Id
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <span id="spanAddName" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn>
                                    <HeaderTemplate>
                                        Date
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <span id="spnAddLines" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn>
                                    <HeaderTemplate>
                                        Status
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <span id="spnPinCode" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn>
                                    <HeaderTemplate>
                                        Type
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <span id="spnCity" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>

                                <asp:TemplateColumn>
                                    <HeaderTemplate>
                                        Amount
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <span id="spnState" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>

                                <asp:TemplateColumn>
                                    <HeaderTemplate>
                                        Review
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <span id="spnContactNumber" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div></div>
                    
                </div>
            </div>
        </div>

    </section>


</asp:Content>
