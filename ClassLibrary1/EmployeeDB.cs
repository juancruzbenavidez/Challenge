using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public static class EmployeeDB
    {
        public static List<Employee> GetEmployees()
        {
            WebRequest request = HttpWebRequest.Create("http://masglobaltestapi.azurewebsites.net/api/Employees");
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string info = reader.ReadToEnd();
            List<Employee> myEmployees = JsonConvert.DeserializeObject<List<Employee>>(info);

            return myEmployees;
        }
    }
}
