using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OCGDS.RoleOperation.Controllers
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials = true)]
    public class RoleOperationController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetVersion()
        {
            return Ok("Role Operations");
        }
    }
}
