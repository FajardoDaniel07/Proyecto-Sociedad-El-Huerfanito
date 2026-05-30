<%@ Page Title="Mascotas por Tipo" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="MaestroDetal.aspx.cs"
    Inherits="HuerfanitoWeb.MaestroDetal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Mascotas por Tipo (Maestro - Detalle)</h2>

    <div class="row">
        <div class="col-md-3">
            <h5>Tipos de Mascota</h5>
            <asp:ListBox ID="lbTipos" runat="server" CssClass="form-control"
                Rows="8" AutoPostBack="True"
                OnSelectedIndexChanged="lbTipos_SelectedIndexChanged">
            </asp:ListBox>
        </div>

        <div class="col-md-9">
            <h5>Mascotas</h5>
            <asp:GridView ID="gvDetalle" runat="server"
                CssClass="table table-bordered table-hover"
                AutoGenerateColumns="False"
                EmptyDataText="Seleccione un tipo para ver las mascotas.">
                <Columns>
                    <asp:BoundField DataField="id_mascota"  HeaderText="ID" />
                    <asp:BoundField DataField="nombre"      HeaderText="Nombre" />
                    <asp:BoundField DataField="raza"        HeaderText="Raza" />
                    <asp:BoundField DataField="edad_meses"  HeaderText="Edad (meses)" />
                    <asp:BoundField DataField="sexo"        HeaderText="Sexo" />
                    <asp:BoundField DataField="estado"      HeaderText="Estado" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>