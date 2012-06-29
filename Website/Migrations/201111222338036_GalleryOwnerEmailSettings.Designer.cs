namespace NuGetGallery.Migrations.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class GalleryOwnerEmailSettings : IDbMigrationMetadata
    {
        string IDbMigrationMetadata.Id
        {
            get { return "201111222338036_GalleryOwnerEmailSettings"; }
        }
        
        string IDbMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IDbMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}
