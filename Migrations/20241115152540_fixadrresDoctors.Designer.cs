﻿// <auto-generated />
using System;
using Assessment_Riwi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assessment_Riwi.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20241115152540_fixadrresDoctors")]
    partial class fixadrresDoctors
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Assessment_Riwi.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("AppointmentDay")
                        .HasColumnType("date")
                        .HasColumnName("appointment_day");

                    b.Property<TimeOnly>("AppointmentTime")
                        .HasColumnType("time(6)")
                        .HasColumnName("appointment_time");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("description");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("doctor_id");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patient_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppointmentDay = new DateOnly(2024, 11, 18),
                            AppointmentTime = new TimeOnly(9, 30, 0),
                            Description = "check-up with dr. martinez",
                            DoctorId = 2,
                            PatientId = 1,
                            Status = "scheduled"
                        },
                        new
                        {
                            Id = 2,
                            AppointmentDay = new DateOnly(2024, 11, 20),
                            AppointmentTime = new TimeOnly(14, 15, 0),
                            Description = "follow-up consultation",
                            DoctorId = 6,
                            PatientId = 2,
                            Status = "scheduled"
                        },
                        new
                        {
                            Id = 3,
                            AppointmentDay = new DateOnly(2024, 11, 14),
                            AppointmentTime = new TimeOnly(8, 45, 0),
                            Description = "routine physical exam",
                            DoctorId = 1,
                            PatientId = 3,
                            Status = "completed"
                        },
                        new
                        {
                            Id = 4,
                            AppointmentDay = new DateOnly(2024, 11, 22),
                            AppointmentTime = new TimeOnly(11, 0, 0),
                            Description = "dental check-up",
                            DoctorId = 8,
                            PatientId = 4,
                            Status = "canceled"
                        },
                        new
                        {
                            Id = 5,
                            AppointmentDay = new DateOnly(2024, 11, 25),
                            AppointmentTime = new TimeOnly(15, 0, 0),
                            Description = "general health assessment",
                            DoctorId = 9,
                            PatientId = 5,
                            Status = "scheduled"
                        },
                        new
                        {
                            Id = 6,
                            AppointmentDay = new DateOnly(2024, 11, 30),
                            AppointmentTime = new TimeOnly(12, 30, 0),
                            Description = "eye examination",
                            DoctorId = 5,
                            PatientId = 6,
                            Status = "rescheduled"
                        },
                        new
                        {
                            Id = 7,
                            AppointmentDay = new DateOnly(2024, 11, 27),
                            AppointmentTime = new TimeOnly(7, 45, 0),
                            Description = "annual check-up",
                            DoctorId = 3,
                            PatientId = 7,
                            Status = "scheduled"
                        },
                        new
                        {
                            Id = 8,
                            AppointmentDay = new DateOnly(2024, 11, 10),
                            AppointmentTime = new TimeOnly(13, 45, 0),
                            Description = "post-surgery follow-up",
                            DoctorId = 7,
                            PatientId = 8,
                            Status = "completed"
                        },
                        new
                        {
                            Id = 9,
                            AppointmentDay = new DateOnly(2024, 11, 23),
                            AppointmentTime = new TimeOnly(10, 30, 0),
                            Description = "consultation on chronic pain",
                            DoctorId = 4,
                            PatientId = 9,
                            Status = "scheduled"
                        },
                        new
                        {
                            Id = 10,
                            AppointmentDay = new DateOnly(2024, 11, 17),
                            AppointmentTime = new TimeOnly(6, 15, 0),
                            Description = "vaccination",
                            DoctorId = 5,
                            PatientId = 10,
                            Status = "scheduled"
                        });
                });

            modelBuilder.Entity("Assessment_Riwi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("address");

                    b.Property<TimeOnly>("DepartureTime")
                        .HasColumnType("time(6)")
                        .HasColumnName("departure_time");

                    b.Property<TimeOnly>("EntryTime")
                        .HasColumnType("time(6)")
                        .HasColumnName("entry_time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("varchar(7)")
                        .HasColumnName("role");

                    b.HasKey("Id");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "smith.gomez@email.com",
                            DepartureTime = new TimeOnly(16, 0, 0),
                            EntryTime = new TimeOnly(8, 0, 0),
                            Name = "john smith",
                            Password = "$2a$11$Jwa4yGhoLIY31DxKtX4Cf.T20vYUYqrk/hvavRz0cDn5VU0ryjAXy",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 2,
                            Address = "davis.gomez@email.com",
                            DepartureTime = new TimeOnly(17, 0, 0),
                            EntryTime = new TimeOnly(9, 0, 0),
                            Name = "emily davis",
                            Password = "$2a$11$lK9hyALcCcxXZ1sZtOK78ec6JrjkwBgfuNqK8cqKt89hcGVVHLwI.",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 3,
                            Address = "johnson.gomez@email.com",
                            DepartureTime = new TimeOnly(15, 30, 0),
                            EntryTime = new TimeOnly(7, 30, 0),
                            Name = "michael johnson",
                            Password = "$2a$11$KOLUu8pyDF9VGb7YHf93T.1m6yVd6Gsivm6Lah1sx7rJVuF9x8Nqy",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 4,
                            Address = "brown.gomez@email.com",
                            DepartureTime = new TimeOnly(18, 0, 0),
                            EntryTime = new TimeOnly(10, 0, 0),
                            Name = "sophia brown",
                            Password = "$2a$11$zp94w.8gBBbmfUlgcb80su97HMCR7A0/l6taSKdfga5jRt6VHj2r2",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 5,
                            Address = "james.gomez@email.com",
                            DepartureTime = new TimeOnly(14, 0, 0),
                            EntryTime = new TimeOnly(6, 0, 0),
                            Name = "james williams",
                            Password = "$2a$11$1.n.TLnaqSVaeZvwE6s1C.r2dMkUd6G55cVFyfbRVgbMUI8.PCwbO",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 6,
                            Address = "olivia.gomez@email.com",
                            DepartureTime = new TimeOnly(21, 0, 0),
                            EntryTime = new TimeOnly(13, 0, 0),
                            Name = "olivia martinez",
                            Password = "$2a$11$IEH/Yd9LcOLqofdVNNodHuT4sXDn4eap6J3XR8CB06KMKCogc9vaK",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 7,
                            Address = "benjamin.gomez@email.com",
                            DepartureTime = new TimeOnly(20, 0, 0),
                            EntryTime = new TimeOnly(12, 0, 0),
                            Name = "benjamin wilson",
                            Password = "$2a$11$9EvYWa5qzomSrXmIC77KS.7W2oQgE1whED7UV07QQG6E0S8TPW4.O",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 8,
                            Address = "miller.gomez@email.com",
                            DepartureTime = new TimeOnly(19, 0, 0),
                            EntryTime = new TimeOnly(11, 0, 0),
                            Name = "isabella miller",
                            Password = "$2a$11$qm0CFGelAAUfbcWBW1ktAucH2cQoBQSAtVb0.bwsGA.Ht5j1WoXie",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 9,
                            Address = "clark.gomez@email.com",
                            DepartureTime = new TimeOnly(22, 0, 0),
                            EntryTime = new TimeOnly(14, 0, 0),
                            Name = "elijah garcia",
                            Password = "$2a$11$5NJiFbx.D0EG9QqqrYUQ2.Y1kT0FDXUzZ.VztzcgFaztDTEBO7zRu",
                            Role = "doctor"
                        },
                        new
                        {
                            Id = 10,
                            Address = "garcia.gomez@email.com",
                            DepartureTime = new TimeOnly(13, 30, 0),
                            EntryTime = new TimeOnly(5, 30, 0),
                            Name = "amelia clark",
                            Password = "$2a$11$lHZRU/wNlFhGj4NsieM69Or3PhNmbzHT8.1J7JOX2Iy/kkCKFQzRi",
                            Role = "doctor"
                        });
                });

            modelBuilder.Entity("Assessment_Riwi.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("role");

                    b.HasKey("Id");

                    b.ToTable("patient");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "alice.green@example.com",
                            Name = "alice green",
                            Password = "$2a$11$mzPDxc3UAWpZMlEJmj3xGu8/t8hduW7BIpGOfH0Sm/WA21fLeIF6C",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 2,
                            Address = "bob.brown@example.com",
                            Name = "bob brown",
                            Password = "$2a$11$p/ZxWzcYD1VBB8rPUY2pH.mG3JNRdmsxPq8oXu2S46YkMF6mz7.a6",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 3,
                            Address = "charlie.white@example.com",
                            Name = "charlie white",
                            Password = "$2a$11$7sq.MGjwnhDR0f0.Js2eeeq6tT3RTPdJCEfhspg5MJg8aE87NhBzO",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 4,
                            Address = "diana.black@example.com",
                            Name = "diana black",
                            Password = "$2a$11$8MgHntp9MZQoUn4GcUkthOoogYudVkrDR60pcEFL4255aSG1l.1Cu",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 5,
                            Address = "edward.harris@example.com",
                            Name = "edward harris",
                            Password = "$2a$11$yQk7nGI7JklrbGI46re2kOLiWpQD4QRahIHVTCqKiUz68mTRc2Xza",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 6,
                            Address = "fiona.scott@example.com",
                            Name = "fiona scott",
                            Password = "$2a$11$cKKLYVY1Dw9GdbM4oa836.KCXrGJxecGdkgQWpZazbZu56B.vA6hO",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 7,
                            Address = "george.clark@example.com",
                            Name = "george clark",
                            Password = "$2a$11$Gq9B4zFDP3.wPIk6zbklaO8bV4I6tnlen74X2LPqsgwwoLaAw0XnK",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 8,
                            Address = "hannah.king@example.com",
                            Name = "hannah king",
                            Password = "$2a$11$BYkjWoj9CXZTchiPWeas2uJyvnStIMmijmRJLDgL.2g20JKQxeJUi",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 9,
                            Address = "ian.wilson@example.com",
                            Name = "ian wilson",
                            Password = "$2a$11$kONP/NJV7AABXheAP4sO9O36SRw2PAQbXnvzyk7DMMnnQgMTdHpJ6",
                            Role = "patient"
                        },
                        new
                        {
                            Id = 10,
                            Address = "julia.turner@example.com",
                            Name = "julia turner",
                            Password = "$2a$11$iHZKi05e3jDtra0E9sSXUOwHhiSZqUwvPTddJE05Q.Yx88ff8JEtO",
                            Role = "patient"
                        });
                });

            modelBuilder.Entity("Assessment_Riwi.Models.Appointment", b =>
                {
                    b.HasOne("Assessment_Riwi.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assessment_Riwi.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}