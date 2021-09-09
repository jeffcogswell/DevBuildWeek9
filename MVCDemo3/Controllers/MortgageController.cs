using Microsoft.AspNetCore.Mvc;
using MVCDemo3.Models;
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
			ViewData["Message"] = "";
			return View();
		}

		// Reading data from the URL
		// This action will:
		//     1. Register the uesr by saving the data in a database
		//     2. Present the user with a Thank you page
		[HttpPost]
		public IActionResult Thankyou(Customer cust)
		{
			if (cust.FirstName == null)
			{
				ViewData["Message"] = "Please fill in all fields.";
				return View("SignupForm");
			}
			else
			{
				return View(cust);
			}
		}

		public IActionResult LinkDemo()
		{
			return View();
		}
	}
}
