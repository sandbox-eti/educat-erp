﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using onboarding.Models;
using System;

namespace onboarding.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20180605155924_remove_pendencies_and_add_to_enrollment_step")]
    partial class remove_pendencies_and_add_to_enrollment_step
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("onboarding.Models.AddressKind", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("AddressKinds");
                });

            modelBuilder.Entity("onboarding.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("StateId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("onboarding.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("AcceptedAt");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<int?>("EnrollmentId");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Signature");

                    b.Property<string>("URL");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("EnrollmentId")
                        .IsUnique()
                        .HasFilter("[EnrollmentId] IS NOT NULL");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("onboarding.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckForeignGraduation");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<bool>("HasUF");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("onboarding.Models.Disability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Disabilities");
                });

            modelBuilder.Entity("onboarding.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<int?>("DocumentTypeId");

                    b.Property<string>("ExternalId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("DocumentTypeId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("onboarding.Models.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Validations");

                    b.HasKey("Id");

                    b.ToTable("DocumentTypes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("DocumentType");
                });

            modelBuilder.Entity("onboarding.Models.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<int?>("InvoiceId");

                    b.Property<int?>("OnboardingId");

                    b.Property<string>("Photo");

                    b.Property<DateTime?>("SentAt");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("OnboardingId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("onboarding.Models.EnrollmentStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<int>("EnrollmentId");

                    b.Property<string>("ExternalId");

                    b.Property<int>("StepId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("EnrollmentId");

                    b.HasIndex("StepId");

                    b.ToTable("EnrollmentSteps");
                });

            modelBuilder.Entity("onboarding.Models.FinanceData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<int?>("EnrollmentId");

                    b.Property<string>("ExternalId");

                    b.Property<int?>("PaymentMethodId");

                    b.Property<int?>("PlanId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("EnrollmentId")
                        .IsUnique()
                        .HasFilter("[EnrollmentId] IS NOT NULL");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("PlanId");

                    b.ToTable("FinanceDatas");
                });

            modelBuilder.Entity("onboarding.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckMilitaryDraft");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("onboarding.Models.Guarantor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressKindId");

                    b.Property<string>("AddressNumber");

                    b.Property<int?>("CityId");

                    b.Property<string>("ComplementAddress");

                    b.Property<string>("Cpf");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("ExternalId");

                    b.Property<int?>("FinanceDataId");

                    b.Property<string>("Landline");

                    b.Property<string>("Name");

                    b.Property<string>("Neighborhood");

                    b.Property<string>("PhoneNumber");

                    b.Property<int?>("RelationshipId");

                    b.Property<int?>("StateId");

                    b.Property<string>("StreetAddress");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Zipcode");

                    b.HasKey("Id");

                    b.HasIndex("AddressKindId");

                    b.HasIndex("CityId");

                    b.HasIndex("FinanceDataId");

                    b.HasIndex("RelationshipId");

                    b.HasIndex("StateId");

                    b.ToTable("Guarantors");
                });

            modelBuilder.Entity("onboarding.Models.GuarantorDocument", b =>
                {
                    b.Property<int>("GuarantorId");

                    b.Property<int>("DocumentId");

                    b.HasKey("GuarantorId", "DocumentId");

                    b.HasIndex("DocumentId");

                    b.ToTable("GuarantorDocument");
                });

            modelBuilder.Entity("onboarding.Models.HighSchoolKind", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("HighSchoolKinds");
                });

            modelBuilder.Entity("onboarding.Models.MaritalStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("MaritalStatuses");
                });

            modelBuilder.Entity("onboarding.Models.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckForeign");

                    b.Property<bool>("CheckNative");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("onboarding.Models.Onboarding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("EndAt");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Semester");

                    b.Property<string>("StartAt");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Year");

                    b.HasKey("Id");

                    b.ToTable("Onboardings");
                });

            modelBuilder.Entity("onboarding.Models.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("onboarding.Models.Pendency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("EnrollmentStepId");

                    b.Property<string>("ExternalId");

                    b.Property<int>("SectionId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("EnrollmentStepId");

                    b.HasIndex("SectionId");

                    b.ToTable("Pendencies");
                });

            modelBuilder.Entity("onboarding.Models.PersonalData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressKindId");

                    b.Property<string>("AddressNumber");

                    b.Property<string>("AssumedName");

                    b.Property<int?>("BirthCityId");

                    b.Property<string>("BirthCityName");

                    b.Property<int?>("BirthCountryId");

                    b.Property<string>("BirthDate");

                    b.Property<int?>("BirthStateId");

                    b.Property<string>("BirthStateName");

                    b.Property<string>("CPF");

                    b.Property<int?>("CityId");

                    b.Property<string>("ComplementAddress");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<int?>("EnrollmentId");

                    b.Property<string>("ExternalId");

                    b.Property<int?>("GenderId");

                    b.Property<string>("Handicap");

                    b.Property<int?>("HighSchoolGraduationCountryId");

                    b.Property<string>("HighSchoolGraduationYear");

                    b.Property<int?>("HighSchoolKindId");

                    b.Property<string>("Landline");

                    b.Property<int?>("MaritalStatusId");

                    b.Property<string>("MothersName");

                    b.Property<int?>("NationalityId");

                    b.Property<string>("Neighborhood");

                    b.Property<string>("PhoneNumber");

                    b.Property<int?>("RaceId");

                    b.Property<string>("RealName");

                    b.Property<int?>("StateId");

                    b.Property<string>("StreetAddress");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Zipcode");

                    b.HasKey("Id");

                    b.HasIndex("AddressKindId");

                    b.HasIndex("BirthCityId");

                    b.HasIndex("BirthCountryId");

                    b.HasIndex("BirthStateId");

                    b.HasIndex("CityId");

                    b.HasIndex("EnrollmentId")
                        .IsUnique()
                        .HasFilter("[EnrollmentId] IS NOT NULL");

                    b.HasIndex("GenderId");

                    b.HasIndex("HighSchoolGraduationCountryId");

                    b.HasIndex("HighSchoolKindId");

                    b.HasIndex("MaritalStatusId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("RaceId");

                    b.HasIndex("StateId");

                    b.ToTable("PersonalDatas");
                });

            modelBuilder.Entity("onboarding.Models.PersonalDataDisability", b =>
                {
                    b.Property<int>("PersonalDataId");

                    b.Property<int>("DisabilityId");

                    b.HasKey("PersonalDataId", "DisabilityId");

                    b.HasIndex("DisabilityId");

                    b.ToTable("PersonalDataDisability");
                });

            modelBuilder.Entity("onboarding.Models.PersonalDataDocument", b =>
                {
                    b.Property<int>("PersonalDataId");

                    b.Property<int>("DocumentId");

                    b.HasKey("PersonalDataId", "DocumentId");

                    b.HasIndex("DocumentId");

                    b.ToTable("PersonalDataDocument");
                });

            modelBuilder.Entity("onboarding.Models.PersonalDataSpecialNeed", b =>
                {
                    b.Property<int>("PersonalDataId");

                    b.Property<int>("SpecialNeedId");

                    b.HasKey("PersonalDataId", "SpecialNeedId");

                    b.HasIndex("SpecialNeedId");

                    b.ToTable("PersonalDataSpecialNeed");
                });

            modelBuilder.Entity("onboarding.Models.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("DueDate");

                    b.Property<string>("ExternalId");

                    b.Property<int>("Guarantors");

                    b.Property<string>("InstallmentValue");

                    b.Property<int>("Installments");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("onboarding.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("onboarding.Models.Relationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckSpouse");

                    b.Property<bool>("CheckStudentIsRepresentative");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Relationships");
                });

            modelBuilder.Entity("onboarding.Models.Representative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressKindId");

                    b.Property<string>("AddressNumber");

                    b.Property<int?>("CityId");

                    b.Property<string>("ComplementAddress");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("ExternalId");

                    b.Property<int?>("FinanceDataId");

                    b.Property<string>("Landline");

                    b.Property<string>("Name");

                    b.Property<string>("Neighborhood");

                    b.Property<string>("PhoneNumber");

                    b.Property<int?>("StateId");

                    b.Property<string>("StreetAddress");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("Zipcode");

                    b.HasKey("Id");

                    b.HasIndex("AddressKindId");

                    b.HasIndex("CityId");

                    b.HasIndex("FinanceDataId")
                        .IsUnique()
                        .HasFilter("[FinanceDataId] IS NOT NULL");

                    b.HasIndex("StateId");

                    b.ToTable("Representatives");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Representative");
                });

            modelBuilder.Entity("onboarding.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Anchor");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Sections");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Section");
                });

            modelBuilder.Entity("onboarding.Models.SpecialNeed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<int>("DisabilityId");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("DisabilityId");

                    b.ToTable("SpecialNeeds");
                });

            modelBuilder.Entity("onboarding.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("onboarding.Models.Step", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("ExternalId");

                    b.Property<bool>("HasApproval");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<string>("Resource");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("onboarding.Models.GuarantorDocumentType", b =>
                {
                    b.HasBaseType("onboarding.Models.DocumentType");


                    b.ToTable("GuarantorDocumentType");

                    b.HasDiscriminator().HasValue("GuarantorDocumentType");
                });

            modelBuilder.Entity("onboarding.Models.PersonalDocumentType", b =>
                {
                    b.HasBaseType("onboarding.Models.DocumentType");


                    b.ToTable("PersonalDocumentType");

                    b.HasDiscriminator().HasValue("PersonalDocumentType");
                });

            modelBuilder.Entity("onboarding.Models.ResponsibleDocumentType", b =>
                {
                    b.HasBaseType("onboarding.Models.DocumentType");


                    b.ToTable("ResponsibleDocumentType");

                    b.HasDiscriminator().HasValue("ResponsibleDocumentType");
                });

            modelBuilder.Entity("onboarding.Models.RepresentativeCompany", b =>
                {
                    b.HasBaseType("onboarding.Models.Representative");

                    b.Property<string>("Cnpj");

                    b.Property<string>("Contact");

                    b.ToTable("RepresentativeCompany");

                    b.HasDiscriminator().HasValue("RepresentativeCompany");
                });

            modelBuilder.Entity("onboarding.Models.RepresentativePerson", b =>
                {
                    b.HasBaseType("onboarding.Models.Representative");

                    b.Property<string>("Cpf");

                    b.Property<int?>("RelationshipId");

                    b.HasIndex("RelationshipId");

                    b.ToTable("RepresentativePerson");

                    b.HasDiscriminator().HasValue("RepresentativePerson");
                });

            modelBuilder.Entity("onboarding.Models.AcademicSection", b =>
                {
                    b.HasBaseType("onboarding.Models.Section");


                    b.ToTable("AcademicSection");

                    b.HasDiscriminator().HasValue("AcademicSection");
                });

            modelBuilder.Entity("onboarding.Models.FinanceSection", b =>
                {
                    b.HasBaseType("onboarding.Models.Section");


                    b.ToTable("FinanceSection");

                    b.HasDiscriminator().HasValue("FinanceSection");
                });

            modelBuilder.Entity("onboarding.Models.City", b =>
                {
                    b.HasOne("onboarding.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("onboarding.Models.Contract", b =>
                {
                    b.HasOne("onboarding.Models.Enrollment", "Enrollment")
                        .WithOne("Contract")
                        .HasForeignKey("onboarding.Models.Contract", "EnrollmentId");
                });

            modelBuilder.Entity("onboarding.Models.Document", b =>
                {
                    b.HasOne("onboarding.Models.DocumentType", "DocumentType")
                        .WithMany()
                        .HasForeignKey("DocumentTypeId");
                });

            modelBuilder.Entity("onboarding.Models.Enrollment", b =>
                {
                    b.HasOne("onboarding.Models.Onboarding", "Onboarding")
                        .WithMany("Enrollments")
                        .HasForeignKey("OnboardingId");
                });

            modelBuilder.Entity("onboarding.Models.EnrollmentStep", b =>
                {
                    b.HasOne("onboarding.Models.Enrollment", "Enrollment")
                        .WithMany("EnrollmentSteps")
                        .HasForeignKey("EnrollmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("onboarding.Models.Step", "Step")
                        .WithMany("EnrollmentSteps")
                        .HasForeignKey("StepId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("onboarding.Models.FinanceData", b =>
                {
                    b.HasOne("onboarding.Models.Enrollment", "Enrollment")
                        .WithOne("FinanceData")
                        .HasForeignKey("onboarding.Models.FinanceData", "EnrollmentId");

                    b.HasOne("onboarding.Models.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId");

                    b.HasOne("onboarding.Models.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId");
                });

            modelBuilder.Entity("onboarding.Models.Guarantor", b =>
                {
                    b.HasOne("onboarding.Models.AddressKind", "AddressKind")
                        .WithMany()
                        .HasForeignKey("AddressKindId");

                    b.HasOne("onboarding.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("onboarding.Models.FinanceData", "FinanceData")
                        .WithMany("Guarantors")
                        .HasForeignKey("FinanceDataId");

                    b.HasOne("onboarding.Models.Relationship", "Relationship")
                        .WithMany()
                        .HasForeignKey("RelationshipId");

                    b.HasOne("onboarding.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");
                });

            modelBuilder.Entity("onboarding.Models.GuarantorDocument", b =>
                {
                    b.HasOne("onboarding.Models.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("onboarding.Models.Guarantor", "Guarantor")
                        .WithMany("GuarantorDocuments")
                        .HasForeignKey("GuarantorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("onboarding.Models.Pendency", b =>
                {
                    b.HasOne("onboarding.Models.EnrollmentStep", "EnrollmentStep")
                        .WithMany("Pendencies")
                        .HasForeignKey("EnrollmentStepId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("onboarding.Models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("onboarding.Models.PersonalData", b =>
                {
                    b.HasOne("onboarding.Models.AddressKind", "AddressKind")
                        .WithMany()
                        .HasForeignKey("AddressKindId");

                    b.HasOne("onboarding.Models.City", "BirthCity")
                        .WithMany()
                        .HasForeignKey("BirthCityId");

                    b.HasOne("onboarding.Models.Country", "BirthCountry")
                        .WithMany()
                        .HasForeignKey("BirthCountryId");

                    b.HasOne("onboarding.Models.State", "BirthState")
                        .WithMany()
                        .HasForeignKey("BirthStateId");

                    b.HasOne("onboarding.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("onboarding.Models.Enrollment", "Enrollment")
                        .WithOne("PersonalData")
                        .HasForeignKey("onboarding.Models.PersonalData", "EnrollmentId");

                    b.HasOne("onboarding.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId");

                    b.HasOne("onboarding.Models.Country", "HighSchoolGraduationCountry")
                        .WithMany()
                        .HasForeignKey("HighSchoolGraduationCountryId");

                    b.HasOne("onboarding.Models.HighSchoolKind", "HighSchoolKind")
                        .WithMany()
                        .HasForeignKey("HighSchoolKindId");

                    b.HasOne("onboarding.Models.MaritalStatus", "MaritalStatus")
                        .WithMany()
                        .HasForeignKey("MaritalStatusId");

                    b.HasOne("onboarding.Models.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId");

                    b.HasOne("onboarding.Models.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId");

                    b.HasOne("onboarding.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");
                });

            modelBuilder.Entity("onboarding.Models.PersonalDataDisability", b =>
                {
                    b.HasOne("onboarding.Models.Disability", "Disability")
                        .WithMany()
                        .HasForeignKey("DisabilityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("onboarding.Models.PersonalData", "PersonalData")
                        .WithMany("PersonalDataDisabilities")
                        .HasForeignKey("PersonalDataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("onboarding.Models.PersonalDataDocument", b =>
                {
                    b.HasOne("onboarding.Models.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("onboarding.Models.PersonalData", "PersonalData")
                        .WithMany("PersonalDataDocuments")
                        .HasForeignKey("PersonalDataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("onboarding.Models.PersonalDataSpecialNeed", b =>
                {
                    b.HasOne("onboarding.Models.PersonalData", "PersonalData")
                        .WithMany("PersonalDataSpecialNeeds")
                        .HasForeignKey("PersonalDataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("onboarding.Models.SpecialNeed", "SpecialNeed")
                        .WithMany()
                        .HasForeignKey("SpecialNeedId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("onboarding.Models.Representative", b =>
                {
                    b.HasOne("onboarding.Models.AddressKind", "AddressKind")
                        .WithMany()
                        .HasForeignKey("AddressKindId");

                    b.HasOne("onboarding.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("onboarding.Models.FinanceData", "FinanceData")
                        .WithOne("Representative")
                        .HasForeignKey("onboarding.Models.Representative", "FinanceDataId");

                    b.HasOne("onboarding.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");
                });

            modelBuilder.Entity("onboarding.Models.SpecialNeed", b =>
                {
                    b.HasOne("onboarding.Models.Disability", "Disability")
                        .WithMany("SpecialNeeds")
                        .HasForeignKey("DisabilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("onboarding.Models.RepresentativePerson", b =>
                {
                    b.HasOne("onboarding.Models.Relationship", "Relationship")
                        .WithMany()
                        .HasForeignKey("RelationshipId");
                });
#pragma warning restore 612, 618
        }
    }
}
