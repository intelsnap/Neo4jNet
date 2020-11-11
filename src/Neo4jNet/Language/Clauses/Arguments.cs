namespace Neo4jNet.Language
{
    /// <summary>
    /// Specialized list of expressions that represent the arguments on a procedure call.
    /// </summary>
    public class Arguments : TypedSubtree<Expression, Arguments>
    {
        public Arguments(Expression[] children) : base(children) { }
        new protected Visitable PrepareVisit(Expression child) => Expressions.NameOrExpression(child);
    }
}