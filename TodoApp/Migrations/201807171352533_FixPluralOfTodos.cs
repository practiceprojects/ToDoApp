namespace TodoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixPluralOfTodos : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Todoes", newName: "Todos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Todos", newName: "Todoes");
        }
    }
}
