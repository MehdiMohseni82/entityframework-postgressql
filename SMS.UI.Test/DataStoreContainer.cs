using SMS.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.UI.Test
{
    public static class DataStoreContainer
    {
        public static IDataStore GetDataStore()
        {
            return new EFDataStore();
        }

        public static void ClearDataStore()
        {
            EFDataStore.ClearDataContext();
        }
    }
}
