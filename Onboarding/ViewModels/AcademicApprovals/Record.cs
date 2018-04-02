using System.Collections.Generic;

namespace Onboarding.ViewModels.AcademicApprovals
{
    public class Record
    {
        public string Name { get; set; }

        public string CPF { get; set; }

        public string EnrollmentNumber { get; set; }

        public IEnumerable<AcademicPendency> Pendencies { get; set; }
    }
}
