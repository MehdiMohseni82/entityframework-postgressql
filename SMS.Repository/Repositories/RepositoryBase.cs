using SMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Repository.Repositories
{
    public abstract class RepositoryBase
    {
        public SMSDatabaseEntities DataContext
        {
            set;
            get;
        }

        public RepositoryBase(SMSDatabaseEntities dc)
        {
            DataContext = dc;
        }
    }
}
