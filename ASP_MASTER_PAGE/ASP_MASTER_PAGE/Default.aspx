﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_MASTER_PAGE._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Panel de Comerciales</h2>
            <p>                
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_comercial" DataSourceID="SqlDataSource3">
            <Columns>
                <asp:BoundField DataField="id_comercial" HeaderText="id_comercial" ReadOnly="True" SortExpression="id_comercial" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
                <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
                <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
                <asp:BoundField DataField="comision" HeaderText="comision" SortExpression="comision" />
            </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Simulacro SQL MartesConnectionString3 %>" SelectCommand="SELECT * FROM [comercial]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Simulacro SQL MartesConnectionString %>" SelectCommand="SELECT * FROM [cliente]"></asp:SqlDataSource>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Panel de Clientes</h2>
            <p>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id_cliente" DataSourceID="SqlDataSource2">
                    <Columns>
                        <asp:BoundField DataField="id_cliente" HeaderText="id_cliente" ReadOnly="True" SortExpression="id_cliente" />
                        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                        <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
                        <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
                        <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
                        <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Simulacro SQL MartesConnectionString2 %>" SelectCommand="SELECT * FROM [cliente]"></asp:SqlDataSource>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Panel de Pedidos</h2>
            <p>
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource4">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                        <asp:BoundField DataField="cantidad" HeaderText="cantidad" SortExpression="cantidad" />
                        <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
                        <asp:BoundField DataField="id_cliente" HeaderText="id_cliente" SortExpression="id_cliente" />
                        <asp:BoundField DataField="id_comercial" HeaderText="id_comercial" SortExpression="id_comercial" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:Simulacro SQL MartesConnectionString4 %>" SelectCommand="SELECT * FROM [pedido]"></asp:SqlDataSource>
            </p>
        </div>
    </div>

</asp:Content>
