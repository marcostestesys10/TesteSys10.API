﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteSys10.Infra.Data;

namespace TesteSys10.Infra.Migrations
{
    [DbContext(typeof(TesteSys10Context))]
    partial class TesteSys10ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteSys10.Domain.Models.AlunoModel", b =>
                {
                    b.Property<int>("IdAluno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPerfil")
                        .HasColumnType("int");

                    b.Property<int>("IdTurma")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<decimal>("NotaAluno")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("TurmaModelIdTurma")
                        .HasColumnType("int");

                    b.HasKey("IdAluno");

                    b.HasIndex("TurmaModelIdTurma");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("TesteSys10.Domain.Models.EscolaModel", b =>
                {
                    b.Property<int>("IdEscola")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEscola");

                    b.ToTable("Escola");
                });

            modelBuilder.Entity("TesteSys10.Domain.Models.PerfilModel", b =>
                {
                    b.Property<int>("IdPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPerfil");

                    b.ToTable("Perfis");
                });

            modelBuilder.Entity("TesteSys10.Domain.Models.TurmaModel", b =>
                {
                    b.Property<int>("IdTurma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeTurma")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTurma");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("TesteSys10.Domain.Models.UsuarioModel", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPerfil")
                        .HasColumnType("int");

                    b.Property<int?>("PerfilIdPerfil")
                        .HasColumnType("int");

                    b.HasKey("IdUsuario");

                    b.HasIndex("PerfilIdPerfil");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("TesteSys10.Domain.Models.AlunoModel", b =>
                {
                    b.HasOne("TesteSys10.Domain.Models.TurmaModel", null)
                        .WithMany("Alunos")
                        .HasForeignKey("TurmaModelIdTurma");
                });

            modelBuilder.Entity("TesteSys10.Domain.Models.UsuarioModel", b =>
                {
                    b.HasOne("TesteSys10.Domain.Models.PerfilModel", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilIdPerfil");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("TesteSys10.Domain.Models.TurmaModel", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}