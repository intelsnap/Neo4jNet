using System;

namespace Neo4jNet.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class Neo4JIgnoreAttribute : Attribute { }
}