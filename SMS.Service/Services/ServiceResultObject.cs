namespace SMS.Service.Service
{
    public class ServiceResultObject<T>
        : ServiceResult
    {
        #region Constructors

        public ServiceResultObject()
        {
        }

        public ServiceResultObject(T resultObject)
        {
            ResultObject = resultObject;
            ResultType = ServiceResultType.Success;
        }

        public ServiceResultObject(ServiceResultType resultType)
            : base(resultType)
        {
            ResultObject = default(T);
        }

        public ServiceResultObject(ServiceResultType resultType, string message)
            : base(resultType, message)
        {
            ResultObject = default(T);
        }

        #endregion

        #region Properties

        public T ResultObject
        {
            internal set;
            get;
        }

        #endregion
    }
}