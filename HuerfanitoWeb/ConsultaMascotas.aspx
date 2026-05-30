<%@ Page Title="Consulta de Mascotas" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="ConsultaMascotas.aspx.cs"
    Inherits="HuerfanitoWeb.ConsultaMascotas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Consulta de Mascotas</h2>

    <div class="mb-3">
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"
            placeholder="Buscar por nombre..."></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar"
            CssClass="btn btn-primary mt-2" OnClick="btnBuscar_Click" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </div>

    <asp:GridView ID="gvMascotas" runat="server"
    CssClass="table table-bordered table-striped"
    AutoGenerateColumns="False"
    EmptyDataText="No se encontraron mascotas.">
    <Columns>
        <asp:BoundField DataField="id_mascota"  HeaderText="ID" />
        <asp:BoundField DataField="nombre"      HeaderText="Nombre" />
        <asp:BoundField DataField="id_tipo"     HeaderText="Tipo" />
        <asp:BoundField DataField="raza"        HeaderText="Raza" />
        <asp:BoundField DataField="edad_meses"  HeaderText="Edad (meses)" />
        <asp:BoundField DataField="sexo"        HeaderText="Sexo" />
        <asp:BoundField DataField="estado"      HeaderText="Estado" />
    </Columns>
</asp:GridView>
</asp:Content>