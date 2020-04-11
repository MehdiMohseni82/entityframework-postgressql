using SMS.Service;
using SMS.Service.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Repository
{
    public abstract class DataStore
        : IDataStore
    {
        protected abstract SMSDatabaseEntities DataContext
        {
            get;
        }

        public ICoursRepository CoursRepository
        {
            get
            {
                return new Repositories.CoursRepository(DataContext);
            }
        }

        public IStudentRepository StudentRepository => throw new NotImplementedException();

        public IStudentTypeRepository StudentTypeRepository => throw new NotImplementedException();

        public void CommitChanges()
        {
            DataContext.SaveChanges();
        }
    }
}
