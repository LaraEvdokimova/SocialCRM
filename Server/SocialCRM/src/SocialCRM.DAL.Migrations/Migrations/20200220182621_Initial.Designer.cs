﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SocialCRM.DAL.Implementations;

namespace SocialCRM.DAL.Migrations.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200220182621_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SocialCRM.DAL.Implementations.Entities.CompanyEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Inn")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid?>("UserCreated")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserUpdated")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("SocialCRM.DAL.Implementations.Entities.EmployeeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("EmploymentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<Guid?>("UserCreated")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserUpdated")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SocialCRM.DAL.Implementations.Entities.LeadEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("PersonId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserCreated")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserUpdated")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("SocialCRM.DAL.Implementations.Entities.LegalEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("LeadId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserCreated")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserUpdated")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("LeadId");

                    b.ToTable("Legals");
                });

            modelBuilder.Entity("SocialCRM.DAL.Implementations.Entities.OrderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("LeadId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserCreated")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserUpdated")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("LeadId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SocialCRM.DAL.Implementations.Entities.PersonEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("SecondPhone")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<Guid?>("UserCreated")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserUpdated")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("SocialCRM.DAL.Implementations.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("BuyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid?>("OrderEntityId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("SellDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UserCreated")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserUpdated")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("OrderEntityId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SocialCRM.DAL.Implementations.Entities.EmployeeEntity", b =>
                {
                    b.HasOne("SocialCRM.DAL.Implementations.Entities.PersonEntity", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("SocialCRM.DAL.Implementations.Entities.LeadEntity", b =>
                {
                    b.HasOne("SocialCRM.DAL.Implementations.Entities.PersonEntity", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("SocialCRM.DAL.Implementations.Entities.LegalEntity", b =>
                {
                    b.HasOne("SocialCRM.DAL.Implementations.Entities.CompanyEntity", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("SocialCRM.DAL.Implementations.Entities.LeadEntity", "Lead")
                        .WithMany()
                        .HasForeignKey("LeadId");
                });

            modelBuilder.Entity("SocialCRM.DAL.Implementations.Entities.OrderEntity", b =>
                {
                    b.HasOne("SocialCRM.DAL.Implementations.Entities.LeadEntity", "Lead")
                        .WithMany()
                        .HasForeignKey("LeadId");
                });

            modelBuilder.Entity("SocialCRM.DAL.Implementations.Entities.ProductEntity", b =>
                {
                    b.HasOne("SocialCRM.DAL.Implementations.Entities.OrderEntity", null)
                        .WithMany("Products")
                        .HasForeignKey("OrderEntityId");
                });
#pragma warning restore 612, 618
        }
    }
}
