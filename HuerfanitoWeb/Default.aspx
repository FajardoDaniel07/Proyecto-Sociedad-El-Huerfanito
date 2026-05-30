<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="HuerfanitoWeb._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="hero">
        <div class="emoji">🐶🐱🐰</div>
        <h1>Sociedad El Huerfanito</h1>
        <p>Somos una organización dedicada a conectar mascotas sin hogar con familias amorosas. 
           Cada animal merece un hogar seguro, cariño y una segunda oportunidad.</p>
    </div>

    <div class="row text-center mt-4">
        <div class="col-md-4 mb-3">
            <div class="card shadow-sm h-100">
                <div class="card-body">
                    <h2>🔍</h2>
                    <h5 class="card-title">Consulta Mascotas</h5>
                    <p class="card-text">Busca mascotas por nombre y consulta su información detallada.</p>
                    <a runat="server" href="~/ConsultaMascotas" class="btn btn-dark">Ver mascotas</a>
                </div>
            </div>
        </div>
        <div class="col-md-4 mb-3">
            <div class="card shadow-sm h-100">
                <div class="card-body">
                    <h2>📋</h2>
                    <h5 class="card-title">Por Tipo</h5>
                    <p class="card-text">Explora las mascotas organizadas por tipo: perros, gatos, conejos y más.</p>
                    <a runat="server" href="~/MaestroDetal" class="btn btn-dark">Ver por tipo</a>
                </div>
            </div>
        </div>
        <div class="col-md-4 mb-3">
            <div class="card shadow-sm h-100">
                <div class="card-body">
                    <h2>✅</h2>
                    <h5 class="card-title">Disponibles</h5>
                    <p class="card-text">Consulta las mascotas disponibles para adopción en este momento.</p>
                    <a runat="server" href="~/Dsiponibles" class="btn btn-success">Ver disponibles</a>
                </div>
            </div>
        </div>
    </div>

</asp:Content>