using SMS.Repository;

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