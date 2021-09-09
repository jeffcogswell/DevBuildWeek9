using Microsoft.AspNetCore.Mvc;
using MVCDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo1.Controllers
{
	public class MortgageController : Controller
	{
		public IActionResult Index()
		{
			return Content("This is my index page");
		}

		public IActionResult Welcome()
		{
			return Content("Welcome to my mortgage system");
		}

		// This is a route "Mortgage/AnotherPage"
		public IActionResult AnotherPage()
		{
			ViewData["Name"] = "Fred";
			ViewData["Course"] = "DevBuild";
			ViewData["Amount"] = 100 + 200;
			ViewData["Interest"] = 0.25m;

			List<string> People = new List<string>();
			People.Add("Sally");
			People.Add("Julie");
			People.Add("Dylan");
			ViewData["ThePeople"] = People;

			return View();
		}

		// Provide a form to the user to fill out
		public IActionResult SignupForm()
		{
			return View();
		}

		// Reading data from the URL
		// This action will:
		//     1. Register the uesr by saving the data in a database
		//     2. Present the user with a Thank you page
		[HttpPost]
		public IActionResult Thankyou(Customer cust)
		{
			/*ViewData["FirstName"] = cust.FirstName;
			ViewData["LastName"] = cust.LastName;
			ViewData["Password"] = cust.Password;*/

			/*ViewBag.FirstName = cust.FirstName;
			ViewBag.LastName = cust.LastName;
			ViewBag.Password = cust.Password;*/

			ViewData["Customer"] = cust;

			//return Content($"Thank you {firstname} {lastname} {mypassword}");
			return View();
		}

		public IActionResult LinkDemo()
		{
			return View();
		}
	}
}
