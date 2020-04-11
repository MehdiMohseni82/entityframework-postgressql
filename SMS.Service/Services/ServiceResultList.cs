using System.Collections.Generic;
using System.Linq;

namespace SMS.Service.Service
{
    public class ServiceResultList<T>
        : ServiceResult
    {
        #region Constructors

        public ServiceResultList()
        {
        }

        public ServiceResultList(IEnumerable<T> resultList)
        {
            ResultList = resultList;
            TotalCount = resultList.Count();
            ResultType = ServiceResultType.Success;
        }

        public ServiceResultList(ServiceResultType resultType, IEnumerable<T> resultList)
        {
            ResultList = resultList;
            TotalCount = resultList.Count();
            ResultType = resultType;
        }

        public ServiceResultList(IEnumerable<T> resultList, int totalCount)
        {
            ResultList = resultList;
            TotalCount = totalCount;
            ResultType = ServiceResultType.Success;
        }

        public ServiceResultList(ServiceResultType resultType)
            : base(resultType)
        {
            ResultList = null;
        }

        public ServiceResultList(ServiceResultType resultType, string message)
            : base(resultType, message)
        {
            ResultList = null;
        }

        #endregion

        #region Properties

        public IEnumerable<T> ResultList
        {
            internal set;
            get;
        }

        public int TotalCount
        {
            internal set;
            get;
        }

        #endregion
    }
}