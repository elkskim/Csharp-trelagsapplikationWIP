using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayer.Database
{
    public class EtityFrameworkSQLServerImporter
    {
        // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
        // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
        // Make sure the provider assembly is available to the running application. 
        // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
        System.Data.Entity.SqlServer.SqlProviderServices instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
    }
}
