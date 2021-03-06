using XMen.Query.Enums;

namespace XMen.Query
{
    /// <summary>
    /// Represents a JOIN clause to be used with SELECT statements
    /// </summary>
    public struct JoinClause
    {
        public JoinType JoinType;
        public string FromTable;
        public string FromColumn;
        public Comparison ComparisonOperator;
        public string ToTable;
        public string ToColumn;
        public JoinClause(JoinType join, string toTableName, string toColumnName, Comparison @operator, string fromTableName, string fromColumnName)
        {
            JoinType = join;
            FromTable = fromTableName;
            FromColumn = fromColumnName;
            ComparisonOperator = @operator;
            ToTable = toTableName;
            ToColumn = toColumnName;
        }
    }
}
