using BusinessLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EmployeesUI.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index(string idEmployee)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://localhost:58053/Api/Employees/"+idEmployee);
            List<EmployeeDTO> employeesList = JsonConvert.DeserializeObject<List<EmployeeDTO>>(json);
            return View(employeesList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}