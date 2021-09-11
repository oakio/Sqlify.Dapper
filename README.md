# Welcome to SqlDsl.Dapper

[![Build status](https://ci.appveyor.com/api/projects/status/h5pw3uu6j1imitkp?svg=true)](https://ci.appveyor.com/project/oakio/sqldsl-dapper)
[![Nuget Package](https://badgen.net/nuget/v/sqldsl.dapper)](https://www.nuget.org/packages/SqlDsl.Dapper)

# Intro
Fluent SQL builder for [`Dapper`](https://github.com/DapperLib/Dapper) library.

## How to use:
1. Install latest nuget packet [`SqlDsl.Dapper`](https://www.nuget.org/packages/SqlDsl.Dapper/) from [nuget.org](https://www.nuget.org/packages/SqlDsl.Dapper/):
    ```powershell
    Install-Package SqlDsl.Dapper
    ```
2. Create per database table a class inherited from `Table`:
    ```csharp
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
    ```
3. Write a query!
    * `INSERT` query [example](#insert-query-example)
    * `UPDATE` query [example](#update-query-example)
    * `SELECT` query [example](#select-query-example)
    * `DELETE` query [example](#delete-query-example)
    * More [examples](https://github.com/oakio/SqlDsl#examples)

## INSERT query example
```csharp
public void InsertExample(IDbConnection connection)
{
    var u = new UsersTable();

    InsertQuery query = Sql
        .Insert(u)
        .Values(u.Id, 1)
        .Values(u.Name, "Adam")
        .Values(u.Age, 30);

    // INSERT INTO users (id, name, age) VALUES (@p1, @p2, @p3)    
    connection.Execute(query); // Dapper's Execute method
}
```
[up &#8593;](#how-to-use)
## UPDATE query example
```csharp
public void UpdateExample(IDbConnection connection)
{
    var u = new UsersTable();

    UpdateSqlQuery query = Sql
        .Update(u)
        .Set(u.Age, u.Age + 1);

    // UPDATE users SET age = users.age + @p1
    connection.Execute(query); // Dapper's Execute methods
}
```
[up &#8593;](#how-to-use)
## SELECT query example
```csharp
public void SelectExample(IDbConnection connection)
{
    var u = new UsersTable();

    SelectSqlQuery query = Sql
        .Select()
        .From(u)
        .Where(u.Age > 30);

    // SELECT * FROM users WHERE users.age > @p1
    connection.Query(query); // Dapper's Query method
}
```
[up &#8593;](#how-to-use)
## DELETE query example
```csharp
public void DeleteExample(IDbConnection connection)
{
    var u = new UsersTable();

    DeleteSqlQuery query = Sql
        .Delete(u)
        .Where(u.Id == 1);

    // DELETE FROM users WHERE users.id = @p1
    connection.Execute(query); // Dapper's Execute method
}
```
[up &#8593;](#how-to-use)
# How to build
```bash
# build
dotnet build ./src

# running tests
dotnet test ./src

# pack
dotnet pack ./src -c=release
```