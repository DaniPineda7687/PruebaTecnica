using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUsuarios
{
    public partial class UsuarioConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceUsuariosCRUD.Service1Client service1Client = new ServiceUsuariosCRUD.Service1Client();
            
            ServiceUsuariosCRUD.Usuarios[] usuarios = service1Client.GetUsuarios();
            if (usuarios.Length > 0)
            {
                GridViewUsuarios.DataSource = usuarios;
                GridViewUsuarios.DataBind();
                EmptyAlert.Attributes["class"] = "";
            }
            else
            {
                EmptyAlert.Attributes["class"] += "alert alert-primary";
                EmptyAlert.Attributes["role"] += "alert";
                EmptyAlert.InnerText = "No hay usuarios registrados";
            }

        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idEmpleado = int.Parse(btn.CommandArgument.ToString());
            Response.Redirect($"Usuario.aspx?id={idEmpleado}");

        }
        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idEmpleado = int.Parse(btn.CommandArgument.ToString());
            ServiceUsuariosCRUD.Service1Client service = new ServiceUsuariosCRUD.Service1Client();
            service.EliminarUsuario(idEmpleado);
            Response.Redirect("UsuarioConsulta.aspx");
        }

    }
}