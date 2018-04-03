﻿using FluentValidation;
using Onboarding.Models;

namespace Onboarding.Validations
{
    public class GuarantorValidator : AbstractValidator<Guarantor>
    {
        public GuarantorValidator()
        {
            RuleFor(guarantor => guarantor.Cpf).NotEmpty();
            RuleFor(guarantor => guarantor.Name).NotEmpty();
            RuleFor(guarantor => guarantor.StreetAddress).NotEmpty();
            RuleFor(guarantor => guarantor.ComplementAddress).NotEmpty();
            RuleFor(guarantor => guarantor.Neighborhood).NotEmpty();
            RuleFor(guarantor => guarantor.PhoneNumber).NotEmpty();
            RuleFor(guarantor => guarantor.Landline).NotEmpty();
            RuleFor(guarantor => guarantor.Email).NotEmpty();
            RuleFor(guarantor => guarantor.CityId).NotEmpty();
            RuleFor(guarantor => guarantor.StateId).NotEmpty();
            RuleFor(guarantor => guarantor.FinanceDataId).NotEmpty();
        }
    }
}
