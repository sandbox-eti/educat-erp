using FluentValidation.Results;
using Onboarding.Models;
using Onboarding.Validations;
using Onboarding.Validations.FinanceData;

namespace Onboarding.Statuses
{
    public class FinanceDataStatus : BaseStatus<FinanceData>
    {
        public FinanceDataMessagesValidator _financeDataMessageValidator { get; set; }

        public FinanceDataStatus(FinanceDataValidator validator, FinanceData entity, FinanceDataMessagesValidator financeDataMessageValidator) : base(validator, entity)
        {
            _financeDataMessageValidator = financeDataMessageValidator;
        }

        public override string GetStatus()
        {
            ValidationResult results = _validator.Validate(_entity);
            ValidationResult resultsMessages = _financeDataMessageValidator.Validate(_entity);

            if (!_entity.UpdatedAt.HasValue)
            {
                return "empty";
            }
            if (results.IsValid && resultsMessages.IsValid)
            {
                return "valid";
            }
            else
            {
                return "invalid";
            }
        }
    }
}
