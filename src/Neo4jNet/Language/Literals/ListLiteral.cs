using System.Collections.Generic;
/// <summary>
/// A list of literals.
/// </summary>
namespace Neo4jNet.Language
{
    public class ListLiteral<T> : Literal<IEnumerable<Literal<T>>>
    {
        public ListLiteral(IEnumerable<Literal<T>> content) : base(content) { }

        public override string AsString()
        {
            throw new System.NotImplementedException();
        }
    }
}