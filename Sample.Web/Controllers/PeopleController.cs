using System.Web.Http;
using Autofac;
using FluentValidation;
using Sample.Web.Models;
using Sample.Web.Resource;

namespace Sample.Web.Controllers
{
    public class PeopleController : ApiController
    {
        public IHttpActionResult CreatePerson(Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }
    }
}