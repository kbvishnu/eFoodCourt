<%@ Page Title="" Language="C#" MasterPageFile="~/Restaurant/Restuarnt.Master" AutoEventWireup="true" CodeBehind="MenuList.aspx.cs" Inherits="E_FoodCourt.Restaurant.MenuList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="services">

        <div class="container">
            <div class="row">
                <div class="heading">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-12 text-center">
                                <h3>Manage Menu</h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="container">
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="table-responsive">
                                                <asp:datagrid id="grdViewAddress" runat="server" autogeneratecolumns="false" ondatabinding="grdViewAddress_DataBinding"
                                                    onitemdatabound="grdViewAddress_ItemDataBound" cssclass="table table-striped table-bordered" allowpaging="true" allowsorting="true" pagesize="20">
                                            <Columns>
                                                <asp:TemplateColumn>
                                                    <HeaderTemplate>
                                                        Resturant Location Name
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <span id="resLoc" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn>
                                                    <HeaderTemplate>
                                                        Menu Name
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <span id="menuName" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                
                                            </Columns>
                                        </asp:datagrid>

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


    </section>
</asp:Content>
