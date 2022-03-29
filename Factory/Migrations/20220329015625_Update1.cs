using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Engineers_EngineerId",
                table: "EngineerMachine");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Machines_MachineId",
                table: "EngineerMachine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EngineerMachine",
                table: "EngineerMachine");

            migrationBuilder.RenameTable(
                name: "EngineerMachine",
                newName: "EngineersMachines");

            migrationBuilder.RenameIndex(
                name: "IX_EngineerMachine_MachineId",
                table: "EngineersMachines",
                newName: "IX_EngineersMachines_MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_EngineerMachine_EngineerId",
                table: "EngineersMachines",
                newName: "IX_EngineersMachines_EngineerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EngineersMachines",
                table: "EngineersMachines",
                column: "EngineerMachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineersMachines_Engineers_EngineerId",
                table: "EngineersMachines",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EngineersMachines_Machines_MachineId",
                table: "EngineersMachines",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineersMachines_Engineers_EngineerId",
                table: "EngineersMachines");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineersMachines_Machines_MachineId",
                table: "EngineersMachines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EngineersMachines",
                table: "EngineersMachines");

            migrationBuilder.RenameTable(
                name: "EngineersMachines",
                newName: "EngineerMachine");

            migrationBuilder.RenameIndex(
                name: "IX_EngineersMachines_MachineId",
                table: "EngineerMachine",
                newName: "IX_EngineerMachine_MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_EngineersMachines_EngineerId",
                table: "EngineerMachine",
                newName: "IX_EngineerMachine_EngineerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EngineerMachine",
                table: "EngineerMachine",
                column: "EngineerMachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Engineers_EngineerId",
                table: "EngineerMachine",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Machines_MachineId",
                table: "EngineerMachine",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
