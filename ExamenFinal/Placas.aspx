<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Placas.aspx.cs" Inherits="ExamenFinal.Placas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    ESTAMOS EN EL MENU PLACAS, Ingrese una placa para lograr ver el registro.</p>
<p>
    &nbsp;</p>
<asp:GridView ID="GridView1" runat="server" BackColor="Aqua">
</asp:GridView>
<p>
    &nbsp;</p>
<p>
    NUMERO DE PLACA A INGRESAR:<asp:TextBox ID="Tnumplaca" runat="server"></asp:TextBox>
</p>
<p>
    ID DEL CLIENTE:<asp:TextBox ID="Tid" runat="server"></asp:TextBox>
</p>
<p>
    MONTO:<asp:TextBox ID="Tmonto" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Agregar" />
</p>
<p>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Borrar" />
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Modificar" />
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
