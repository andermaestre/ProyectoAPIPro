using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using PerroflautasPagina.Models;
using RestSharp;

namespace PerroflautasPagina.Pages
{
    public class IndexModel : PageModel
    {
        public List<Perroflauta> perroflautas { get; set; }
        public void OnGet()
        {
            var client = new RestClient("https://localhost:44322/api/Perroflautas");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");

            IRestResponse response = client.Execute(request);

            perroflautas = JsonConvert.DeserializeObject<List<Perroflauta>>(response.Content);
            perroflautas.ToList();
        }

        public void OnPost(int Id, string Nombre, string OrientacionIdeologica, string Direccion, string Posesiones, string GritoComun, string GritoAparea)
        {
            var client = new RestClient("https://localhost:44322/api/Perroflautas");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");

           

            request.AddParameter("Id", Id);
            request.AddParameter("Nombre", Nombre);
            request.AddParameter("OrientacionIdeologica", OrientacionIdeologica);
            request.AddParameter("Direccion", Direccion);
            request.AddParameter("Posesiones", Posesiones);
            request.AddParameter("GritoComun", GritoComun);
            request.AddParameter("GritoAparea", GritoAparea);
            IRestResponse response = client.Post(request);
            
        }

    }
}
