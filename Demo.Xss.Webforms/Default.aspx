<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Demo.Xss.Webforms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="container-fluid">
        <br />
        @using (@Html.BeginForm("SaveIndexDto", "Home", FormMethod.Post))
    {
        <div class="form-group">
            @Html.LabelFor(Model => Model.Name)
            @Html.TextBoxFor(Model => Model.Name);
        </div>
        <div class="form-group">
            @Html.LabelFor(Model => Model.Description)
            @Html.TextBoxFor(Model => Model.Description);
        </div>
        <div>
            <button type="submit">Post</button>
        </div>
        }
    </div>

</asp:Content>
