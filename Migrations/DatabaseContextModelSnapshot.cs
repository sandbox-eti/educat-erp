﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Onboarding.Models;
using System;

namespace Onboarding.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Onboarding.Models.AddressType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CommitedBy");

                    b.Property<DateTime>("CommittedAt");

                    b.Property<int>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("AddressTypes");
                });

            modelBuilder.Entity("Onboarding.Models.CivilStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CommitedBy");

                    b.Property<DateTime>("CommittedAt");

                    b.Property<int>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("CivilStatus");
                });

            modelBuilder.Entity("Onboarding.Models.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CommitedBy");

                    b.Property<DateTime>("CommittedAt");

                    b.Property<int>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Onboarding.Models.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CommitedBy");

                    b.Property<DateTime>("CommittedAt");

                    b.Property<int>("ExternalId");

                    b.Property<string>("State");

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("Onboarding.Models.Gender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CommitedBy");

                    b.Property<DateTime>("CommittedAt");

                    b.Property<int>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("Onboarding.Models.Nationality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CommitedBy");

                    b.Property<DateTime>("CommittedAt");

                    b.Property<int>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("Onboarding.Models.PhoneType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CommitedBy");

                    b.Property<DateTime>("CommittedAt");

                    b.Property<int>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("PhoneTypes");
                });

            modelBuilder.Entity("Onboarding.Models.Race", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CommitedBy");

                    b.Property<DateTime>("CommittedAt");

                    b.Property<int>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("Onboarding.Models.School", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CommitedBy");

                    b.Property<DateTime>("CommittedAt");

                    b.Property<int>("ExternalId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });
#pragma warning restore 612, 618
        }
    }
}
