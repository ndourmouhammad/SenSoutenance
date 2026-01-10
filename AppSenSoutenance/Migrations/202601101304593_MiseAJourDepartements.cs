namespace AppSenSoutenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MiseAJourDepartements : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Utilisateurs", "IdDepartement", "dbo.Departements");
            AddColumn("dbo.Departements", "LibelleDepartement", c => c.String(nullable: false, maxLength: 80, storeType: "nvarchar"));
            AddColumn("dbo.Departements", "Code", c => c.String(unicode: false));
            AddForeignKey("dbo.Utilisateurs", "IdDepartement", "dbo.Departements", "IdDepartement");
            DropColumn("dbo.Departements", "NomDepartement");
            DropColumn("dbo.Departements", "CodeDepartement");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departements", "CodeDepartement", c => c.String(nullable: false, maxLength: 80, storeType: "nvarchar"));
            AddColumn("dbo.Departements", "NomDepartement", c => c.String(nullable: false, maxLength: 80, storeType: "nvarchar"));
            DropForeignKey("dbo.Utilisateurs", "IdDepartement", "dbo.Departements");
            DropColumn("dbo.Departements", "Code");
            DropColumn("dbo.Departements", "LibelleDepartement");
            AddForeignKey("dbo.Utilisateurs", "IdDepartement", "dbo.Departements", "IdDepartement", cascadeDelete: true);
        }
    }
}
