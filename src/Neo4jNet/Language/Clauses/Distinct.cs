﻿namespace Neo4jNet.Language
{
    public class Distinct : Visitable
    {
        public new ClauseKind Kind => ClauseKind.Distinct;

        private readonly bool _value;

        public Distinct(bool value)
        {
            _value = value;
        }

        public bool GetValue() => _value;
    }
}