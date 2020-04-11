using SMS.Service;

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