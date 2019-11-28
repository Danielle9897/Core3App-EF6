using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Core3App_EF6.Model
{
    public class EntitiesConfiguration : DbConfiguration
    {
        // todo: is this class needed ?
        
        public EntitiesConfiguration()
        {
            SetDatabaseInitializer<Entities>(null);
            SetManifestTokenResolver(new MyManifestTokenResolver());
        }

        public class MyManifestTokenResolver : IManifestTokenResolver
        {
            public string ResolveManifestToken(DbConnection connection)
            {
                return "2012";
            }
        }
    }
}