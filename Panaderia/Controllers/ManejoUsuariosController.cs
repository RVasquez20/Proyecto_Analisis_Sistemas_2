using Panaderia.App_Data;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Panaderia.Services;
using Panaderia.Models;

namespace Panaderia.Controllers
{
    public class ManejoUsuariosController : Controller
    {
        private readonly IUsuariosDataService usuarioService;

        public ManejoUsuariosController()
        {
            usuarioService = new UsuarioService();
        }
        public async Task<ActionResult> Index(){
            try
            {
                var result = await usuarioService.Listar_Usuarios();
                return View(result);
            }catch(Exception e)
            {
                return View("Error");
            }
        }
        public  ActionResult AgregarUsuario()
        {
            var listadoRoles = usuarioService.Listar_Roles();
            ViewBag.roles = listadoRoles;
            return View();
            
        }
        [HttpPost]
        public async Task<ActionResult> AgregarUsuario(UsuariosViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await usuarioService.Agregar_Usuario(model);
                return Redirect(Url.Content("~/ManejoUsuarios/"));
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }
        [HttpGet]
        [Route("editar/(id)")]
        public ActionResult ModificarUsuario(int id)
        {
            try
            {
                var result =  usuarioService.Buscar(id);
                var listadoRoles = usuarioService.Listar_RolesEdit(result.id_rol);
                ViewBag.roles = listadoRoles;
                return View(result);
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }
    

        [HttpPost]
        public async Task<ActionResult> Editar(UsuariosViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await usuarioService.Modificar_Usuario(model);
                return Redirect(Url.Content("~/ManejoUsuarios/"));
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }
        [HttpGet]
        [Route("eliminar/(id)")]
        public async Task<ActionResult> EliminarUsuario(int id)
        {
            try
            {
                var result = await usuarioService.Eliminar_Usuario(id);
                return Redirect(Url.Content("~/ManejoUsuarios/"));
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

    }
}