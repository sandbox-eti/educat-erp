﻿using FluentValidation;
using Onboarding.Models;

namespace Onboarding.Validations
{
    public class RepresentativeValidator : AbstractValidator<Representative>
    {
        public RepresentativeValidator()
        {
            RuleFor(representative => representative.Name).NotEmpty();
            RuleFor(representative => representative.StreetAddress).NotEmpty();
            RuleFor(representative => representative.ComplementAddress).NotEmpty();
            RuleFor(representative => representative.Neighborhood).NotEmpty();
            RuleFor(representative => representative.PhoneNumber).NotEmpty();
            RuleFor(representative => representative.Landline).NotEmpty();
            RuleFor(representative => representative.Email).NotEmpty().EmailAddress();
            RuleFor(representative => representative.CityId).NotEmpty();
            RuleFor(representative => representative.StateId).NotEmpty();
            RuleFor(representative => representative).Custom((representative, context) =>
            {
                if (representative is RepresentativePerson)
                {
                    if (string.IsNullOrEmpty(((RepresentativePerson)representative).Relationship))
                    {
                        context.AddFailure("relationship", "'Relacionamento' deve ser informado.");
                    }
                    if (string.IsNullOrEmpty(((RepresentativePerson)representative).Cpf))
                    {
                        context.AddFailure("cpf", "'Cpf' deve ser informado.");
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(((RepresentativeCompany)representative).Cnpj))
                    {
                        context.AddFailure("cnpj", "'CNPJ' deve ser informado.");
                    }
                if (string.IsNullOrEmpty(((RepresentativeCompany)representative).Contact))
                    {
                        context.AddFailure("relationship", "'Contato' deve ser informado.");
                    }
                }
            });
        }
    }
}
