using Domain;
using Entidad.ClienteEntidad.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLogin.Controllers
{
    public class ClienteController : Controller
    {
        #region [Properties]
        private readonly ClienteDomain oClienteDomain = null;
        #endregion

        #region [Constructor]
        /// <summary>
        /// Constructor
        /// </summary>
        public ClienteController()
        {
            oClienteDomain = new ClienteDomain();
        }
        #endregion

        #region [ActionResult]
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region [Methods]
        [HttpGet]
        public ActionResult GetClienteById(int id)
        {
            var response = oClienteDomain.GetClienteById(id);
            return Json(response);
        }

        [HttpGet]
        public ActionResult GetClientes()
        {
            var response = oClienteDomain.GetClientes();
            return Json(response);
        }

        [HttpPost]
        public ActionResult AddCliente(AddClienteRequest request)
        {
            var response = oClienteDomain.AddCliente(request);
            return Json(response);
        }

        [HttpPut]
        public ActionResult UpdateCliente(UpdateClienteRequest request)
        {
            var response = oClienteDomain.UpdateCliente(request);
            return Json(response);
        }

        [HttpDelete]
        public ActionResult DeleteCliente(int id)
        {
            var response = oClienteDomain.DeleteCliente(id);
            return Json(response);
        }

        #endregion
    }
}