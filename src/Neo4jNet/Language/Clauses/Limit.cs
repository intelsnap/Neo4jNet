using System;
namespace Neo4jNet.Language
{
    public class Limit : IVisitable
    {
        public Limit()
        { }

        public ClauseKind Kind =>
            throw new NotImplementedException();

        public void Visit(CypherVisitor visitor)
        {
            visitor.Enter(this);

            visitor.Leave(this);
        }
    }
}