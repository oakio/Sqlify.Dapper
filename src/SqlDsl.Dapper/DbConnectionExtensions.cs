using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using SqlDsl.Core;

namespace SqlDsl.Dapper
{
    public static class DbConnectionExtensions
    {
        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(this IDbConnection cnn, ISqlQuery query, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.Query(sql.GetCommand(), map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this IDbConnection cnn, ISqlQuery query, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.Query(sql.GetCommand(), map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this IDbConnection cnn, ISqlQuery query, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.Query(sql.GetCommand(), map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this IDbConnection cnn, ISqlQuery query, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.Query(sql.GetCommand(), map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static IEnumerable<TReturn> Query<TReturn>(this IDbConnection cnn, ISqlQuery query, Type[] types, Func<Object[], TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.Query(sql.GetCommand(), types, map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static int Execute(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.Execute(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static object ExecuteScalar(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.ExecuteScalar(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static T ExecuteScalar<T>(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.ExecuteScalar<T>(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static IDataReader ExecuteReader(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.ExecuteReader(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static IEnumerable<dynamic> Query(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.Query(sql.GetCommand(), sql.GetParameters(), transaction, buffered, commandTimeout, CommandType.Text);
        }
        public static dynamic QueryFirst(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryFirst(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static dynamic QueryFirstOrDefault(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryFirstOrDefault(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static dynamic QuerySingle(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QuerySingle(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static dynamic QuerySingleOrDefault(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QuerySingleOrDefault(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static IEnumerable<T> Query<T>(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.Query<T>(sql.GetCommand(), sql.GetParameters(), transaction, buffered, commandTimeout, CommandType.Text);
        }
        public static T QueryFirst<T>(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryFirst<T>(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static T QueryFirstOrDefault<T>(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryFirstOrDefault<T>(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static T QuerySingle<T>(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QuerySingle<T>(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static T QuerySingleOrDefault<T>(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QuerySingleOrDefault<T>(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static IEnumerable<object> Query(this IDbConnection cnn, Type type, ISqlQuery query, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.Query(type, sql.GetCommand(), sql.GetParameters(), transaction, buffered, commandTimeout, CommandType.Text);
        }
        public static object QueryFirst(this IDbConnection cnn, Type type, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryFirst(type, sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static object QueryFirstOrDefault(this IDbConnection cnn, Type type, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryFirstOrDefault(type, sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static object QuerySingle(this IDbConnection cnn, Type type, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QuerySingle(type, sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static object QuerySingleOrDefault(this IDbConnection cnn, Type type, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QuerySingleOrDefault(type, sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static SqlMapper.GridReader QueryMultiple(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryMultiple(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(this IDbConnection cnn, ISqlQuery query, Func<TFirst, TSecond, TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.Query(sql.GetCommand(), map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(this IDbConnection cnn, ISqlQuery query, Func<TFirst, TSecond, TThird, TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.Query(sql.GetCommand(), map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static Task<IEnumerable<dynamic>> QueryAsync(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryAsync(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<IEnumerable<T>> QueryAsync<T>(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryAsync<T>(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<T> QueryFirstAsync<T>(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryFirstAsync<T>(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<T> QueryFirstOrDefaultAsync<T>(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryFirstOrDefaultAsync<T>(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<T> QuerySingleAsync<T>(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QuerySingleAsync<T>(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<T> QuerySingleOrDefaultAsync<T>(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QuerySingleOrDefaultAsync<T>(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<dynamic> QueryFirstAsync(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryFirstAsync(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<dynamic> QueryFirstOrDefaultAsync(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryFirstOrDefaultAsync(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<dynamic> QuerySingleAsync(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QuerySingleAsync(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<dynamic> QuerySingleOrDefaultAsync(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QuerySingleOrDefaultAsync(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<IEnumerable<object>> QueryAsync(this IDbConnection cnn, Type type, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryAsync(type, sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<object> QueryFirstAsync(this IDbConnection cnn, Type type, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryFirstAsync(type, sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<object> QueryFirstOrDefaultAsync(this IDbConnection cnn, Type type, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryFirstOrDefaultAsync(type, sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<object> QuerySingleAsync(this IDbConnection cnn, Type type, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QuerySingleAsync(type, sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<object> QuerySingleOrDefaultAsync(this IDbConnection cnn, Type type, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QuerySingleOrDefaultAsync(type, sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<int> ExecuteAsync(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.ExecuteAsync(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(this IDbConnection cnn, ISqlQuery query, Func<TFirst, TSecond, TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryAsync(sql.GetCommand(), map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(this IDbConnection cnn, ISqlQuery query, Func<TFirst, TSecond, TThird, TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryAsync(sql.GetCommand(), map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(this IDbConnection cnn, ISqlQuery query, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryAsync(sql.GetCommand(), map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this IDbConnection cnn, ISqlQuery query, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryAsync(sql.GetCommand(), map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this IDbConnection cnn, ISqlQuery query, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryAsync(sql.GetCommand(), map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this IDbConnection cnn, ISqlQuery query, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryAsync(sql.GetCommand(), map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static Task<IEnumerable<TReturn>> QueryAsync<TReturn>(this IDbConnection cnn, ISqlQuery query, Type[] types, Func<Object[], TReturn> map, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryAsync<TReturn>(sql.GetCommand(), types, map, sql.GetParameters(), transaction, buffered, splitOn, commandTimeout, CommandType.Text);
        }
        public static Task<SqlMapper.GridReader> QueryMultipleAsync(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.QueryMultipleAsync(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<IDataReader> ExecuteReaderAsync(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.ExecuteReaderAsync(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<object> ExecuteScalarAsync(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.ExecuteScalarAsync(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
        public static Task<T> ExecuteScalarAsync<T>(this IDbConnection cnn, ISqlQuery query, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            var sql = new DapperSqlWriter();
            query.Format(sql);
            return cnn.ExecuteScalarAsync<T>(sql.GetCommand(), sql.GetParameters(), transaction, commandTimeout, CommandType.Text);
        }
    }
}