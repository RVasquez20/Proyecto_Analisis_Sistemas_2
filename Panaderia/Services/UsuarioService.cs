using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Panaderia.App_Data;
using Panaderia.Models;

namespace Panaderia.Services
{
    public class UsuarioService : IUsuariosDataService
    {
        public async Task<Usuario> Agregar_Usuario(UsuariosViewModel model)
        {
            using (dbPanaderia dataBase = new dbPanaderia())
            {
                var usuario = new Usuario();
                usuario.nombre = model.nombre;
                usuario.apellido = model.apellido;
                usuario.direccion = model.direccion;
                usuario.email = model.email;
                usuario.users = model.users;
                usuario.pass = model.pass;
                usuario.id_rol = model.id_rol;
                dataBase.Usuario.Add(usuario);
                dataBase.SaveChanges();
                return usuario;
            }
        }

        public UsuariosViewModel Buscar(int id_usuario)
        {
            var model = new UsuariosViewModel();
            using (dbPanaderia dataBase = new dbPanaderia())
            {
                var result = dataBase.Usuario.Find(id_usuario);
                model.id_usuario = result.id_usuario;
                model.nombre = result.nombre;
                model.apellido = result.apellido;
                model.direccion = result.direccion;
                model.email = result.email;
                model.users = result.users;
                model.pass = result.pass;
                model.id_rol = result.id_rol;
                return model;
            }
        }

        public async Task<Usuario> Eliminar_Usuario(int id_usuario)
        {
            using (dbPanaderia dataBase = new dbPanaderia())
            {
                var result = dataBase.Usuario.Find(id_usuario);
                dataBase.Usuario.Remove(result);
                dataBase.SaveChanges();
                return result;
            }

        }

        public async Task<List<UsuariosViewModel>> Listar_Usuarios()
        {
            using (dbPanaderia dataBase=new dbPanaderia())
            {
                var result = (from u in dataBase.Usuario 
                              join r in dataBase.Roles on u.id_rol equals r.id_rol
                              select new UsuariosViewModel
                              {
                                  id_usuario=u.id_usuario,
                                  nombre=u.nombre,
                                  apellido=u.apellido,
                                  direccion=u.direccion,
                                  email=u.email,
                                  users=u.users,
                                  pass=u.pass,
                                  id_rol=r.id_rol,
                                  rol=r.rol
                              }).ToList();
                return result;
            }
            
        }

        public async Task<Usuario> Modificar_Usuario(UsuariosViewModel model)
        {
            using (dbPanaderia dataBase = new dbPanaderia())
            {
                var result = dataBase.Usuario.Find(model.id_usuario);
                result.nombre = model.nombre;
                result.apellido = model.apellido;
                result.direccion = model.direccion;
                result.email = model.email;
                result.users = model.users;
                result.pass = model.pass;
                result.id_rol = model.id_rol;
                dataBase.Entry(result).State = System.Data.Entity.EntityState.Modified;
                dataBase.SaveChanges();
                return result;
            }
        }
    }

}