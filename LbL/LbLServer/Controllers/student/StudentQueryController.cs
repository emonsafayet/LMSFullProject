using LbLModel;
using LbLRequestModel;
using LbLService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LbLServer.Controllers.student
{
    public class StudentQueryController : ApiController
    {
        //get request always takes premitive type
        public IHttpActionResult Post(StudentRequestModel request)
        {
            //searching machanism.
            StudentService service = new StudentService();
            List<Student> students= service.Search(request);
            return this.Ok(students);
        }
    }
}
