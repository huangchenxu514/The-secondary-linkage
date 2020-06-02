using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using DateModel;

namespace Text.Controllers
{
    public class StudentController : ApiController
    {
        ClassDAL dal = new ClassDAL();
        public List<Student> Get()
        {
            return dal.Show();
        }
        public int Post([FromBody]Student m)
        {
            return dal.Add(m);
        }
    }
}
