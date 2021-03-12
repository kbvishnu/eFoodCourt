<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="E_FoodCourt.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="book-table">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="heading">
                        <h2>Sign Up </h2>
                    </div>
                </div>
                <div class="col-md-4 col-md-offset-2 col-sm-12">
                    <div class="left-image">
                        <img src="img/book_left_image.jpg" alt="">
                    </div>
                </div>
                <div class="col-md-6 col-sm-12">
                    <div class="right-info" style="height:auto !important">
                        <h4></h4>
                        
                            <div class="row">                                
                                <div class="col-md-6">
                                    <fieldset>
                                        <asp:TextBox name="name" ID="txtEmailAddress" type="email" class="form-control"   placeholder="Email Address" required runat="server" />
                                    </fieldset> 
                                </div>  
                                 <div class="col-md-6">
                                     <fieldset>
                                        <asp:TextBox name="name" ID="txtPassword"  TextMode="Password" type="password" class="form-control"   placeholder="Password" required runat="server" />
                                    </fieldset> 
                                </div>
                               
                                <div class="col-md-6">
                                    <fieldset>
                                        <asp:Button  Text="SignIn" OnClick="btnSignIn_Click"
                                             runat="server" id="btnSignIn"    CssClass="submitASPbutton btn"></asp:Button>
                                        
                                    </fieldset>
                                </div>
                            </div>
                         
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
