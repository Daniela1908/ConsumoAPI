using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ConsumoAPI.ConsumidorAPI;
using ConsumoAPI.Models;

namespace ConsumoAPI.Controllers
{
    public class PostController : Controller
    {
        /// <summary>
        /// Se llama el metodo Post del ConsumidorApi
        /// </summary>
        /// <returns>Se retornan los datos de la API</returns>

        public async Task<ActionResult> Index()
        {
            if (TempData["id"]==null)
            {
                return RedirectToAction("index", "Home");
            }

            string id = TempData["id"].ToString();
            ConsumidorApi consumidorApi = new ConsumidorApi();
            Post post = await consumidorApi.GetPostAsync(Convert.ToInt32(id));
            return View(post);
        }
    }
}