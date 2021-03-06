using System.Data;
using Sqlify.Core;
using Sqlify.Core.Expressions;

namespace Sqlify.Dapper.Tests
{
    public class Examples
    {
        public void InsertExample(IDbConnection connection)
        {
            var u = Sql.Table<IUsersTable>();

            InsertQuery query = Sql
                .Insert(u)
                .Values(u.Id, 1)
                .Values(u.Name, "Adam")
                .Values(u.Age, 30);

            var result = connection.Execute(query); // Dapper's Execute* methods
        }

        public void UpdateExample(IDbConnection connection)
        {
            var u = Sql.Table<IUsersTable>();

            UpdateQuery query = Sql
                .Update(u)
                .Set(u.Age, u.Age + 1);

            var result = connection.Execute(query); // Dapper's Execute* methods
        }

        public void SelectExample(IDbConnection connection)
        {
            var u = Sql.Table<IUsersTable>();

            SelectQuery query = Sql
                .Select()
                .From(u)
                .Where(u.Age > 30);

            var result = connection.Query(query); // Dapper's Query* methods
        }

        public void DeleteExample(IDbConnection connection)
        {
            var u = Sql.Table<IUsersTable>();

            DeleteQuery query = Sql
                .Delete(u)
                .Where(u.Id == 1);

            var result = connection.Execute(query); // Dapper's Execute* methods
        }

        public interface IUsersTable : ITable
        {
            Column<int> Id { get; }

            Column<string> Name { get; }

            Column<int> Age { get; }
        }
    }
}