using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebService;

namespace WebService.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            WebService.cn.com.webxml.www.WeatherWebService ws = new cn.com.webxml.www.WeatherWebService();
            string[] weather_decs = ws.getWeatherbyCityName("北京");
            string weather ="";
            foreach (var dec in weather_decs)
            {
                weather += dec.ToString() + "\r\n";
            }
            //WebService.ServiceReference1.HelloWorldResponse  park = new ServiceReference1.PARKtoXMLService2SoapClient();
            ViewBag.weather = weather;
            return View();
        }
    }
}