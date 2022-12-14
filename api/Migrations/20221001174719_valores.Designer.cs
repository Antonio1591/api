// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Data;

namespace api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221001174719_valores")]
    partial class valores
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("api.Model.Domain.Animais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Raca")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("animais");
                });

            modelBuilder.Entity("api.Model.Domain.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("cidades");
                });

            modelBuilder.Entity("api.Model.Domain.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CidadeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("pessoa");
                });

            modelBuilder.Entity("api.Model.Domain.PetShop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeAnimal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeResponsavel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SituacaoAnimal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("petshop");
                });

            modelBuilder.Entity("api.Model.Domain.Pessoa", b =>
                {
                    b.HasOne("api.Model.Domain.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId");

                    b.Navigation("Cidade");
                });
#pragma warning restore 612, 618
        }
    }
}
