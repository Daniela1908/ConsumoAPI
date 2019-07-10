using ConsumoAPI.ConsumidorAPI;
using ConsumoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ConsumoAPI.Controllers
{
    public class PhotoController : Controller
    {
        /// <summary>
        /// Se llama el metodo Photo del ConsumidorApi
        /// </summary>
        /// <returns>Se retornan los datos de la API</returns>

        public async Task<ActionResult> Index()
        {
            if (TempData["id"]==null)
            {
                return RedirectToAction("Index", "Home");
            }
            string id = TempData["id"].ToString();
            ConsumidorApi consumidorApi = new ConsumidorApi();
            Photo photo = await consumidorApi.GetPhotoAsync(Convert.ToInt32(id));
            return View(photo);
        }
    }
}