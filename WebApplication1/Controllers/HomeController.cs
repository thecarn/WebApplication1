using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json.Serialization;
using WebApplication1.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models.Requests;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private List<string> premiumUsers = [
            "ramir"
        ];

        private static IEnumerable<string> pokemonDb = Enumerable.Empty<string>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{text?}")]
        public IActionResult Index(string text)
        {
            text = text ?? "Home";
            ViewData["Title"] = text;
            ViewData["IsPremiumUser"] = premiumUsers.Contains(text) ? "PREMIUM SUB" : "BROKE BOY";
            var pokemon = pokemonDb.FirstOrDefault() ?? "";
            if (pokemon.IsNullOrEmpty())
            {
                return View();
            }
            JObject pokemonObj = JObject.Parse(pokemon);

            ViewData["pokemon"] = pokemonObj["Name"];
            return View();
        }

        [HttpPost]
        [Route("pokemon/create")]
        public IActionResult Index([FromBody] PokemonRequest pokemon)
        {
            var name = pokemon.Name;    // -> get{ ... } is called here
            var pokemonText = JsonConvert.SerializeObject(pokemon);
            pokemonDb = pokemonDb.Append(pokemonText);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            PokemonRequest updatedPR = new PokemonRequest()
            {
                CreatedDate = DateTime.UtcNow,
                Name = "ramir",
            };


            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
