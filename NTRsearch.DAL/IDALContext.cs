namespace NTRsearch.DAL
{
    public interface IDALContext : IUnitOfWork
    {
        IQueryRepository Queries { get; }
    }
}