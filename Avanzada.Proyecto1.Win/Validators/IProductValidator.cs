using Avanzada.Proyecto1.Win.Models;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Validators
{
    public class IProductValidator: AbstractValidator<Product>
    {
        public IProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty();
            RuleFor(x => x.SupplierID).NotEmpty();
            RuleFor(x => x.CategoryID).NotEmpty();
            RuleFor(x => x.UnitPrice).NotEmpty();
            RuleFor(x => x.QuantityPerUnit).NotEmpty();
            RuleFor(x => x.UnitsOnOrder).NotEmpty();
            RuleFor(x => x.ReorderLevel).NotEmpty();
        }
    }
}
