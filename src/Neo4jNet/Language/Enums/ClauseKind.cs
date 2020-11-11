namespace Neo4jNet.Language
{
    public enum ClauseKind
    {
        Default,
        Expression,
        AliasedExpression,
        Visitable,
        TypedSubtree,
        ExcludePattern,
        Operator,

        Node,
        Relationship,

        Match,
        OptionalMatch,
        Return,
        With,
        Unwind,
        Where,
        YieldItems,

        Distinct,
        OrderBy,
        Skip,
        Limit,

        Create,
        Delete,
        Set,
        Remove,
        Foreach,
        Merge,
        Union,
        Use,
        LoadCsv,
        Condition,
    }
}