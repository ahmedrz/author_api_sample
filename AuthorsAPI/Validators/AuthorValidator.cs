using FluentValidation;
using ProductAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorsAPI.Validators
{
    public class AuthorValidator : AbstractValidator<Author>


    {
        public AuthorValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotNull().NotEmpty().Length(1, 100);
            RuleFor(x => x.Country).NotNull().NotEmpty().Length(1, 25);
            RuleFor(x => x.BOD).NotNull().NotEqual(DateTime.MinValue);
        }
    }
}
