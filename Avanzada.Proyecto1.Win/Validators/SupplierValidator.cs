using Avanzada.Proyecto1.Win.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Validators
{
    public class SupplierValidator: AbstractValidator<Supplier>
    {
        public SupplierValidator() {
            RuleFor(x => x.CompanyName).NotEmpty();
            RuleFor(x => x.ContactName).NotEmpty();
            RuleFor(x => x.ContactTitle).NotEmpty();
            RuleFor(x => x.Address).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.Region).NotEmpty();
            RuleFor(x => x.PostalCode).NotEmpty();
            RuleFor(x => x.Country).NotEmpty();
            RuleFor(x => x.Phone).NotEmpty();
            RuleFor(x => x.Fax).NotEmpty();
            RuleFor(x => x.HomePage).NotEmpty();
        }
    }
}
