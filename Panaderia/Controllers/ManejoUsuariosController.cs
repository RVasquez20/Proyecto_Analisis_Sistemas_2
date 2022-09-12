using Panaderia.App_Data;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Panaderia.Services;

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
    }
}