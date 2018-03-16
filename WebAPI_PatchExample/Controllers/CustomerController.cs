using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_PatchExample.Models.Requests;
using PatchExampleDataLayer;
namespace WebAPI_PatchExample.Controllers
{
    public class CustomerController : ApiController
    {
        [Route("customer/{CustomerID}")]
        [HttpPatch]
        public IHttpActionResult PatchCustomer(PatchCustomer customer)
        {
            try
            {
               
                using (var context = new PatchExampleDataLayer.patchEntities())
                {
                    PatchExampleDataLayer.Customer cus = context.Customers.Where(c => c.CustomerID == customer.CustomerID).FirstOrDefault();
                    customer.Patch(cus);
                    context.Entry(cus).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                return Content(HttpStatusCode.OK, "OK");
                    //customer.Patch(PatchExampleDataLayer.Customer);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, "Something Bad Happened");
            }
        }
        [Route("customer/{CustomerID}")]
        [HttpPost]
        public IHttpActionResult PostCustomer(PostCustomer customer)
        {
            try
            {
                if (customer.FirstName != null)
                {
                    //update
                }
                
                if (customer.LastName != null)
                {

                }

                return Content(HttpStatusCode.OK, "OK");
                //customer.Patch(PatchExampleDataLayer.Customer);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, "Something Bad Happened");
            }
        }
    }
}
