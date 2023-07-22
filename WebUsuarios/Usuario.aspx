<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="WebUsuarios.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro de nuevos usuarios</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js" type="text/javascript"></script>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.3/jquery.validate.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.12/jquery.validate.unobtrusive.min.js"></script>
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

    <div class="container mt-4">
        <div class="row">
            <div class="col-10">
                <h1 runat="server" id="TitlePage" class="text-success my-2">Registro de nuevos usuarios</h1>
        <form id="form1" runat="server">
            <div class="mb-4 d-flex">
                <div class="col-8">
                    <label for="nombre" class="form-label">Nombre*</label>
                        <asp:TextBox ID="nombre"  CssClass="form-control" MaxLength="100" runat="server"></asp:TextBox>
                </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorNombre" runat="server"
                            ControlToValidate="nombre"
                            ErrorMessage="El campo Nombre es obligatorio" CssClass="col-4 alert alert-danger mx-2 my-0 p-1 align-self-end">
             </asp:RequiredFieldValidator>
            </div>
            <div class="mb-4">
                <label for="fechaNacimiento" class="form-label">Fecha de nacimiento</label>
                <asp:TextBox TextMode="Date" CssClass="form-control" ID="fechaNacimiento" runat="server"></asp:TextBox>
            </div>

            <div class="mb-4">
                <label for="sexo" class="form-label">Sexo</label>
                <asp:DropDownList ID="sexo" CssClass="form-control px-4 py-2" runat="server">
                    <asp:ListItem Value="M">Masculino</asp:ListItem>
                    <asp:ListItem Value="F">Femenino</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="mb-4">
                <asp:Button ID="AgregarUsuario" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="AgregarUsuario_Click" />
            </div>
        </form>
            </div>
            <div runat="server" id="EmptyAlert" role="alert">
          
            </div>
        </div>
        
    </div>
</body>
</html>
