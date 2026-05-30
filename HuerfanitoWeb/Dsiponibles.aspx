<%@ Page Title="Mascotas Disponibles" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Dsiponibles.aspx.cs"
    Inherits="HuerfanitoWeb.Dsiponibles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Mascotas Disponibles</h2>
    <p>Información desde la vista <code>vw_MascotasDisponibles</code></p>

    <asp:GridView ID="gvDisponibles" runat="server"
        CssClass="table table-bordered table-success"
        AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="id_mascota"  HeaderText="ID" />
            <asp:BoundField DataField="nombre"      HeaderText="Nombre" />
            <asp:BoundField DataField="tipo"        HeaderText="Tipo" />
            <asp:BoundField DataField="raza"        HeaderText="Raza" />
            <asp:BoundField DataField="edad_meses"  HeaderText="Edad (meses)" />
            <asp:BoundField DataField="sexo"        HeaderText="Sexo" />
            <asp:BoundField DataField="estado"      HeaderText="Estado" />
        </Columns>
    </asp:GridView>
</asp:Content>