<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="MenuDtl.aspx.cs" Inherits="E_FoodCourt.Restaurant.MenuDtl" %>

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
                                <h3>Manage Menu</h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div style="height: auto !important">
                            <h4></h4>
                            <div class="container">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="col-md-6">
                                            <div class="container">
                                                <div class="row">
                                                    <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label>Resturant Location</label>
                                                            <asp:DropDownList name="name" ID="ddlLocation" class="form-control" placeholder="State" required runat="server">
                                                                <asp:ListItem Text="Select State" Value="0">                                            
                                                                </asp:ListItem>
                                                                <asp:ListItem Text="Kerala" Value="Kerala">                                            
                                                                </asp:ListItem>
                                                                <asp:ListItem Text="TamilNadu" Value="TamilNadu">                                            
                                                                </asp:ListItem>
                                                            </asp:DropDownList>
                                                            <small id="txtAddressHelp" class="form-text text-muted">The location of resturant for menu.</small>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="container">
                                                <div class="row">
                                                    <div class="col-md-6">
                                                        <div class="form-group">
                                                            <label>Menu Name</label>
                                                            <asp:TextBox name="name" ID="txtMenuName" type="" class="form-control" placeholder="Menu Name" required runat="server" />
                                                            <small id="txtAddressLine1Help" class="form-text text-muted">Name of the menu.</small>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        

                                    </div>
                                    <div class="col-md-12">
                                        <div class="col-md-6">
                                            <div class="col-md-2">
                                                <fieldset>
                                                    <asp:Button Text="Save"
                                                        runat="server" ID="btnSave" CssClass="submitASPbutton btn" OnClick="btnSave_Click"></asp:Button>

                                                </fieldset>
                                            </div>
                                             <div class="col-md-2">
                                                <fieldset>
                                                    <asp:Button Text="Delete"
                                                        runat="server" ID="btnDelete" CssClass="submitASPbutton btn" OnClick="btnDelete_Click"></asp:Button>

                                                </fieldset>
                                            </div>
                                            <div class="col-md-2">
                                                <fieldset>
                                                    <asp:Label Text=" "
                                                        runat="server" ID="lblMessage"></asp:Label>

                                                </fieldset>
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
                        &nbsp;
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
                                            OnItemDataBound="grdViewAddress_ItemDataBound" CssClass="table table-striped table-bordered" AllowPaging="true" AllowSorting="true" PageSize="20">
                                            <Columns>
                                                <asp:TemplateColumn>
                                                    <HeaderTemplate>
                                                        Name
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <span id="spanItemName" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn>
                                                    <HeaderTemplate>
                                                        Food Category
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <span id="FoodCategory" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn>
                                                    <HeaderTemplate>
                                                        Cusine
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <span id="Cusine" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                 <asp:TemplateColumn>
                                                    <HeaderTemplate>
                                                        Vegetarian
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:CheckBox id="cbVeg" runat="server" Enabled="false" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn>
                                                    <HeaderTemplate>
                                                        Preparation Time
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <span id="PreparationTime" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>

                                                <asp:TemplateColumn>
                                                    <HeaderTemplate>
                                                        Cost
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <span id="Cost" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>

                                                <asp:TemplateColumn>
                                                    <HeaderTemplate>
                                                        Image
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:Image id="imgItem" runat="server" />
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

