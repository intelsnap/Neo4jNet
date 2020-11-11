namespace Neo4jNet.Language
{
    public class DoubleLiteral : Literal<double>
    {
        public DoubleLiteral(double content) : base(content) { }
        public override string AsString() => GetContent().ToString();
    }
}