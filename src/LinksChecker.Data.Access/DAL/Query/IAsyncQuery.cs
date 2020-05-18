using System;
using System.Collections.Generic;
using System.Text;

namespace LinksChecker.Data.Access.DAL.Query
{
    public interface IAsyncQuery<T>
    {
        Task<T> ExecuteAsync(IDbConnection connection, IDbTransaction transaction, CancellationToken cancellationToken = default);
    }
}
