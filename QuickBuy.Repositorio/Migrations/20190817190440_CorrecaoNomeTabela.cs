using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repositorio.Migrations
{
    public partial class CorrecaoNomeTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensPedidos_Peditos_PedidoId",
                table: "ItensPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Peditos_FormaPagamento_FormaPagamentoId",
                table: "Peditos");

            migrationBuilder.DropForeignKey(
                name: "FK_Peditos_Usuarios_UsuarioId",
                table: "Peditos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peditos",
                table: "Peditos");

            migrationBuilder.RenameTable(
                name: "Peditos",
                newName: "Pedidos");

            migrationBuilder.RenameIndex(
                name: "IX_Peditos_UsuarioId",
                table: "Pedidos",
                newName: "IX_Pedidos_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Peditos_FormaPagamentoId",
                table: "Pedidos",
                newName: "IX_Pedidos_FormaPagamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensPedidos_Pedidos_PedidoId",
                table: "ItensPedidos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_FormaPagamento_FormaPagamentoId",
                table: "Pedidos",
                column: "FormaPagamentoId",
                principalTable: "FormaPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuarios_UsuarioId",
                table: "Pedidos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensPedidos_Pedidos_PedidoId",
                table: "ItensPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_FormaPagamento_FormaPagamentoId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuarios_UsuarioId",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos");

            migrationBuilder.RenameTable(
                name: "Pedidos",
                newName: "Peditos");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_UsuarioId",
                table: "Peditos",
                newName: "IX_Peditos_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_FormaPagamentoId",
                table: "Peditos",
                newName: "IX_Peditos_FormaPagamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peditos",
                table: "Peditos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensPedidos_Peditos_PedidoId",
                table: "ItensPedidos",
                column: "PedidoId",
                principalTable: "Peditos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Peditos_FormaPagamento_FormaPagamentoId",
                table: "Peditos",
                column: "FormaPagamentoId",
                principalTable: "FormaPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Peditos_Usuarios_UsuarioId",
                table: "Peditos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
