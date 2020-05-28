using System;
using System.Collections.Generic;
using System.Text;

namespace LinksChecker.Data.Access.DAL.Query
{
    public interface IQuery<out T>
    {
        T Execute(IDbConnection connection, IDbTransaction transaction);
    }
}
