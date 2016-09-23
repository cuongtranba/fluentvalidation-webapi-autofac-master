using FluentValidation;
using Sample.Web.Resource;

namespace Sample.Web.Models
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage(ErrorMessageResource.MissingUserName);
            RuleFor(x => x.LastName).NotEmpty();
        }
    }
}