﻿using AutoMapper;
using Onboarding.Models;
using Onboarding.ViewModels;
using Onboarding.ViewModels.AcademicApprovals;

namespace Onboarding.Bindings
{
    public class AcademicApprovalProfile : Profile
    {
        public AcademicApprovalProfile()
        {
            CreateMap<Enrollment, Records>()
            .ForMember(x => x.Name, config => config.MapFrom(x => x.PersonalData.RealName))
            .ForMember(x => x.EnrollmentNumber, config => config.MapFrom(x => x.ExternalId))
            .ForMember(x => x.CPF, config => config.MapFrom(x => x.PersonalData.CPF));

            CreateMap<Enrollment, Record>()
            .ForMember(x => x.Name, config => config.MapFrom(x => x.PersonalData.RealName))
            .ForMember(x => x.EnrollmentNumber, config => config.MapFrom(x => x.ExternalId))
            .ForMember(x => x.CPF, config => config.MapFrom(x => x.PersonalData.CPF));

            CreateMap<Models.Pendency, ViewModels.Pendency>();
            CreateMap<ViewModels.Pendency, Models.Pendency>();

            CreateMap<ViewModels.AcademicApprovals.AcademicPendency, Models.EnrollmentPendency>()
            .ForMember(x => x.Pendency, config => config.MapFrom(c => new EnrollmentPendency
            {
                Pendency = new Models.AcademicPendency
                {
                    Id = c.Id,
                    SectionId = c.SectionId.Value,
                    Description = c.Description
                }
            }));
        }
    }
}
