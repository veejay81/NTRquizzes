namespace NTRsearch.DAL
{
    public class QueryRepository : Repository<Query>, IQueryRepository
    {
        public QueryRepository(DB context) : base(context) { }
    }
}