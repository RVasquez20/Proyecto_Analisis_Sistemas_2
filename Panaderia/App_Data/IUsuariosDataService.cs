using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaderia.Models;

namespace Panaderia.App_Data
{
    public interface IUsuariosDataService
    {
        Task<List<UsuariosViewModel>>Listar_Usuarios();
    }
}
