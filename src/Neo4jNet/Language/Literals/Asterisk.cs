namespace Neo4jNet.Language
{
    public sealed class Asterisk : Literal<string>
    {
        public readonly static Asterisk INSTANCE = new Asterisk();

        private Asterisk() : base("*") { }

        public override string AsString() => GetContent();
    }
}