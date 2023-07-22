using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUsuarios
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmptyAlert.Attributes["class"] = "";
            EmptyAlert.Attributes["role"] = "";
            EmptyAlert.InnerText = "";
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    ServiceUsuariosCRUD.Service1Client service = new ServiceUsuariosCRUD.Service1Client();
                    ServiceUsuariosCRUD.Usuarios user = service.GetUsuarioById(int.Parse(Request.QueryString["id"]));
                    TitlePage.InnerText = "Actualizar usuario";
                    AgregarUsuario.Text = "Actualizar";
                    
                    nombre.Text = user.Nombre;
                    fechaNacimiento.Text = user.FechaNacimiento.Value.ToString("yyyy-MM-dd");
                    
                    sexo.SelectedValue = user.Sexo;
                }
            }
        }

        protected void AgregarUsuario_Click(object sender, EventArgs e)
        {

            RequiredFieldValidatorNombre.Attributes["class"] += "alert alert-danger";
            if (Page.IsValid)
            {
                string fechaNacimientoText = fechaNacimiento.Text;
                DateTime fechaNacimientoFormat;
                if(DateTime.TryParse(fechaNacimientoText, out fechaNacimientoFormat))
                {

                    EmptyAlert.Attributes["class"] += "alert alert-success";
                    EmptyAlert.Attributes["role"] += "alert";
                    ServiceUsuariosCRUD.Service1Client service = new ServiceUsuariosCRUD.Service1Client();
                    if (Request.QueryString["id"] == null)
                    {
                        service.AgregarUsuario(nombre.Text, fechaNacimientoFormat, sexo.Text);
                        EmptyAlert.InnerText = "Usuario registrado con exito";
                    }
                    else
                    {
                        service.ActualizarUsuario(int.Parse(Request.QueryString["id"]), nombre.Text, fechaNacimientoFormat, sexo.Text);
                        EmptyAlert.InnerText = $"Usuario {nombre.Text} actualizado con exito";
                    }

                }
            }
        }
    }
}