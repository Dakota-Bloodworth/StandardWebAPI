using StandardWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StandardWebAPI.Models;

namespace StandardWebAPI.Controllers
{
    public class CarDetailsController : ApiController
    {
        public IEnumerable<CarStock>GetAllCarDetails()
        {
            CarStock ST = new CarStock();
            CarStock ST1 = new CarStock();
            List<CarStock> carlist = new List<CarStock>();

            ST.CarName = "Ford";
            ST.CarPrice ="Thirty thousnd";
            ST.CarModel ="Bronco";
            ST.CarColor ="Shit Brown";

            ST1.CarName = "Dodge";
            ST1.CarPrice = "Fifty thousnd";
            ST1.CarModel = "Ram";
            ST1.CarColor = "Rotyal Bluse";

            carlist.Add(ST);
            carlist.Add(ST1);
            return carlist;
        }
        // GET api/<controller>
        public IEnumerable<CarStock> Get(int id)
        {
            CarStock ST = new CarStock();
            CarStock ST1 = new CarStock();
            List<CarStock> carlist = new List<CarStock>();
            if (id == 1)
            {
                ST.CarName = "Ford";
                ST.CarPrice = "Thirty thousnd";
                ST.CarModel = "Bronco";
                ST.CarColor = "Shit Brown";
                carlist.Add(ST);
            }
            else
            {
                ST1.CarName = "Dodge";
                ST1.CarPrice = "Fifty thousnd";
                ST1.CarModel = "Ram";
                ST1.CarColor = "Rotyal Bluse";


                carlist.Add(ST1);
            }
                return carlist;
            
        }
        // POST api/<controller>
        public void PostCar([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut]
        public void Putcar(int id, [FromBody] CarStock cs)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public void Deletecar(int id)
        {
        }
    }
}