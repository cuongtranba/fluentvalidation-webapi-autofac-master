using FluentValidation.Attributes;

namespace Sample.Web.Models
{
    [Validator(typeof(PersonValidator))]
    public class Person
    {
        public string FirstName { get; set; }
        public string OtherNames { get; set; }
        public string LastName { get; set; }
    }
}