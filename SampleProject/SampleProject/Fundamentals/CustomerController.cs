﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Fundamentals
{
    public class CustomerController
    {
        public ActionResult GetCustomerById(int id)
        {
            if (id == 0)
                return new NotFound();

            return new Ok();
        }
    }

    public class ActionResult { }

    public class NotFound : ActionResult { }

    public class Ok : ActionResult { }
}
