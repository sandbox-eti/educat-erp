﻿using FluentValidation;
using Onboarding.Models;
using System.Linq;

namespace Onboarding.Statuses
{
    public class AcademicApprovalStatus : BaseStatus<Enrollment>
    {
        public AcademicApprovalStatus(AbstractValidator<Enrollment> validator, Enrollment entity) : base(validator, entity)
        {
        }

        public override string GetStatus()
        {
            if (_entity.AcademicApproval.HasValue)
            {
                return "approved";
            }
            else if (_entity.AcademicPendencies.Count() > 0)
            {
                return "pending";
            }
            else
            {
                return "reviewed";
            }
        }
    }
}
