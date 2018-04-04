﻿using FluentValidation;
using Newtonsoft.Json;
using Onboarding.Enums;
using Onboarding.Models;
using System.Collections.Generic;
using System.Linq;

namespace Onboarding.Validations
{
    public class FinanceDataMessagesValidator : AbstractValidator<FinanceData>
    {
        private List<GuarantorDocumentType> documentTypes { get; set; }

        public FinanceDataMessagesValidator(DatabaseContext databaseContext)
        {
            documentTypes = databaseContext.Set<GuarantorDocumentType>().Where(x => x.Validations == null).ToList();

            RuleFor(financeData => financeData).Custom((financeData, context) =>
            {
                foreach (Guarantor guarantor in financeData.Guarantors)
                {
                    List<string> validations = new List<string>();
                    validations.Add(BeSpouse(guarantor));
                    validations = validations.Where(x => !string.IsNullOrEmpty(x)).ToList();

                    List<Document> documents = guarantor.GuarantorDocuments.Select(x => x.Document).ToList();
                    List<string> documentTypeValidations = GetGuarantorDocumentValidations(documents);
                    List<string> requiredDocumentValidations = validations.Where(x => !documentTypeValidations.Contains(x)).ToList();
                    List<string> requiredDocumentTypes = documentTypes.Where(x => !documents.Any(o => o.DocumentTypeId == x.Id)).Select(x => x.Name).ToList();

                    foreach (string requiredDocument in requiredDocumentValidations)
                    {
                        context.AddFailure("guarantors[0]", GetMessageError(requiredDocument));
                    }
                    foreach (string documentType in requiredDocumentTypes)
                    {
                        context.AddFailure("guarantors[0]",string.Format("Documento {0} é obrigatório.", documentType));
                    }
                }
            });
        }

        private string BeSpouse(Guarantor guarantor)
        {
            return DocumentValidations.Spouse.ToString();
        }

        private List<string> GetGuarantorDocumentValidations(List<Document> documents)
        {
            List<string> documentTypeValidations = new List<string>();

            foreach (Document document in documents)
            {
                if (!string.IsNullOrEmpty(document.DocumentType.Validations))
                {
                    List<string> documentValidations = JsonConvert.DeserializeObject<List<string>>(document.DocumentType.Validations);
                    documentTypeValidations.AddRange(documentValidations.Where(x => !documentTypeValidations.Contains(x)));
                }
            }

            return documentTypeValidations;
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
