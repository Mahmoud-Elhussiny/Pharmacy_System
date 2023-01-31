using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Application.Contract
{
    public sealed class TransactionDealerRepository: IDisposable
    {
        private readonly IDbContextTransaction _transaction;

        private bool _isCompleted = false;

        public TransactionDealerRepository(IDatabaseService realDbContext)
        {
            _transaction = realDbContext.DbBeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void SetComplete()
        {
            _isCompleted = true;
        }

        public void Dispose()
        {
            if (!_isCompleted)
            {
                _transaction.Rollback();
            }
            else
            {
                _transaction.Commit();
            }
        }
    }
}
