﻿namespace Neo4jNet
{
    public partial class CypherVisitor
    {
        private readonly CypherBuilder _builder = new CypherBuilder();
        public string Print() => _builder.Print();
    }
}