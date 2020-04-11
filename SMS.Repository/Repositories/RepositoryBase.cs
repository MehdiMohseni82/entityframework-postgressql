namespace SMS.Repository.Repositories
{
    public abstract class RepositoryBase
    {
        public SMSDatabaseEntities DataContext { set; get; }

        public RepositoryBase(SMSDatabaseEntities dc)
        {
            DataContext = dc;
        }
    }
}
