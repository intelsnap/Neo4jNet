namespace Neo4jNet.Language
{
    public interface INamed
    {
        public abstract SymbolicName GetSymbolicName();
        public SymbolicName GetRequiredSymbolicName();
    }
}