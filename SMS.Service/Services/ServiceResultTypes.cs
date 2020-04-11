using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Service
{
    public enum ServiceResultType
    {
        Success = 0,
        ErrorNoPrivilege = 10,
        ErrorAccessDenied = 20,
        ErrorObjectNotFound = 30,
        ErrorWeekDayNotLoggedIn = 40,
        ErrorInvalidArgument = 50,
        ErrorInvalidObjectState = 60,
        ErrorDuplicateProgress = 70,
        ErrorFileStorageFailed = 80,
        ErrorInFileDeleting = 90,
        NoneUnigueRecord = 100,
        ErrorUnknown = 9999
    }
}
