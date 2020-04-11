using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service
{
    public interface IDataStore
    {

        void CommitChanges();

        IRepositories.ICoursRepository CoursRepository
        {
            get;
        }
        IRepositories.IStudentRepository StudentRepository
        {
            get;
        }
        IRepositories.IStudentTypeRepository StudentTypeRepository
        {
            get;
        }
    }
}
