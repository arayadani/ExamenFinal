<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ExamenFinal.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    BIENVENIDO A USUARIOS, Ingrese un usuario para lograr ver el registro.</p>
<p>
    <img alt="" src="images/descarga.png" style="width: 366px; height: 138px" /></p>
<p>
    <asp:GridView ID="GridView1" runat="server" BackColor="#FF33CC">
    </asp:GridView>
</p>
<p>
    NOMBRE DE USUARIO:<asp:TextBox ID="TcorreoUsu" runat="server" ></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    CLAVE:<asp:TextBox ID="Tclave" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    NOMBRE:<asp:TextBox ID="Tnombre" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    APELLIDO:<asp:TextBox ID="Tapellido" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Borrar" />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Modificar" />
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
