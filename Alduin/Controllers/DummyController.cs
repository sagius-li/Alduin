using OCG.ResourceManagement.DSModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Alduin.Controllers
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials = true)]
    public class DummyController : ApiController
    {
        //[Import(typeof(IOCGDSRepository))]
        //private IOCGDSRepository repo;

        [ImportMany("LithnetMIM", typeof(IOCGDSRepository))]
        IEnumerable<Lazy<IOCGDSRepository, Dictionary<string, object>>> repos { get; set; }

        [HttpGet]
        //[Route("api/dummy/getversion")]
        public IHttpActionResult GetVersion(string text = "Dummy")
        {
            //string dummyType = repo.GetType();

            string dummyType = string.Empty;
            if (repos != null && repos.Count() > 0)
            {
                dummyType = repos.First().Value.GetType();
            }
            else
            {
                dummyType = "No Assambly detected";
            }

            return Ok($"Using Repository: {dummyType} from {text} Controller");
        }
    }
}
