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

        public void onPost()
        {

        }

    }
}
