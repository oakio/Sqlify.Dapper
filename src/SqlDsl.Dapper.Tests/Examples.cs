using System.Data;
using SqlDsl.Core.Expressions;

namespace SqlDsl.Dapper.Tests
{
    public class Examples
    {
        public void InsertExample(IDbConnection connection)
        {
            var u = new UsersTable();

            InsertQuery query = Sql
                .Insert(u)
                .Values(u.Id, 1)
                .Values(u.Name, "Adam")
                .Values(u.Age, 30);

            connection.Execute(query); // Dapper's Execute* methods
        }

        public void UpdateExample(IDbConnection connection)
        {
            var u = new UsersTable();

            UpdateQuery query = Sql
                .Update(u)
                .Set(u.Age, u.Age + 1);

            connection.Execute(query); // Dapper's Execute* methods
        }

        public void SelectExample(IDbConnection connection)
        {
            var u = new UsersTable();

            SelectQuery query = Sql
                .Select()
                .From(u)
                .Where(u.Age > 30);

            connection.Query(query); // Dapper's Query* methods
        }

        public void DeleteExample(IDbConnection connection)
        {
            var u = new UsersTable();

            DeleteQuery query = Sql
                .Delete(u)
                .Where(u.Id == 1);

            connection.Execute(query); // Dapper's Execute* methods
        }

        public class UsersTable : Table
        {
            public ColumnExpression<int> Id;
            public ColumnExpression<string> Name;
            public ColumnExpression<int> Age;

            public UsersTable(string alias = null) : base("users", alias)
            {
                Id = CreateColumn<int>("id");
                Name = CreateColumn<string>("name");
                Age = CreateColumn<int>("age");
            }
        }
    }
}