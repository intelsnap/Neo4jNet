using System;

namespace Neo4jNet.Language
{
    public class Named : INamed
    {
        public abstract SymbolicName GetSymbolicName();
        public SymbolicName GetRequiredSymbolicName() => GetSymbolicName() ??
            throw new Exception("No name present.");
    }
}