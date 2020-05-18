using System;
using System.Collections.Generic;
using System.Text;

namespace LinksChecker.Data.Access.DAL
{
    public interface IUnitOfWork
    {
         Task<T> QueryAsync<T>(IAsyncQuery<T> query, CancellationToken cancellationToken = default);
        Task ExecuteAsync(IAsyncCommand command, CancellationToken cancellationToken = default);
        Task<T> ExecuteAsync<T>(IAsyncCommand<T> command, CancellationToken cancellation = default);
        void Commit();
        void Rollback();
    }
}
