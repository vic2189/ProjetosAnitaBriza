using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PortalProjetoAmor.Models;

namespace PortalProjetoAmor.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20170625034807_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PortalProjetoAmor.Model.Listas.Bairro", b =>
                {
                    b.Property<int>("IDBairro")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IDCidade");

                    b.Property<string>("NomeBairro");

                    b.HasKey("IDBairro");

                    b.ToTable("TB_Bairro");
                });

            modelBuilder.Entity("PortalProjetoAmor.Model.Listas.Cidade", b =>
                {
                    b.Property<int>("IDCidade")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IDEstado");

                    b.Property<string>("NomeCidade");

                    b.HasKey("IDCidade");

                    b.ToTable("TB_Cidade");
                });

            modelBuilder.Entity("PortalProjetoAmor.Model.Listas.Estado", b =>
                {
                    b.Property<int>("IDEstado")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IDPais");

                    b.Property<string>("NomeEstado");

                    b.HasKey("IDEstado");

                    b.ToTable("TB_Estado");
                });

            modelBuilder.Entity("PortalProjetoAmor.Model.Listas.EstadoCivil", b =>
                {
                    b.Property<int>("IDEstatoCivil")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeEstadoCivil");

                    b.HasKey("IDEstatoCivil");

                    b.ToTable("TB_EstadoCivil");
                });

            modelBuilder.Entity("PortalProjetoAmor.Model.Listas.Pais", b =>
                {
                    b.Property<int>("IDPais")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomePais");

                    b.HasKey("IDPais");

                    b.ToTable("TB_Pais");
                });

            modelBuilder.Entity("PortalProjetoAmor.Model.Listas.Parentesco", b =>
                {
                    b.Property<int>("IDParentesco")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TipoDeParentesco");

                    b.HasKey("IDParentesco");

                    b.ToTable("TB_Parentesco");
                });

            modelBuilder.Entity("PortalProjetoAmor.Model.Listas.TipoDocumento", b =>
                {
                    b.Property<int>("IDTipoDocumento")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeTipoDocumento");

                    b.HasKey("IDTipoDocumento");

                    b.ToTable("TB_TipoDocumento");
                });

            modelBuilder.Entity("PortalProjetoAmor.Model.Listas.TipoDoenca", b =>
                {
                    b.Property<int>("IDTipoDoenca")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeTipoDoenca");

                    b.HasKey("IDTipoDoenca");

                    b.ToTable("TB_TipoDoenca");
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Assistido", b =>
                {
                    b.Property<int>("IDAssistido")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cidade");

                    b.Property<bool>("ConviveComFilhos");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int?>("EnderecoIDEndereco");

                    b.Property<string>("Escolaridade");

                    b.Property<string>("Estado");

                    b.Property<string>("EstadoCivil");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Pais");

                    b.Property<int>("SaldoBonus");

                    b.Property<bool>("TemCurso");

                    b.Property<bool>("TemFamiliaEmSP");

                    b.Property<bool>("TemFilhos");

                    b.Property<string>("TratamentoMedico");

                    b.Property<DateTime>("UltimaVisitaMedico");

                    b.HasKey("IDAssistido");

                    b.HasIndex("EnderecoIDEndereco");

                    b.ToTable("TB_Assistido");
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Atendimento", b =>
                {
                    b.Property<int>("IDAtendimento")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAtendimento");

                    b.Property<int>("IDAssistido");

                    b.Property<int>("QuantidadeBlusas");

                    b.Property<int>("QuantidadeBoneChapeu");

                    b.Property<int>("QuantidadeCalcas");

                    b.Property<int>("QuantidadeCamisas");

                    b.Property<int>("QuantidadeChinelo");

                    b.Property<int>("QuantidadeCinto");

                    b.Property<int>("QuantidadeParDeMeias");

                    b.Property<int>("QuantidadeRoupaIntima");

                    b.Property<int>("QuantidadeSapatoTenis");

                    b.Property<int>("QuantidadeShorts");

                    b.HasKey("IDAtendimento");

                    b.HasIndex("IDAssistido");

                    b.ToTable("TB_Atendimento");
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Curso", b =>
                {
                    b.Property<int>("IDCurso")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("EstaCursando");

                    b.Property<bool>("FinalizouCurso");

                    b.Property<int>("IDAssistido");

                    b.Property<string>("Instituicao");

                    b.Property<string>("MesAnoFim");

                    b.Property<string>("MesAnoInicio");

                    b.Property<string>("NomeCurso")
                        .IsRequired();

                    b.Property<string>("Observacao");

                    b.HasKey("IDCurso");

                    b.HasIndex("IDAssistido");

                    b.ToTable("TB_Curso");
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Documento", b =>
                {
                    b.Property<int>("IDDocumento")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IDAssistido");

                    b.Property<string>("IdentificacaoDocumento")
                        .IsRequired();

                    b.Property<string>("TipoDocumento")
                        .IsRequired();

                    b.HasKey("IDDocumento");

                    b.HasIndex("IDAssistido");

                    b.ToTable("TB_Documento");
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Doenca", b =>
                {
                    b.Property<int>("IDDoenca")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataFinal");

                    b.Property<DateTime>("DataInicial");

                    b.Property<int>("IDAssistido");

                    b.Property<int>("IDTipoDoenca");

                    b.Property<string>("Observacao");

                    b.HasKey("IDDoenca");

                    b.HasIndex("IDAssistido");

                    b.ToTable("TB_Doenca");
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Endereco", b =>
                {
                    b.Property<int>("IDEndereco")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cidade");

                    b.Property<string>("Logradouro");

                    b.HasKey("IDEndereco");

                    b.ToTable("TB_Endereco");
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Familia", b =>
                {
                    b.Property<int>("IDFamilia")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ContatoComParente");

                    b.Property<int?>("Endereco");

                    b.Property<int>("IDAssistido");

                    b.Property<int>("IDEndereco");

                    b.Property<string>("Observacao");

                    b.Property<int?>("Parentesco");

                    b.HasKey("IDFamilia");

                    b.HasIndex("Endereco");

                    b.HasIndex("IDAssistido")
                        .IsUnique();

                    b.HasIndex("Parentesco");

                    b.ToTable("TB_Familia");
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.ObjetivoAtendimento", b =>
                {
                    b.Property<int>("IDAssistido")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssistidoIDAssistido");

                    b.Property<string>("Objetivo");

                    b.HasKey("IDAssistido");

                    b.HasIndex("AssistidoIDAssistido");

                    b.ToTable("TB_ObjetivoAtendimento");
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Assistido", b =>
                {
                    b.HasOne("PortalProjetoAmor.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoIDEndereco");
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Atendimento", b =>
                {
                    b.HasOne("PortalProjetoAmor.Models.Assistido")
                        .WithMany("Atendimentos")
                        .HasForeignKey("IDAssistido")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Curso", b =>
                {
                    b.HasOne("PortalProjetoAmor.Models.Assistido")
                        .WithMany("Cursos")
                        .HasForeignKey("IDAssistido")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Documento", b =>
                {
                    b.HasOne("PortalProjetoAmor.Models.Assistido")
                        .WithMany("Documentos")
                        .HasForeignKey("IDAssistido")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Doenca", b =>
                {
                    b.HasOne("PortalProjetoAmor.Models.Assistido")
                        .WithMany("Doencas")
                        .HasForeignKey("IDAssistido")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.Familia", b =>
                {
                    b.HasOne("PortalProjetoAmor.Models.Endereco", "EnderecoParente")
                        .WithMany()
                        .HasForeignKey("Endereco");

                    b.HasOne("PortalProjetoAmor.Models.Assistido")
                        .WithOne("InformacoesFamiliares")
                        .HasForeignKey("PortalProjetoAmor.Models.Familia", "IDAssistido")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PortalProjetoAmor.Model.Listas.Parentesco", "IDParentesco")
                        .WithMany()
                        .HasForeignKey("Parentesco");
                });

            modelBuilder.Entity("PortalProjetoAmor.Models.ObjetivoAtendimento", b =>
                {
                    b.HasOne("PortalProjetoAmor.Models.Assistido")
                        .WithMany("Objetivos")
                        .HasForeignKey("AssistidoIDAssistido");
                });
        }
    }
}
