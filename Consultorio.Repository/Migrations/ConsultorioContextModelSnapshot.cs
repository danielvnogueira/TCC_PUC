﻿// <auto-generated />
using System;
using Consultorio.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Consultorio.Repository.Migrations
{
    [DbContext(typeof(ConsultorioContext))]
    partial class ConsultorioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Consultorio.Domain.Acompanhamentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AtendimentoId");

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("DtAcompanhamento");

                    b.HasKey("Id");

                    b.HasIndex("AtendimentoId");

                    b.ToTable("Acompanhamentos");
                });

            modelBuilder.Entity("Consultorio.Domain.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataConsulta");

                    b.Property<DateTime>("DataSintomas");

                    b.Property<string>("Descricao");

                    b.Property<int>("DiasQuarentena");

                    b.Property<int?>("HospitalId");

                    b.Property<string>("Observacao");

                    b.Property<int>("PacienteId");

                    b.Property<int>("ResponsavelId");

                    b.Property<int>("SintomasId");

                    b.Property<int>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("ResponsavelId");

                    b.HasIndex("SintomasId");

                    b.HasIndex("StatusId");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("Consultorio.Domain.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DsInternacao");

                    b.Property<string>("Local");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Hospitais");
                });

            modelBuilder.Entity("Consultorio.Domain.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular");

                    b.Property<DateTime>("DtNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("NomePaciente");

                    b.Property<string>("Observacao");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("Consultorio.Domain.Responsavel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cpf");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<int>("NrConselho");

                    b.Property<string>("Telefone");

                    b.Property<string>("TpConselho");

                    b.HasKey("Id");

                    b.ToTable("Responsaveis");
                });

            modelBuilder.Entity("Consultorio.Domain.ResponsavelAtendimento", b =>
                {
                    b.Property<int>("ResponsavelId");

                    b.Property<int>("AtendimentoId");

                    b.HasKey("ResponsavelId", "AtendimentoId");

                    b.HasIndex("AtendimentoId");

                    b.ToTable("ResponsavelAtendimentos");
                });

            modelBuilder.Entity("Consultorio.Domain.Sintomas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("Sintomas");
                });

            modelBuilder.Entity("Consultorio.Domain.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("Consultorio.Domain.Acompanhamentos", b =>
                {
                    b.HasOne("Consultorio.Domain.Atendimento", "Atendimento")
                        .WithMany("Acompanhamentos")
                        .HasForeignKey("AtendimentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Consultorio.Domain.Atendimento", b =>
                {
                    b.HasOne("Consultorio.Domain.Hospital", "Hospital")
                        .WithMany("Atendimentos")
                        .HasForeignKey("HospitalId");

                    b.HasOne("Consultorio.Domain.Paciente", "Paciente")
                        .WithMany("Atendimentos")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Consultorio.Domain.Responsavel", "Responsavel")
                        .WithMany("Atendimentos")
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Consultorio.Domain.Sintomas", "Sintomas")
                        .WithMany("Atendimentos")
                        .HasForeignKey("SintomasId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Consultorio.Domain.Status", "Status")
                        .WithMany("Atendimentos")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Consultorio.Domain.ResponsavelAtendimento", b =>
                {
                    b.HasOne("Consultorio.Domain.Atendimento", "Atendimento")
                        .WithMany()
                        .HasForeignKey("AtendimentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Consultorio.Domain.Responsavel", "Responsavel")
                        .WithMany("ResponsavelAtendimentos")
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}