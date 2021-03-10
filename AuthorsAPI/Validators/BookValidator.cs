using FluentValidation;
using ProductAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorsAPI.Validators
{
    public class BookValidator : AbstractValidator<Book>
    {

        public BookValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotNull().NotEmpty().Length(1, 100);
            RuleFor(x => x.AuthorId).NotNull().NotEqual(0);
            RuleFor(x => x.IssueDate).NotNull().NotEqual(DateTime.MinValue);
            RuleFor(x => x.Description).NotNull().NotEmpty().Length(1, 200);

        }
    }
}
