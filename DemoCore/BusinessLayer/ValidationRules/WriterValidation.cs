using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidation:AbstractValidator<Writer>
	{
        public WriterValidation()
        {
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Name No empty!");
            RuleFor(x => x.WriterEmail).NotEmpty().WithMessage("Email No empty");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password No empty");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Enter at least 3 letters");
            RuleFor(x => x.WriterName).MaximumLength(20).WithMessage("Enter up to 20 letters");
        }
    }
}
