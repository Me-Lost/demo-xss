<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Demo.Xss.Webforms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="container-fluid">
        <br />

        <div class="form-group">
            <asp:TextBox runat="server" ID="TbName">

            </asp:TextBox>
            <asp:Label ID="lblName" runat="server">

            </asp:Label>
        </div>
        <div class="form-group">
            <asp:TextBox runat="server" ID="TbDesc">

            </asp:TextBox>
            <asp:Label ID="LbDesc" runat="server">

            </asp:Label>
        </div>

        <div>
            <asp:Button id="BtnUpdate" onserverclick="BtnUpdate_Click" runat="server" Text="Update">

            </asp:Button>
        </div>

    </div>

</asp:Content>
