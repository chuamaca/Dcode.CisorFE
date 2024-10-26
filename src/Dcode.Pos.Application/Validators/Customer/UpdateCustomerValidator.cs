﻿using Dcode.Pos.Application.DataBase.Customer.Commands.UpdateCustomer;
using FluentValidation;

namespace Dcode.Pos.Application.Validators.Customer
{
    public class UpdateCustomerValidator : AbstractValidator<UpdateCustomerModel>
    {
        public UpdateCustomerValidator()
        {
            RuleFor(x => x.CustomerId).NotNull().GreaterThan(0);
            RuleFor(x => x.FullName).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x => x.DocumentNumber).NotNull().NotEmpty().Length(8);
        }
    }
}
