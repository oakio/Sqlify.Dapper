# SqlDsl.Dapper
[![Build status](https://ci.appveyor.com/api/projects/status/h5pw3uu6j1imitkp?svg=true)](https://ci.appveyor.com/project/oakio/sqldsl-dapper)
[![Nuget Package](https://badgen.net/nuget/v/sqldsl.dapper)](https://www.nuget.org/packages/SqlDsl.Dapper)

Fluent SQL builder for [`Dapper`](https://github.com/DapperLib/Dapper) library.

## How to use:
1. Install latest nuget packet [`SqlDsl.Dapper`](https://www.nuget.org/packages/SqlDsl.Dapper/) from [nuget.org](https://www.nuget.org/packages/SqlDsl.Dapper/):
    ```powershell
    Install-Package SqlDsl.Dapper
    ```
2. Create per database table:
    ```csharp
    public interface IUsersTable : ITable
    {
        Column<int> Id { get; }
        Column<string> Name { get; }
        Column<int> Age { get; }
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
    var u = Sql.Table<IUsersTable>();

    InsertQuery query = Sql
        .Insert(u)
        .Values(u.Id, 1)
        .Values(u.Name, "Adam")
        .Values(u.Age, 30);

    // INSERT INTO Users (Id, Name, Age) VALUES (@p1, @p2, @p3)    
    var result = connection.Execute(query); // Dapper's Execute method
}
```
[up &#8593;](#how-to-use)
## UPDATE query example
```csharp
public void UpdateExample(IDbConnection connection)
{
    var u = Sql.Table<IUsersTable>();

    UpdateQuery query = Sql
        .Update(u)
        .Set(u.Age, u.Age + 1);

    // UPDATE Users SET Age = Users.Age + @p1
    var result = connection.Execute(query); // Dapper's Execute methods
}
```
[up &#8593;](#how-to-use)
## SELECT query example
```csharp
public void SelectExample(IDbConnection connection)
{
    var u = Sql.Table<IUsersTable>();

    SelectQuery query = Sql
        .Select()
        .From(u)
        .Where(u.Age > 30);

    // SELECT * FROM Users WHERE Users.Age > @p1
    var result = connection.Query(query); // Dapper's Query method
}
```
[up &#8593;](#how-to-use)
## DELETE query example
```csharp
public void DeleteExample(IDbConnection connection)
{
    var u = Sql.Table<IUsersTable>();

    DeleteQuery query = Sql
        .Delete(u)
        .Where(u.Id == 1);

    // DELETE FROM Users WHERE Users.Id = @p1
    var result = connection.Execute(query); // Dapper's Execute method
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