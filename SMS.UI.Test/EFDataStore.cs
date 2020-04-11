using SMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.UI.Test
{
    public class EFDataStore
        : DataStore
    {
        protected static SMSDatabaseEntities _DataContext;
        protected override SMSDatabaseEntities DataContext
        {
            get
            {
                if (_DataContext == null)
                {
                    _DataContext = new SMSDatabaseEntities();
                }
                return _DataContext;
            }
        }

        public static void ClearDataContext()
        {
            _DataContext = null;
        }


    }
}
