namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChinhSuaDB2506_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DatPhong", "TinhTrangThanhToan", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DatPhong", "TinhTrangThanhToan");
        }
    }
}
