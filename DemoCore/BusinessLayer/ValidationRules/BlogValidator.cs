using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Must not be empty!");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Must not be empty!");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Must not be empty!");
            RuleFor(x => x.BlogThumbnailImage).NotEmpty().WithMessage("Must not be empty!");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Please enter less than 130 characters");
            RuleFor(x => x.BlogTitle).MinimumLength(4).WithMessage("Please enter more than 5 characters");
        }
   }
}
