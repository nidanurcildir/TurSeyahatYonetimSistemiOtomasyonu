namespace CSharpEgitimKampi301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration  // DbMigration'dan miras alır.
    {
        public override void Up()  // Eğer update yaparsan
        {
            AddColumn("dbo.Customers", "CustomerStatus", c => c.Boolean(nullable: false));  // Customers tablonun içerisine CustomerStatus adında bir sütun ekleyeceğim bu sütun bool ve boş geçilemez olacak.
        }
        
        public override void Down()  // Eğer işlemi geri almak istersen yani bu migration'dan vazgeçersen 
        {
            DropColumn("dbo.Customers", "CustomerStatus");  // O zaman ben yapılan bu değişiklikleri geri alacağım.
        }
    }
}
