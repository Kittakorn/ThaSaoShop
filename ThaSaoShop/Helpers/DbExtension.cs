using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThaSaoShop.Models;

namespace ThaSaoShop.Helpers
{
    public static class DbExtension
    {
        public static void ResetContextState(this StoreEntities db)
        {
            db.ChangeTracker.Entries()
                .Where(e => e.Entity != null).ToList()
                .ForEach(e => e.State = EntityState.Detached);
        }
    }
}
