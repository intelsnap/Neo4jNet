using System;

namespace Neo4jNet.Language
{
    /// <summary>
    /// Utility methods for dealing with expressions.
    /// </summary>
    public sealed class Expressions
    {
        private Expressions() { }
        public static Expression NameOrExpression<T>(T expression) where T : Expression
        {
            if (expression is Named named)
            {
                return named.GetSymbolicName();
            }
            else
            {
                return expression;
            }
        }

        public static Expression[] CreateSymbolicNames(string[] variables) =>
            Array.ConvertAll(variables, item => SymbolicName.Of(item));

        public static Expression[] CreateSymbolicNames(Named[] variables) =>
            //Array.ConvertAll(variables, item => Named.

    }
}