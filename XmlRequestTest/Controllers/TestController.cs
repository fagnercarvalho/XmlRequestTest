using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace XmlRequestTest.Controllers
{
    [Produces("application/json")]
    [Route("api/Test")]
    public class TestController : Controller
    {
        [Route("Request")]
        [HttpPost]
        public ActionResult SendDocument([FromBody]CaseManagementOrderStatusToPostToClient document)
        {
            Debug.WriteLine(document.ReviewerComments);

            return Ok();
        }
    }
}