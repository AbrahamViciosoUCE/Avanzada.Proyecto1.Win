using Avanzada.Proyecto1.Win.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Validators
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator() { 
            RuleFor(x => x.CategoryName).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}
