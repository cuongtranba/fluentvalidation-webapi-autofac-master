using System.Web.Http;
using Autofac;
using FluentValidation;
using Sample.Web.Models;
using Sample.Web.Resource;

namespace Sample.Web.Controllers
{
    public class PeopleController : ApiController
    {
        private AbstractValidator<Person> AbstractValidator;

        public PeopleController(AbstractValidator<Person> abstractValidator)
        {
            AbstractValidator = abstractValidator;
        }


        public IHttpActionResult CreatePerson(Person person)
        {
            var aa = ErrorMessageResource.MissingUserName;
            var result = AbstractValidator.Validate(person);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }
    }
}