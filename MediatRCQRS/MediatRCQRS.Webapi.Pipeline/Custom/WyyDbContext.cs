﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRCQRS.Webapi.Pipeline.Custom
{
    //public class WyyDbContext : testContext
    //{
    //    private IDbContextTransaction _currentTransaction;

    //    public IDbContextTransaction GetCurrentTransaction() => _currentTransaction;
    //    public bool HasActiveTransaction => _currentTransaction != null;

    //    public async Task CommitTransactionAsync(IDbContextTransaction transaction)
    //    {
    //        if (transaction == null) throw new ArgumentNullException(nameof(transaction));
    //        if (transaction != _currentTransaction) throw new InvalidOperationException($"Transaction {transaction.TransactionId} is not current");
    //        try
    //        {
    //            await SaveChangesAsync();
    //            transaction.Commit();
    //        }
    //        catch
    //        {
    //            RollbackTransaction();
    //            throw;
    //        }
    //        finally
    //        {
    //            if (_currentTransaction != null)
    //            {
    //                _currentTransaction.Dispose();
    //                _currentTransaction = null;
    //            }
    //        }
    //    }
    //    public void RollbackTransaction()
    //    {
    //        try
    //        {
    //            _currentTransaction?.Rollback();
    //        }
    //        finally
    //        {
    //            if (_currentTransaction != null)
    //            {
    //                _currentTransaction.Dispose();
    //                _currentTransaction = null;
    //            }
    //        }
    //    }
    //}
}
