﻿using FluentValidation;
using Newtonsoft.Json;
using Onboarding.Enums;
using Onboarding.Models;
using System.Collections.Generic;
using System.Linq;

namespace Onboarding.Validations.FinanceData
{
    public class FinanceDataValidator : AbstractValidator<Models.FinanceData>
    {
        private List<GuarantorDocumentType> _documentTypes { get; set; }

        public FinanceDataValidator(DatabaseContext databaseContext)
        {
            _documentTypes = databaseContext.Set<GuarantorDocumentType>().ToList();

            RuleFor(financeData => financeData.Representative).SetValidator(new RepresentativeValidator());
            RuleFor(financeData => financeData.Guarantors).SetCollectionValidator(new GuarantorValidator());
            RuleFor(financeData => financeData.PlanId).NotNull();
            RuleFor(financeData => financeData.PaymentMethodId).NotNull();
            RuleFor(financeData => financeData.Guarantors).Custom((guarantors, context) =>
            {
                for (int i = 0; i < guarantors.Count; i++)
                {
                    Guarantor guarantor = guarantors.ToArray()[i];

                    databaseContext.Entry(guarantor).Reference(x => x.Relationship).Load();

                    foreach (GuarantorDocumentType documentType in _documentTypes)
                    {
                        List<string> errors = Validate(guarantor, documentType);

                        foreach (string error in errors)
                        {
                            context.AddFailure(string.Format("guarantors[{1}].documents.{0}", documentType.Id, i), string.Format("Documento {0} é obrigatório.", documentType.Name));
                        }
                    }
                }
            });
        }

        public List<string> Validate(Models.Guarantor guarantor, DocumentType documentType)
        {
            List<string> errors = new List<string>();
            List<string> validations = documentType.Validations != null ? JsonConvert.DeserializeObject<List<string>>(documentType.Validations) : new List<string>();

            if (documentType.Validations == null)
            {
                if (!guarantor.GuarantorDocuments.Any(x => x.Document.DocumentTypeId == documentType.Id))
                {
                    errors.Add(string.Format("Documento {0} é obrigatório.", documentType.Name));
                }
            }

            foreach (string validation in validations)
            {
                if (validation == DocumentValidations.Spouse.ToString())
                {
                    if (!CheckSpouse(guarantor))
                    {
                        errors.Add(GetMessageError(validation));
                    }
                }
            }

            return errors;
        }

        private bool CheckSpouse(Guarantor guarantor)
        {
            return (guarantor.Relationship != null && guarantor.Relationship.CheckSpouse && guarantor.GuarantorDocuments.Any(x => x.Document.DocumentTypeId != null && _documentTypes.SingleOrDefault(o => o.Id == x.Document.DocumentTypeId).Validations.Contains(DocumentValidations.Spouse.ToString()))) || guarantor.Relationship == null || !guarantor.Relationship.CheckSpouse;
        }

        private string GetMessageError(string validation)
        {
            if (validation == DocumentValidations.Spouse.ToString())
            {
                return "Certidão de casamento obrigatória.";
            }

            return string.Empty;
        }
    }
}
