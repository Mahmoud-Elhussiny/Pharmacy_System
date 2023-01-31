using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Persistence.Context
{
    public partial class DatabaseService
    {



        public int DBSaveChanges()
        {
            return SaveChanges();
        }

        public async Task<int> DBSaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await SaveChangesAsync(acceptAllChangesOnSuccess: true, cancellationToken);
        }

        public IDbContextTransaction DbBeginTransaction(System.Data.IsolationLevel isolationLevel)
        {
            return this.Database.BeginTransaction(isolationLevel);
        }
    }
}
