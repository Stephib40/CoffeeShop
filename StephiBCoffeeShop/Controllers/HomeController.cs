using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab20.Models;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace StephiBCoffeeShop.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index(Register r)
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Fellow Coffee Enthusiast?";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "You can find us @ Start Garden Cafe";

			return View();
		}

		public ActionResult Register()
		{
			ViewBag.Message = "Do You Love Coffee Like We Love Coffee?";
			//ViewBag.Email = "email" + r.Email;

			return View();
		}

		public ActionResult ValidateForm()
		{
			return View();
		}

		public ActionResult Success(Register r)
		{

			ViewBag.Message = "Welcome " + r.FirstName;
			ViewBag.Email = "Email: " + r.Email;
			ViewBag.Name = r.FirstName;
			ViewBag.Phone = r.Phone;
			return View(r);
		}

		public ActionResult InitMap()
		{
			//HttpWebRequest request = WebRequest.CreateHttp("https://maps.googleapis.com/maps/api/staticmap?center=Start+Garden/@42.9661576,-85.6721016,17z/data=!3m1!4b1!4m5!3m4!1s0x8819adc447a3b737:0x7a6a91c9a38e58fc!8m2!3d42.9661537!4d-85.6699129&size=400x400&key=AIzaSyAZbLkVG_dIO-2Ula1hf9PRE2Z9AOXummA");
			//request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";
			//HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			//StreamReader rd = new StreamReader(response.GetResponseStream());
			//string data = rd.ReadToEnd();
			
			//JObject o = JObject.Parse(data);
			
			//ViewBag.JsonData = 0[];
			return InitMap();
		}
	}
}