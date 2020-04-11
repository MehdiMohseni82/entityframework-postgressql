namespace SMS.Service.Service
{
    public abstract class ServiceBase
    {
        #region Constructors

        public ServiceBase()
        {
        }

        public ServiceBase(IDataStore dataStore)
        {
            DataStore = dataStore;
        }

        #endregion

        #region Properties

        public IDataStore DataStore
        {
            set;
            get;
        }


        #endregion

        #region Abstract Properties

        public abstract string ModuleName { get; }

        #endregion

        #region Abstract Methods


        #endregion

        #region Methods


        #endregion
    }
}