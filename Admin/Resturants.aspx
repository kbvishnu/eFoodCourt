<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Resturants.aspx.cs" Inherits="E_FoodCourt.Admin.Resturants" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="featured-food">
        <div class="container">
            <div class="row">
                <div class="heading">
                    <h2>Resturants</h2>
                </div>
            </div>
            <div class="row">
                <div class="table-responsive">  
                <asp:DataGrid ID="gridViewListResturants" runat="server" AutoGenerateColumns="false" OnDataBinding="gridViewListResturants_DataBinding"
                    OnItemDataBound="gridViewListResturants_ItemDataBound" CssClass="table table-striped table-bordered" AllowPaging="true" AllowSorting="true" PageSize="3"  >
                    <Columns>
                        <asp:TemplateColumn>
                            <HeaderTemplate>
                                Id
                            </HeaderTemplate>
                            <HeaderStyle CssClass="Grid td" />
                            <ItemTemplate>
                                <asp:Label ID="lblId" runat="server" Text="" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn>
                            <HeaderTemplate>
                                Name
                            </HeaderTemplate>
                            <ItemTemplate>
                                <span id="spnRes" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn>
                            <HeaderTemplate>
                                Active
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="cbActive" runat="server" Text="" Enabled="false" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn>
                            <HeaderTemplate>
                                Contact Number
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblContact" runat="server" Text="" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
                    </div>
            </div>
        </div>
        
    </section>


</asp:Content>
