namespace Neo4jNet.Language
{
    public interface IPropertyContainer : INamed
    {
        public abstract Property Property(string name);
    }
}