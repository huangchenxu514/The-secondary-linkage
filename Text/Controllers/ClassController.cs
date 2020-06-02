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
    public class ClassController : ApiController
    {
        ClassDAL dal = new ClassDAL();
        public List<Class> Get(int CollegeId)
        {
            return dal.Class(CollegeId);
        }
    }
}
