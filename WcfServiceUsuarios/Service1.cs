using System;
using System.Collections.Generic;
using DataUsuarios;
namespace WcfServiceUsuarios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        DServiceUsuario serviceUsuario;
        public void ActualizarUsuario(int id, string nombre, DateTime fechaNacimiento, string sexo)
        {
            serviceUsuario = new DServiceUsuario();
            serviceUsuario.ActualizarUsuario(id, nombre, fechaNacimiento, sexo);
        }

        public void AgregarUsuario(string nombre, DateTime fechaNacimiento, string sexo)
        {
            serviceUsuario = new DServiceUsuario();
            serviceUsuario.AgregarUsuario(nombre, fechaNacimiento, sexo);
        }

        public void EliminarUsuario(int id)
        {
            serviceUsuario = new DServiceUsuario();
            serviceUsuario.EliminarUsuario(id);
        }

        public Usuarios GetUsuarioById(int id)
        {
            serviceUsuario = new DServiceUsuario();
            return serviceUsuario.GetUsuarioById(id);
        }

        public List<Usuarios> GetUsuarios()
        {
            serviceUsuario = new DServiceUsuario();
            return serviceUsuario.GetUsuarios();
        }
    }
}
