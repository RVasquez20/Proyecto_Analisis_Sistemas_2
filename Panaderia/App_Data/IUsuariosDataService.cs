using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Panaderia.Models;

namespace Panaderia.App_Data
{
    public interface IUsuariosDataService
    {
        Task<List<UsuariosViewModel>>Listar_Usuarios();
        List<SelectListItem> Listar_Roles();
        List<SelectListItem> Listar_RolesEdit(int id_rol);
        Task<Usuario> Agregar_Usuario(UsuariosViewModel model);
        Task<Usuario> Modificar_Usuario(UsuariosViewModel model);
        UsuariosViewModel Buscar(int id_usuario);
        Task<Usuario> Eliminar_Usuario(int id_usuario);
    }
}
