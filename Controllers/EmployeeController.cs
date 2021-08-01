using SimpleProject_server_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleProject_server_api.Controllers
{
    public class EmployeeController : ApiController
    {
        Konnection kon;
        public HttpResponseMessage Get()
        {
            kon = new Konnection();
            string qury = @"select * from Employee";
            kon.forRetrive(qury);
            return Request.CreateResponse(HttpStatusCode.OK, kon.dataTable);
        }

        public string Post(Employee emp)
        {
            try
            {
                string qury = @"insert into Employee values('"+emp.Name+ @"','" + emp.Email + @"','" + emp.Phone + @"','" + emp.Address + @"')";
                kon = new Konnection();
                kon.forRetrive(qury);
                return "Added Successfully!";
            }
            catch(Exception)
            {
                return "Failed to Add!!";
            }
        }

        public string Put(Employee emp)
        {
            try
            {
                string qury = @"update Employee set Name='" + emp.Name + @"', Email='" + emp.Email + @"', Phone='" + emp.Phone + @"', Address='" + emp.Address + @"' where Id='"+emp.Id+@"'";
                kon = new Konnection();
                kon.forRetrive(qury);
                return "Update Successfully!";
            }
            catch (Exception)
            {
                return "Failed to Update!!";
            }
        }

        public string Delete(int id)
        {
            try
            {
                string qury = @"delete from Employee where Id='" + id + @"'";
                kon = new Konnection();
                kon.forRetrive(qury);
                return "Delete Successfully!";
            }
            catch (Exception)
            {
                return "Failed to Delete!!";
            }
        }
    }
}
