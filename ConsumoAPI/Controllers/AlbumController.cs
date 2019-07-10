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
    public class AlbumController : Controller
    {
        /// <summary>
        /// Se llama el metodo Album del consumidorApi
        /// </summary>
        /// <returns>Se retornan los datos de la API</returns>
        // GET: Album
        public async Task<ActionResult> Index()
        {
            if (TempData["id"]==null)
            {
                return RedirectToAction("index","Home");
            }

            string id = TempData["id"].ToString();
            ConsumidorApi consumidorApi = new ConsumidorApi();
            Album album = await consumidorApi.GetAlbumAsync(Convert.ToInt32(id));
            return View(album);
        }
    }
}