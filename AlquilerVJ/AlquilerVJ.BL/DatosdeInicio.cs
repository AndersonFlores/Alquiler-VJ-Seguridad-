using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVJ.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "admin";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(nuevoUsuario);

            var nuevoUsuario2 = new Usuario();
            nuevoUsuario2.Nombre = "Anderson";
            nuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(nuevoUsuario2);
         

            var nuevoUsuario3 = new Usuario();
            nuevoUsuario3.Nombre = "Oscar";
            nuevoUsuario3.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(nuevoUsuario3);
        
            var nuevoUsuario4 = new Usuario();
            nuevoUsuario4.Nombre = "Allan";
            nuevoUsuario4.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(nuevoUsuario4);
           

            var nuevoUsuario5 = new Usuario();
            nuevoUsuario5.Nombre = "Lucy";
            nuevoUsuario5.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(nuevoUsuario5);

            base.Seed(contexto);

        }
    }
}
