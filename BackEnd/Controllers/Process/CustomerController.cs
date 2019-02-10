using Pro.domain.Pro.Domain;
using Pro.Repo.Pro.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BackEnd.Controllers.Process
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("Customer")]
    public class CustomerController : ApiController
    {

        CustomerRepo repo;
        public CustomerController()
        {

            repo = new CustomerRepo();


        }



        [HttpGet]
        [Route("Get")]
        public HttpResponseMessage GetALLdata() {
            try {



                var d = repo.get();

                return Request.CreateResponse(HttpStatusCode.OK, d);

            }



            catch (Exception e
            ) {


                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);

            }





        }


    }
}
