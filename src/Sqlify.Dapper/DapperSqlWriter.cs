using System.Text;
using Dapper;
using Sqlify.Core;

namespace Sqlify.Dapper
{
    public class DapperSqlWriter : ISqlWriter
    {
        private readonly StringBuilder _command;
        private ParamNameGenerator _generator;
        private DynamicParameters _parameters;

        public DapperSqlWriter()
        {
            _command = new StringBuilder();
            _generator = new ParamNameGenerator();
        }

        public void Append(string text) => _command.Append(text);

        public string AddParam<T>(T value)
        {
            if (_parameters == null)
            {
                _parameters = new DynamicParameters();
            }

            string name = _generator.Next();
            _parameters.Add(name, value);
            return name;
        }

        public string GetCommand() => _command.ToString();

        public DynamicParameters GetParameters() => _parameters;
    }
}