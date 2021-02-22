using CountriesLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesLab.Controllers
{
    public class HomeController : Controller
    {
        
        public List<Country> Countries { get; set; }

        public HomeController()
        {
            Countries = new List<Country>();

            Country usa = new Country { Name = "USA", Lang = "English", Greet = "Hello World!", Description = "Just the worst.", Colors = new string[] { "Red", "White", "Blue" } };
            Country yemen = new Country { Name = "Yemen", Lang = "Arabic", Greet = "Marhabaan Bialealim!", Description = "Civil war since 2014. Yikes.", Colors = new string[] { "Red", "White", "Black" } };
            Country bangladesh = new Country { Name = "Bangladesh", Lang = "Bengali", Greet = "Ōhē biśba!", Description = "8th most popular country in the world!", Colors = new string[] { "Red", "Green", "Gold" } };
            Country czech = new Country { Name = "Czech Republic", Lang = "Czech", Greet = "Ahoj světe!", Description = "Home of the Pilsner beer is the Czech city of Pilsen(Plzeň)!", Colors = new string[] { "White", "Red", "Blue" } };
            Country germany = new Country { Name = "Germany", Lang = "German", Greet = "Hallo Welt!", Description = "Home of the first printed book!", Colors = new string[] { "Black", "Red", "Gold" } };

            Countries.Add(usa);
            Countries.Add(yemen);
            Countries.Add(bangladesh);
            Countries.Add(czech);
            Countries.Add(germany);
        }

        public IActionResult Index()
        {

            return View(Countries);
        }

        [HttpPost]
        public IActionResult Index(string c)
        {

            foreach (Country country in Countries)
            {
                if(c == country.Name)
                {
                    TempData["Name"] = country.Name;
                    TempData["Lang"] = country.Lang;
                    TempData["Greet"] = country.Greet;
                    TempData["Colors0"] = country.Colors[0];
                    TempData["Colors1"] = country.Colors[1];
                    TempData["Colors2"] = country.Colors[2];
                    TempData["Description"] = country.Description;

                    return RedirectToAction("Details", country);
                }
            }
            return View(c);
        }

        public IActionResult Description()
        {
            return View();
        }

        public IActionResult Details(Country c)
        {
            return View(c);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
