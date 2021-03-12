<%@ Page Title="" Language="C#" MasterPageFile="~/Restaurant/Restuarnt.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="E_FoodCourt.Restaurant.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--     <section class="featured-food">--%>
    <div class="container">
        <div class="row">
            <div class="heading">
                <h2>Manage Address</h2>
            </div>
        </div>
        <div class="container">
            <div class="row">

                <div class="col-md-6 col-md-12">
                    <div class="right-content info" style="height: auto !important">
                        <h4></h4>
                        <div class="container">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="col-md-6">
                                        <div class="col-md-3">
                                            Resturant Name
                                                  
                                        </div>
                                        <div class="col-md-3">
                                            <fieldset>
                                                <asp:TextBox name="name" ID="txtResturantName" type="address name" class="form-control" placeholder="Resturant Name" required runat="server" />
                                            </fieldset>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <fieldset>
                                            <asp:FileUpload ID="txtFileUploadLogo" runat="server" class="form-control" placeholder="Upload logo" EnableTheming="true" />
                                        </fieldset>
                                    </div>
                                    <div class="col-md-6">
                                        <fieldset>
                                            <asp:TextBox name="name" ID="txtURL" type="address line2" class="form-control" placeholder="URL" runat="server" />
                                        </fieldset>
                                    </div>
                                    <div class="col-md-6">
                                        <fieldset>
                                            <asp:TextBox name="name" TextMode="Date" ID="txtRegistrationDate" type="address line3" class="form-control" placeholder="Registration Date" runat="server" />
                                        </fieldset>
                                    </div>

                                </div>
                                <div class="col-md-12">
                                    <div class="col-md-6">
                                        <div class="col-md-3">
                                            <fieldset>
                                                <asp:Button Text="Save" OnClick="btnSave_Click"
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

    <%--  </section>--%>
</asp:Content>
