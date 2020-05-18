using System;
using System.Collections.Generic;
using System.Text;

namespace LinksChecker.Data.Access.DAL.Commad
{
    public interface IAsyncCommand
    {
        bool RequiresTransaction { get; }
        Task ExecuteAsync(IDbConnection connection, IDbTransaction transaction, CancellationToken cancellationToken = default);
    }

    public interface IAsyncCommand<T>
    {
        bool RequiresTransaction { get; }
        Task<T> ExecuteAsync(IDbConnection connect, IDbTransaction transaction, CancellationToken cancellationToken = default);
    }
}
