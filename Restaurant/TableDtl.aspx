<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="TableDtl.aspx.cs" Inherits="E_FoodCourt.Restaurant.TableDtl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">3
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
                                                            <small id="txtAddressHelp" class="form-text text-muted">The location of resturant for tables.</small>
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
                                                            <label>Table Code</label>
                                                            <asp:TextBox name="name" ID="txtTableCode" type="" class="form-control" placeholder="Menu Name" required runat="server" />
                                                            <small id="txtTableCodeHelp" class="form-text text-muted">Table Code.</small>
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
                                                            <label>Seats</label>
                                                            <asp:TextBox name="name" ID="txtNoofSeats" type="" class="form-control" placeholder="Menu Name" required runat="server" />
                                                            <small id="txtNoofSeatsHelp" class="form-text text-muted">Number of seats.</small>
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
                                                            <label>Ready to use</label>
                                                            <asp:CheckBox name="name" ID="cbReadyToUse" type="" class="form-control" placeholder="Ready to use" required runat="server" />
                                                            <small id="rdYHelp" class="form-text text-muted">Indicates table is ready to list</small>
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
                                                        runat="server" ID="btnSave" CssClass="submitASPbutton btn" OnClick="btnSave_Click" ></asp:Button>

                                                </fieldset>
                                            </div>
                                             <div class="col-md-2">
                                                <fieldset>
                                                    <asp:Button Text="Delete"
                                                        runat="server" ID="btnDelete" CssClass="submitASPbutton btn" OnClick="btnDelete_Click" ></asp:Button>

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
</asp:Content>
