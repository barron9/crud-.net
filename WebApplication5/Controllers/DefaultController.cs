using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary1;

namespace WebApplication5.Controllers
{
    public class DefaultController : ApiController
    {

  


        [HttpGet]
        public IEnumerable<Table_1> Get(string name) {
            using (testEntities2 entities = new testEntities2())
            {
                Table_1 us = new Table_1()
                { id=0, name=$"{name}"};
                entities.Table_1.Add(us);
               
                    entities.SaveChanges();
 

                return entities.Table_1.ToList();


            }
            
           



        }

    }
}
