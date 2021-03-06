// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteAPI.Infra;

namespace TesteAPI.Infra.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20220403054852_CriandoClasses")]
    partial class CriandoClasses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteAPI.Domain.Entities.Desenvolvedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hobby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<Guid?>("NivelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NivelId");

                    b.ToTable("Desenvolvedores");
                });

            modelBuilder.Entity("TesteAPI.Domain.Entities.Nivel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Niveis");
                });

            modelBuilder.Entity("TesteAPI.Domain.Entities.Desenvolvedor", b =>
                {
                    b.HasOne("TesteAPI.Domain.Entities.Nivel", "Nivel")
                        .WithMany()
                        .HasForeignKey("NivelId");

                    b.Navigation("Nivel");
                });
#pragma warning restore 612, 618
        }
    }
}
