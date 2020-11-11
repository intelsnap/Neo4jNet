using System;
namespace Neo4jNet.Language
{
    /// <summary>
    /// (O,R,D,E,R), SP, (B,Y), SP, SortItem, { ',', [SP], SortItem } ;
    /// </summary>
    public class Order : Visitable
    {
        public Order() { }
    }
}