<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Hakkımda.aspx.cs" Inherits="CvProject.Hakkımda1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table class="table table-hover" style="margin-left: 20px; margin-right: 20px">
            <tr class="success">
                <th hidden>ID</th>
                <th>BILGILER</th>
                <th>Eğitim</th>
                <th>İş Deneyimleri</th> 
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td hidden><%# Eval("ID") %></td>
                        <td><%# Eval("BILGILER") %></td>
                        <td><%# Eval("EGITIM") %></td>
                        <td><%# Eval("ISDENEYIMLERI") %></td>

                        <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "HakkimdaSil.aspx?ID="+Eval("ID") %>' CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                        
                        <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "HakkimdaGuncelle.aspx?ID="+Eval("ID") %>' CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <a href="Hakkımda.Aspx" class="btn btn-primary" style="margin-left:20px">Hakkimda Ekle</a>

    </div>
</asp:Content>
