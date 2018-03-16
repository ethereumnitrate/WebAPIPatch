using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_PatchExample.Models.Domain
{
    public class Customer
    {
        public int CustomerID { get; set;  }

        public string FirstName { get; set; }

        public string LastName { get; set;  }

        public string EmailAddress { get; set;  }

        public DateTime CreatedOn { get; set;  }

        public int CreatedBy { get; set;  }
    }
}