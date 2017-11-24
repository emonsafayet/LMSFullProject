using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LbLService;
using LbLModel;



namespace LbLServer.Controllers.student
{
   
   
    public class StudentController : ApiController
    {
        public IHttpActionResult Post(Student student)
        {
            StudentService service = new StudentService();
            var add=service.Add(student);
            return this.Ok(add);

        }
    }

}
