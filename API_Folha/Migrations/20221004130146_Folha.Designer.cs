﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_Folha.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221004130146_Folha")]
    partial class Folha
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("API.Models.Folha", b =>
                {
                    b.Property<int>("folhaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("fgts")
                        .HasColumnType("INTEGER");

                    b.Property<int>("inss")
                        .HasColumnType("INTEGER");

                    b.Property<int>("quantidadehoras")
                        .HasColumnType("INTEGER");

                    b.Property<int>("renda")
                        .HasColumnType("INTEGER");

                    b.Property<int>("salariobruto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("salarioliquido")
                        .HasColumnType("INTEGER");

                    b.Property<int>("valorhora")
                        .HasColumnType("INTEGER");

                    b.HasKey("folhaid");

                    b.ToTable("Folhas");
                });

            modelBuilder.Entity("API.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}