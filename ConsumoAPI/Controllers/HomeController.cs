using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ConsumoAPI.ConsumidorAPI;
using ConsumoAPI.Models;
using Newtonsoft.Json;

namespace ConsumoAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
            return View();
        }

        /// <summary>
        /// Obtiene el Id ingresado por el ususario y el servicio a consumir seleccionado, 
        /// redirecciona a la vista del servicio seleccionado. 
        /// Se almacena el id en el TempData para utilizarlo en la siguiente peticion
        /// </summary>
        /// <returns>Redirecciona a la vista dle Home</returns>
        [HttpPost]
        public ActionResult Consumir(FormCollection collection)
        {
            
            string id = collection.Get("txtid");
            string opcion = collection.Get("select1");

            TempData["id"] = id;

            switch (opcion)
            {
                case "Obtener Posts":
                    return RedirectToAction("Index", "Post");

                case "Obtener Comments":
                    return RedirectToAction("Index", "Comment");

                case "Obtener Albums":
                    return RedirectToAction("Index", "Album");

                case "Obtener Photos":
                    return RedirectToAction("Index", "Photo");    
            }

            return RedirectToAction("index", "Home");

        }

        
    }
}