<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdresGüncelle.aspx.cs" Inherits="CvProject.AdresGüncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h4>Yeni Adres Güncelleme Sayfası</h4>
<br />
<%--<asp:Label ID="Label1" runat="server" Text="Yetenek Açıklama"></asp:Label>--%>
    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Telefon Yazın"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Mail Yazın"></asp:TextBox>
    <br />
<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Adresi Yazın"></asp:TextBox>
<br />
<asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-info" OnClick="Button1_Click"/>
</asp:Content>
