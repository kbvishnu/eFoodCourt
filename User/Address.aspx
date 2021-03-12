<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="Address.aspx.cs" Inherits="E_FoodCourt.User.Address" %>

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
                                <h3>Manage Address</h3>
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
                                        Name
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <span id="spanAddName" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn>
                                    <HeaderTemplate>
                                        AddressLine
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <span id="spnAddLines" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn>
                                    <HeaderTemplate>
                                        Pin Code
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <span id="spnPinCode" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn>
                                    <HeaderTemplate>
                                        City
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <span id="spnCity" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>

                                <asp:TemplateColumn>
                                    <HeaderTemplate>
                                        State
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <span id="spnState" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>

                                <asp:TemplateColumn>
                                    <HeaderTemplate>
                                        Contact Number
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
