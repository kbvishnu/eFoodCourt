<%@ Page Title="" Language="C#" MasterPageFile="~/Restaurant/Restuarnt.Master" AutoEventWireup="true" CodeBehind="TableReservations.aspx.cs" Inherits="E_FoodCourt.Restaurant.TableReservations" %>
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
                                <h3>Manage Tables</h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
             
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="container">
                                        <div class="row">
                                            <div class="col-md-12">
                                                 <div class="table-responsive">
                                        <asp:DataGrid ID="grdViewAddress" runat="server" AutoGenerateColumns="false" OnDataBinding="grdViewAddress_DataBinding"
                                            OnItemDataBound="grdViewAddress_ItemDataBound" CssClass="table table-striped table-bordered" AllowPaging="true" AllowSorting="true" PageSize="20"
                                            OnCancelCommand="grdViewAddress_CancelCommand"
                                            OnDeleteCommand="grdViewAddress_DeleteCommand"
                                            OnEditCommand="grdViewAddress_EditCommand"
                                            >
                                            <Columns>
                                                <asp:TemplateColumn>
                                                    <HeaderTemplate>
                                                        Table Code
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <span id="TableCode" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn>
                                                    <HeaderTemplate>
                                                       Seats
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <span id="Seats" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>                                                
                                                 <asp:TemplateColumn>
                                                    <HeaderTemplate>
                                                        Ready to use
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:CheckBox id="cbReadyToUse" runat="server" Enabled="false" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>                                                
                                            </Columns>
                                        </asp:DataGrid>

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

    </section>
</asp:Content>
     