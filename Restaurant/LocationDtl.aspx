<%@ Page Title="" Language="C#" MasterPageFile="~/Restaurant/Restuarnt.Master" AutoEventWireup="true" CodeBehind="LocationDtl.aspx.cs" Inherits="E_FoodCourt.Restaurant.LocationDtl" %>

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
                                <h3>Manage Location</h3>
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
                                                            <label>Address Name</label>
                                                            <asp:TextBox name="name" ID="txtAddressName" type="address name" class="form-control" placeholder="Address Name" required runat="server" />
                                                            <small id="txtAddressHelp" class="form-text text-muted">The address name to identify branch.</small>
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
                                                            <label>Address Line1</label>
                                                            <asp:TextBox name="name" ID="txtAddressLine1" type="address line1" class="form-control" placeholder="Address Line1" required runat="server" />
                                                            <small id="txtAddressLine1Help" class="form-text text-muted">The address name to identify branch.</small>
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
                                                            <label>Address Line2</label>
                                                            <asp:TextBox name="name" ID="txtAddressLine2" type="address line2" class="form-control" placeholder="Address Line2" runat="server" />
                                                            <small id="txtAddressLine2Help" class="form-text text-muted">The address name to identify branch.</small>
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
                                                            <label>Address Line3</label>
                                                            <asp:TextBox name="name" ID="txtAddressLine3" type="address line3" class="form-control" placeholder="Address Line3" runat="server" />
                                                            <small id="txtAddressLine3Help" class="form-text text-muted">The address name to identify branch.</small>
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
                                                            <label>Pincode</label>
                                                            <asp:TextBox name="name" ID="txtPinCode" type="pincode" class="form-control" placeholder="Pincode" required runat="server" />
                                                            <small id="txtPinCodeHelp" class="form-text text-muted">The address name to identify branch.</small>
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
                                                            <label>City</label>
                                                            <asp:TextBox name="name" ID="txtCity" type="city" class="form-control" placeholder="City" required runat="server" />
                                                            <small id="txtCityHelp" class="form-text text-muted">The address name to identify branch.</small>
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
                                                            <label>State</label>
                                                            <asp:DropDownList name="name" ID="ddlState" class="form-control" placeholder="State" required runat="server">
                                                                <asp:ListItem Text="Select State" Value="0">                                            
                                                                </asp:ListItem>
                                                                <asp:ListItem Text="Kerala" Value="Kerala">                                            
                                                                </asp:ListItem>
                                                                <asp:ListItem Text="TamilNadu" Value="TamilNadu">                                            
                                                                </asp:ListItem>
                                                            </asp:DropDownList><small id="tddlStateHelp" class="form-text text-muted">The address name to identify branch.</small>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                    <div class="col-md-12">
                                        <div class="col-md-6">
                                            <div class="col-md-3">
                                                <fieldset>
                                                    <asp:Button Text="Save"
                                                        runat="server" ID="btnSave" CssClass="submitASPbutton btn"></asp:Button>

                                                </fieldset>
                                            </div>
                                            <div class="col-md-3">
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

        </div>

    </section>
</asp:Content>
