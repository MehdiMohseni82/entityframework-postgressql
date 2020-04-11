using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Service
{
    public class ServiceResult
    {
        #region Constructors
        public ServiceResult()
        {
            ResultType = ServiceResultType.Success;
           
        }

        public ServiceResult(ServiceResultType resultType)
        {
            ResultType = resultType;
        }

        public ServiceResult(ServiceResultType resultType, string message)
        {
            ResultType = resultType;
            ErrorMessage = message;
        }

        #endregion

        #region Properties

        public ServiceResultType ResultType
        {
            set;
            get;
        }

        public string ErrorMessage
        {
            set;
            get;
        }

        #endregion
    }
}
