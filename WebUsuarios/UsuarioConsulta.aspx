<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="UsuarioConsulta.aspx.cs" Inherits="WebUsuarios.UsuarioConsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js" type="text/javascript"></script>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.3/jquery.validate.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.12/jquery.validate.unobtrusive.min.js"></script>
    <title>Consulta de Usuarios</title>
</head>
<body>
    <nav class="navbar bg-primary navbar-expand-lg bg-body-tertiary">
      <div class="container-fluid">
          <div class="col-9">
            <asp:HyperLink ID="hyperlink3" CssClass="navbar-brand" runat="server" NavigateUrl="Usuario.aspx" Text="Gestor de Usuarios"></asp:HyperLink>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
              <span class="navbar-toggler-icon"></span>
            </button>

          </div>

        <div class="collapse navbar-collapse" id="navbarSupportedContent">
          <ul class="navbar-nav me-auto mb-2 mb-lg-0">
            <li class="nav-item">
              <asp:HyperLink ID="hyperlink1" CssClass="navbar-brand btn btn-warning" runat="server" NavigateUrl="Usuario.aspx" Text="Registro"></asp:HyperLink>
            </li>
            <li class="nav-item">
              <asp:HyperLink ID="hyperlink2" CssClass="navbar-brand btn btn-info" runat="server" NavigateUrl="UsuarioConsulta.aspx" Text="Consulta"></asp:HyperLink>
            </li>
            </ul>
        </div>
      </div>
    </nav>

    <div class="container">
        
        <h1 class="text-success my-4">Consulta de usuarios</h1>
        <div runat="server" id="EmptyAlert" class="alert alert-primary" role="alert">
          
        </div>
        <div class="row">
            <form id="form1" runat="server">
               <asp:GridView ID="GridViewUsuarios" CssClass="table table-bordered table-hover" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de Nacimiento" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
                    <asp:TemplateField HeaderText="Opciones de administrador">
                        <ItemTemplate>
                            <asp:Button ID="Modificar" runat="server" Text="Modificar" CssClass="btn btn-outline-success" OnClick="BtnActualizar_Click" CommandArgument='<%# Eval("Id")%>'/>
                            <asp:Button ID="Eliminar" runat="server" Text="Eliminar" CssClass="btn btn-outline-danger" OnClick="BtnEliminar_Click" CommandArgument='<%# Eval("Id")%>' />
                            
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            </form>
        </div>
    </div>
</body>
</html>
