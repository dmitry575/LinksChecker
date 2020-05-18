using System;
using System.Collections.Generic;
using System.Text;

namespace LinksChecker.Data.Access.DAL.Commad
{
    public interface ICommand
    {
        bool RequiresTransaction { get; }
        void Execute(IDbConnection connection, IDbTransaction transaction);
    }

    public interface ICommand<out T>
    {
        bool RequiresTransaction { get; }
        T Execute(IDbConnection connection, IDbTransaction transaction);
    }
}
