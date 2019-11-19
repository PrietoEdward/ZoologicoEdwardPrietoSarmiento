using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Zoologico.application.Models;

namespace Zoologico.application.Controllers
{
    public class ZooController : Controller
    {
        // GET: Zoo
        public async Task<ActionResult> Index()
        {
            List<AnimalModels> model = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56287/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/Animal");
                if (response.IsSuccessStatusCode)
                {
                    model = await response.Content.ReadAsAsync<List<AnimalModels>>();
                }
            }
            return View(model);
        }

        // GET: Zoo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zoo/Create
        [HttpPost]
        public async Task<ActionResult> Create(AnimalModels Objeto)
        {
            try
            {              
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:56287/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/Animal", Objeto);
                    response.EnsureSuccessStatusCode();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Zoo/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            AnimalModels model = new AnimalModels();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56287/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var json = await client.GetStringAsync($"api/Animal/{id}");
                //convierto los valores de un json en un modelo
                model = JsonConvert.DeserializeObject<AnimalModels>(json);

            }
            return View(model);
        }

        // POST: Zoo/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, AnimalModels Objeto)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:56287/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.PutAsJsonAsync($"api/Animal/{id}", Objeto);
                    response.EnsureSuccessStatusCode();
                    // Deserialize the updated product from the response body.
                    //model = await response.Content.ReadAsAsync<AnimalModels>();                    
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Zoo/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            AnimalModels model = new AnimalModels();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56287/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var json = await client.GetStringAsync($"api/Animal/{id}");
                //convierto los valores de un json en un modelo
                model =  JsonConvert.DeserializeObject<AnimalModels>(json);                
            }
            return View(model);
        }

        // POST: Zoo/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, AnimalModels Objeto)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:56287/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.DeleteAsync($"api/Animal/{id}");
                    response.EnsureSuccessStatusCode();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
