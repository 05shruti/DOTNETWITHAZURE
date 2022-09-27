using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApI_2.models;

namespace WebApI_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerDbContext db = new CustomerDbContext();
        [HttpGet]
        public IEnumerable<TblCustomer> get()
        {
            return db.TblCustomers;
        }
        [HttpPost]
        public IActionResult post(TblCustomer customer)
        {
            db.TblCustomers.Add(customer);
            db.SaveChanges();
            return Ok(new { ststus = "your record is added suceessfully" });
        }
    }

}
