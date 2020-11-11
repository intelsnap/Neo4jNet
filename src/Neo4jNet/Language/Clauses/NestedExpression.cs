namespace Neo4jNet.Language
{
    public class NestedExpression : Expression
    {
        private readonly Expression _expression;

        public NestedExpression(Expression expression)
        {
            _expression = expression;
        }

        public new void Visit(CypherVisitor visitor)
        {
            visitor.Enter(this);
            Expressions.NameOrExpression(_expression).Visit(visitor);
            visitor.Leave(this);
        }
    }
}