using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;

namespace WebApplication1
{
    public class EmployeesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<EmployeeDTO> Get()
        {
            return EmployeeHelper.GetAllEmployees();
        }

        // GET api/<controller>/5
        public IEnumerable<EmployeeDTO> Get(int id)
        {
            return EmployeeHelper.GetAllEmployees().Where(x=>x.id==id);
        }
    }
}