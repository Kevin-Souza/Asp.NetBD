<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="editar.aspx.cs" Inherits="asp.NetBD.editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center text-primary">
        <h2>Editar Dados Clientes</h2>
    </div>
    <div class="row" style="margin-top:15px">
        <div class="col-md-2">
            <label>ID:</label>
            <asp:TextBox ID="txtID" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <div class="col-md-10">
            <label>Nome:</label>
            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="margin-top:15px">
        <div class="col-md-7">
            <label>Logradouro:</label>
            <asp:TextBox ID="txtLogradouro" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <label>Número:</label>
            <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <label>Complemento:</label>
            <asp:TextBox ID="txtComplemento" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="margin-top:15px">
        <div class="col-md-5">
            <label>Bairro:</label>
            <asp:TextBox ID="txtBairro" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-5">
            <label>Cidade:</label>
            <asp:TextBox ID="txtCidade" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <label>UF:</label>
            <asp:TextBox ID="txtUF" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="row" style="margin-top:15px">
        <div class="text-right col-md-12">
            <asp:Button ID="btnVoltar" CssClass="btn btn-dark" runat="server" text="Voltar" OnClick="btnVoltar_Click" />            
            <asp:Button ID="btnAlterar" CssClass="btn btn-warning" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
        </div>
    </div>
    <div class="row" style="margin-top:15px">
        <div class="text-right col-md-12">
            <asp:Label ID="lblResultado" CssClass="text-warning" runat="server"/>
        </div>
    </div>
</asp:Content>
