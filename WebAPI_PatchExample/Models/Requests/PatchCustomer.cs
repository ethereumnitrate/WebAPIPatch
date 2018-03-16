using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI_PatchExample.Common;
using PatchExampleDataLayer;
namespace WebAPI_PatchExample.Models.Requests
{
    public class PatchCustomer : AbstractPatchStateRequest<PatchCustomer, Customer>
    {

        public PatchCustomer()
        {
            AddPatchStateMapping(x => x.FirstName);
            AddPatchStateMapping(x => x.LastName);
            AddPatchStateMapping(x => x.EmailAddress);
        }
        public int CustomerID { get; set;  }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }
    }
}