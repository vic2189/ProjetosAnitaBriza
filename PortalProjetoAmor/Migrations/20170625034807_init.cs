using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PortalProjetoAmor.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Bairro",
                columns: table => new
                {
                    IDBairro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDCidade = table.Column<int>(nullable: false),
                    NomeBairro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Bairro", x => x.IDBairro);
                });

            migrationBuilder.CreateTable(
                name: "TB_Cidade",
                columns: table => new
                {
                    IDCidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDEstado = table.Column<int>(nullable: false),
                    NomeCidade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Cidade", x => x.IDCidade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Estado",
                columns: table => new
                {
                    IDEstado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDPais = table.Column<int>(nullable: false),
                    NomeEstado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Estado", x => x.IDEstado);
                });

            migrationBuilder.CreateTable(
                name: "TB_EstadoCivil",
                columns: table => new
                {
                    IDEstatoCivil = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeEstadoCivil = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_EstadoCivil", x => x.IDEstatoCivil);
                });

            migrationBuilder.CreateTable(
                name: "TB_Pais",
                columns: table => new
                {
                    IDPais = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomePais = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Pais", x => x.IDPais);
                });

            migrationBuilder.CreateTable(
                name: "TB_Parentesco",
                columns: table => new
                {
                    IDParentesco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoDeParentesco = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Parentesco", x => x.IDParentesco);
                });

            migrationBuilder.CreateTable(
                name: "TB_TipoDocumento",
                columns: table => new
                {
                    IDTipoDocumento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeTipoDocumento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TipoDocumento", x => x.IDTipoDocumento);
                });

            migrationBuilder.CreateTable(
                name: "TB_TipoDoenca",
                columns: table => new
                {
                    IDTipoDoenca = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeTipoDoenca = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TipoDoenca", x => x.IDTipoDoenca);
                });

            migrationBuilder.CreateTable(
                name: "TB_Endereco",
                columns: table => new
                {
                    IDEndereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Endereco", x => x.IDEndereco);
                });

            migrationBuilder.CreateTable(
                name: "TB_Assistido",
                columns: table => new
                {
                    IDAssistido = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cidade = table.Column<string>(nullable: true),
                    ConviveComFilhos = table.Column<bool>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    EnderecoIDEndereco = table.Column<int>(nullable: true),
                    Escolaridade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(maxLength: 200, nullable: false),
                    Pais = table.Column<string>(nullable: true),
                    SaldoBonus = table.Column<int>(nullable: false),
                    TemCurso = table.Column<bool>(nullable: false),
                    TemFamiliaEmSP = table.Column<bool>(nullable: false),
                    TemFilhos = table.Column<bool>(nullable: false),
                    TratamentoMedico = table.Column<string>(nullable: true),
                    UltimaVisitaMedico = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Assistido", x => x.IDAssistido);
                    table.ForeignKey(
                        name: "FK_TB_Assistido_TB_Endereco_EnderecoIDEndereco",
                        column: x => x.EnderecoIDEndereco,
                        principalTable: "TB_Endereco",
                        principalColumn: "IDEndereco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_Atendimento",
                columns: table => new
                {
                    IDAtendimento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataAtendimento = table.Column<DateTime>(nullable: false),
                    IDAssistido = table.Column<int>(nullable: false),
                    QuantidadeBlusas = table.Column<int>(nullable: false),
                    QuantidadeBoneChapeu = table.Column<int>(nullable: false),
                    QuantidadeCalcas = table.Column<int>(nullable: false),
                    QuantidadeCamisas = table.Column<int>(nullable: false),
                    QuantidadeChinelo = table.Column<int>(nullable: false),
                    QuantidadeCinto = table.Column<int>(nullable: false),
                    QuantidadeParDeMeias = table.Column<int>(nullable: false),
                    QuantidadeRoupaIntima = table.Column<int>(nullable: false),
                    QuantidadeSapatoTenis = table.Column<int>(nullable: false),
                    QuantidadeShorts = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Atendimento", x => x.IDAtendimento);
                    table.ForeignKey(
                        name: "FK_TB_Atendimento_TB_Assistido_IDAssistido",
                        column: x => x.IDAssistido,
                        principalTable: "TB_Assistido",
                        principalColumn: "IDAssistido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Curso",
                columns: table => new
                {
                    IDCurso = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EstaCursando = table.Column<bool>(nullable: false),
                    FinalizouCurso = table.Column<bool>(nullable: false),
                    IDAssistido = table.Column<int>(nullable: false),
                    Instituicao = table.Column<string>(nullable: true),
                    MesAnoFim = table.Column<string>(nullable: true),
                    MesAnoInicio = table.Column<string>(nullable: true),
                    NomeCurso = table.Column<string>(nullable: false),
                    Observacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Curso", x => x.IDCurso);
                    table.ForeignKey(
                        name: "FK_TB_Curso_TB_Assistido_IDAssistido",
                        column: x => x.IDAssistido,
                        principalTable: "TB_Assistido",
                        principalColumn: "IDAssistido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Documento",
                columns: table => new
                {
                    IDDocumento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDAssistido = table.Column<int>(nullable: false),
                    IdentificacaoDocumento = table.Column<string>(nullable: false),
                    TipoDocumento = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Documento", x => x.IDDocumento);
                    table.ForeignKey(
                        name: "FK_TB_Documento_TB_Assistido_IDAssistido",
                        column: x => x.IDAssistido,
                        principalTable: "TB_Assistido",
                        principalColumn: "IDAssistido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Doenca",
                columns: table => new
                {
                    IDDoenca = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataFinal = table.Column<DateTime>(nullable: false),
                    DataInicial = table.Column<DateTime>(nullable: false),
                    IDAssistido = table.Column<int>(nullable: false),
                    IDTipoDoenca = table.Column<int>(nullable: false),
                    Observacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Doenca", x => x.IDDoenca);
                    table.ForeignKey(
                        name: "FK_TB_Doenca_TB_Assistido_IDAssistido",
                        column: x => x.IDAssistido,
                        principalTable: "TB_Assistido",
                        principalColumn: "IDAssistido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_Familia",
                columns: table => new
                {
                    IDFamilia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContatoComParente = table.Column<bool>(nullable: false),
                    Endereco = table.Column<int>(nullable: true),
                    IDAssistido = table.Column<int>(nullable: false),
                    IDEndereco = table.Column<int>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    Parentesco = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Familia", x => x.IDFamilia);
                    table.ForeignKey(
                        name: "FK_TB_Familia_TB_Endereco_Endereco",
                        column: x => x.Endereco,
                        principalTable: "TB_Endereco",
                        principalColumn: "IDEndereco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_Familia_TB_Assistido_IDAssistido",
                        column: x => x.IDAssistido,
                        principalTable: "TB_Assistido",
                        principalColumn: "IDAssistido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_Familia_TB_Parentesco_Parentesco",
                        column: x => x.Parentesco,
                        principalTable: "TB_Parentesco",
                        principalColumn: "IDParentesco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_ObjetivoAtendimento",
                columns: table => new
                {
                    IDAssistido = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssistidoIDAssistido = table.Column<int>(nullable: true),
                    Objetivo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ObjetivoAtendimento", x => x.IDAssistido);
                    table.ForeignKey(
                        name: "FK_TB_ObjetivoAtendimento_TB_Assistido_AssistidoIDAssistido",
                        column: x => x.AssistidoIDAssistido,
                        principalTable: "TB_Assistido",
                        principalColumn: "IDAssistido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Assistido_EnderecoIDEndereco",
                table: "TB_Assistido",
                column: "EnderecoIDEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Atendimento_IDAssistido",
                table: "TB_Atendimento",
                column: "IDAssistido");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Curso_IDAssistido",
                table: "TB_Curso",
                column: "IDAssistido");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Documento_IDAssistido",
                table: "TB_Documento",
                column: "IDAssistido");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Doenca_IDAssistido",
                table: "TB_Doenca",
                column: "IDAssistido");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Familia_Endereco",
                table: "TB_Familia",
                column: "Endereco");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Familia_IDAssistido",
                table: "TB_Familia",
                column: "IDAssistido",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_Familia_Parentesco",
                table: "TB_Familia",
                column: "Parentesco");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ObjetivoAtendimento_AssistidoIDAssistido",
                table: "TB_ObjetivoAtendimento",
                column: "AssistidoIDAssistido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Bairro");

            migrationBuilder.DropTable(
                name: "TB_Cidade");

            migrationBuilder.DropTable(
                name: "TB_Estado");

            migrationBuilder.DropTable(
                name: "TB_EstadoCivil");

            migrationBuilder.DropTable(
                name: "TB_Pais");

            migrationBuilder.DropTable(
                name: "TB_TipoDocumento");

            migrationBuilder.DropTable(
                name: "TB_TipoDoenca");

            migrationBuilder.DropTable(
                name: "TB_Atendimento");

            migrationBuilder.DropTable(
                name: "TB_Curso");

            migrationBuilder.DropTable(
                name: "TB_Documento");

            migrationBuilder.DropTable(
                name: "TB_Doenca");

            migrationBuilder.DropTable(
                name: "TB_Familia");

            migrationBuilder.DropTable(
                name: "TB_ObjetivoAtendimento");

            migrationBuilder.DropTable(
                name: "TB_Parentesco");

            migrationBuilder.DropTable(
                name: "TB_Assistido");

            migrationBuilder.DropTable(
                name: "TB_Endereco");
        }
    }
}
