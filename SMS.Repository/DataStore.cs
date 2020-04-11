using SMS.Service;
using SMS.Service.IRepositories;
using System;

namespace SMS.Repository
{
    public abstract class DataStore
        : IDataStore
    {
        protected abstract SMSDatabaseEntities DataContext { get; }

        public ICoursRepository CoursRepository => new Repositories.CoursRepository(DataContext);

        public IStudentRepository StudentRepository => throw new NotImplementedException();

        public IStudentTypeRepository StudentTypeRepository => throw new NotImplementedException();

        public void CommitChanges()
        {
            DataContext.SaveChanges();
        }
    }
}