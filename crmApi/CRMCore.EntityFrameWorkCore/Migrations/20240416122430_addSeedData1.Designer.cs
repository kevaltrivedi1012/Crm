﻿// <auto-generated />
using System;
using CRMCore.EntityFrameWorkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRMCore.EntityFrameWorkCore.Migrations
{
    [DbContext(typeof(CRMCoreDbContext))]
    [Migration("20240416122430_addSeedData1")]
    partial class addSeedData1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Accounts.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IndustryId")
                        .HasColumnType("int");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.Property<string>("Web")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("IndustryId");

                    b.HasIndex("TypeId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Accounts.AccountCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccountCategories");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Accounts.AccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccountTypes");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Accounts.AccoutIndustry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccoutIndustries");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Contacts.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.HasIndex("TypeId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Contacts.ContactType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactTypes");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Leads.Lead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerNeedId")
                        .HasColumnType("int");

                    b.Property<int?>("StageId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerNeedId");

                    b.HasIndex("StageId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Leads.LeadCustomerNeed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CustomerNeed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeadCustomerNeeds");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Leads.LeadStage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeadStages");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Leads.LeadStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeadStatuses");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Leads.LeadType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeadTypes");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Opportunities.Opportunity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CloseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContractValue")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalesChannelId")
                        .HasColumnType("int");

                    b.Property<int>("StageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SalesChannelId");

                    b.HasIndex("StageId");

                    b.ToTable("Opportunities");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Opportunities.OpportunitySalesChannel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("SalesChannel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OpportunitySalesChannels");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Opportunities.OpportunityStage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OpportunityStages");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Tasks.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("StatusId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Tasks.TaskCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskCategories");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Tasks.TaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskStatuses");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Tenants.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsEmailVerified")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Users.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("TenantId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "hostadmin@gmail.com",
                            MobileNumber = "1234567890",
                            Name = "HostAdmin",
                            Password = "hostadmin",
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Accounts.Account", b =>
                {
                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Accounts.AccountCategory", "AccountCategories")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Accounts.AccoutIndustry", "AccoutIndustries")
                        .WithMany()
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Accounts.AccountType", "AccountTypes")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AccountCategories");

                    b.Navigation("AccountTypes");

                    b.Navigation("AccoutIndustries");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Contacts.Contact", b =>
                {
                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Tenants.Tenant", "Tenants")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Contacts.ContactType", "ContactTypes")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ContactTypes");

                    b.Navigation("Tenants");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Leads.Lead", b =>
                {
                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Leads.LeadCustomerNeed", "LeadCustomerNeeds")
                        .WithMany()
                        .HasForeignKey("CustomerNeedId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Leads.LeadStage", "LeadStages")
                        .WithMany()
                        .HasForeignKey("StageId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Leads.LeadStatus", "LeadStatuses")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Leads.LeadType", "LeadTypes")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("LeadCustomerNeeds");

                    b.Navigation("LeadStages");

                    b.Navigation("LeadStatuses");

                    b.Navigation("LeadTypes");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Opportunities.Opportunity", b =>
                {
                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Opportunities.OpportunitySalesChannel", "OpportunitySalesChannels")
                        .WithMany()
                        .HasForeignKey("SalesChannelId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Opportunities.OpportunityStage", "OpportunityStages")
                        .WithMany()
                        .HasForeignKey("StageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("OpportunitySalesChannels");

                    b.Navigation("OpportunityStages");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Tasks.Task", b =>
                {
                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Tasks.TaskCategory", "TaskCategories")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Tasks.TaskStatus", "TaskStatuses")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("TaskCategories");

                    b.Navigation("TaskStatuses");
                });

            modelBuilder.Entity("CRMCore.EntityFrameWorkCore.Model.Users.User", b =>
                {
                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Users.Role", "Roles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CRMCore.EntityFrameWorkCore.Model.Tenants.Tenant", "Tenants")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Roles");

                    b.Navigation("Tenants");
                });
#pragma warning restore 612, 618
        }
    }
}
