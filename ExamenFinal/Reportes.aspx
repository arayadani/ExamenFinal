<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="ExamenFinal.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    ESTAMOS EN LA PAGINA REPORTES, Ingrese el numero de placa a consultar para lograr ver el registro con su marchamo incluido.</p>
<p>
    <img alt="" src="images/descarga%20(3).jfif" style="width: 311px; height: 162px" /></p>
<p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</p>
<p>
    INGRESE EL NUMERO DE PLACA:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ver Reportes" />
</p>
</asp:Content>
