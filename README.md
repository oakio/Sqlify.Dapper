# Welcome to SqlDsl.Dapper

[![Build status](https://ci.appveyor.com/api/projects/status/h5pw3uu6j1imitkp?svg=true)](https://ci.appveyor.com/project/oakio/sqldsl.Dapper)
[![Nuget Package](https://badgen.net/nuget/v/sqldsl)](https://www.nuget.org/packages/SqlDsl.Dapper)

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

    InsertSqlQuery query = Sql
        .Insert(u)
        .Values(u.Id, 1)
        .Values(u.Name, "Adam")
        .Values(u.Age, 30);

    connection.Execute(query); // Dapper's Execute method
}
```
## UPDATE query example
```csharp
public void UpdateExample(IDbConnection connection)
{
    var u = new UsersTable();

    UpdateSqlQuery query = Sql
        .Update(u)
        .Set(u.Age, u.Age + 1);

    connection.Execute(query); // Dapper's Execute methods
}
```
## SELECT query example
```csharp
public void SelectExample(IDbConnection connection)
{
    var u = new UsersTable();

    SelectSqlQuery query = Sql
        .Select()
        .From(u)
        .Where(u.Age > 30);

    connection.Query(query); // Dapper's Query method
}
```
## DELETE query example
```csharp
public void DeleteExample(IDbConnection connection)
{
    var u = new UsersTable();

    DeleteSqlQuery query = Sql
        .Delete(u)
        .Where(u.Id == 1);

    connection.Execute(query); // Dapper's Execute method
}
```

# How to build
```bash
# build
dotnet build ./src

# running tests
dotnet test ./src

# pack
dotnet pack ./src -c=release
```