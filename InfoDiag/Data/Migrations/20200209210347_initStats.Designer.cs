﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(InfoDiagContext))]
    [Migration("20200209210347_initStats")]
    partial class InitStats
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Email");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Entity.CodingLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CodingLanguage");
                });

            modelBuilder.Entity("Entity.Compilation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CompilationTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Compilation");
                });

            modelBuilder.Entity("Entity.CompilationError", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompilationId")
                        .HasColumnType("int");

                    b.Property<string>("ErrorCodeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompilationId");

                    b.HasIndex("ErrorCodeId");

                    b.ToTable("CompilationError");
                });

            modelBuilder.Entity("Entity.CompilationErrorLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CompilationErrorId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompilationErrorId");

                    b.ToTable("CompilationErrorLine");
                });

            modelBuilder.Entity("Entity.Course", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CodingLanguageId")
                        .HasColumnType("int");

                    b.Property<int?>("InstitutionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CodingLanguageId");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Entity.CourseGroup", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("GroupNumber")
                        .HasColumnType("int");

                    b.Property<string>("TermId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TermId");

                    b.ToTable("CourseGroup");
                });

            modelBuilder.Entity("Entity.CourseGroupClient", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("CourseGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ClientId", "CourseGroupId");

                    b.HasIndex("CourseGroupId");

                    b.ToTable("CourseGroupClient");
                });

            modelBuilder.Entity("Entity.CourseGroupUser", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("CourseGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "CourseGroupId");

                    b.HasIndex("CourseGroupId");

                    b.ToTable("CourseGroupUser");
                });

            modelBuilder.Entity("Entity.ErrorCode", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CodingLanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CodingLanguageId");

                    b.ToTable("ErrorCode");
                });

            modelBuilder.Entity("Entity.Institution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Institution");
                });

            modelBuilder.Entity("Entity.StatLine", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ErrorCodeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsErrorCode")
                        .HasColumnType("bit");

                    b.Property<int>("NbOccurence")
                        .HasColumnType("int");

                    b.Property<long>("StatsId")
                        .HasColumnType("bigint");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ErrorCodeId");

                    b.HasIndex("StatsId");

                    b.ToTable("StatLine");
                });

            modelBuilder.Entity("Entity.Stats", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompilationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompilationId");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("Entity.Term", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TermType")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Term");
                });

            modelBuilder.Entity("Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Email");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Entity.Compilation", b =>
                {
                    b.HasOne("Entity.Client", null)
                        .WithMany("Compilations")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.CompilationError", b =>
                {
                    b.HasOne("Entity.Compilation", null)
                        .WithMany("CompilationErrors")
                        .HasForeignKey("CompilationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.ErrorCode", "ErrorCode")
                        .WithMany()
                        .HasForeignKey("ErrorCodeId");
                });

            modelBuilder.Entity("Entity.CompilationErrorLine", b =>
                {
                    b.HasOne("Entity.CompilationError", null)
                        .WithMany("Lines")
                        .HasForeignKey("CompilationErrorId");
                });

            modelBuilder.Entity("Entity.Course", b =>
                {
                    b.HasOne("Entity.CodingLanguage", "CodingLanguage")
                        .WithMany("Courses")
                        .HasForeignKey("CodingLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Institution", null)
                        .WithMany("Courses")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("Entity.CourseGroup", b =>
                {
                    b.HasOne("Entity.Course", "Course")
                        .WithMany("CourseGroups")
                        .HasForeignKey("CourseId");

                    b.HasOne("Entity.Term", "Term")
                        .WithMany("CourseGroups")
                        .HasForeignKey("TermId");
                });

            modelBuilder.Entity("Entity.CourseGroupClient", b =>
                {
                    b.HasOne("Entity.Client", "Client")
                        .WithMany("CourseGroupClients")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.CourseGroup", "CourseGroup")
                        .WithMany("CourseGroupClients")
                        .HasForeignKey("CourseGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.CourseGroupUser", b =>
                {
                    b.HasOne("Entity.CourseGroup", "CourseGroup")
                        .WithMany("CourseGroupUsers")
                        .HasForeignKey("CourseGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.User", "User")
                        .WithMany("CourseGroupUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.ErrorCode", b =>
                {
                    b.HasOne("Entity.CodingLanguage", "CodingLanguage")
                        .WithMany("ErrorCodes")
                        .HasForeignKey("CodingLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.StatLine", b =>
                {
                    b.HasOne("Entity.ErrorCode", "ErrorCode")
                        .WithMany()
                        .HasForeignKey("ErrorCodeId");

                    b.HasOne("Entity.Stats", "Stats")
                        .WithMany("Lines")
                        .HasForeignKey("StatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Stats", b =>
                {
                    b.HasOne("Entity.Compilation", "Compilation")
                        .WithMany()
                        .HasForeignKey("CompilationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
