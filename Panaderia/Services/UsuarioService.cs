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
    }

}