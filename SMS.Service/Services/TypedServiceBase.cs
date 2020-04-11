using System;
using XMen.Query;

namespace SMS.Service.Service
{
    public abstract class TypedServiceBase<ModelType> 
        : ServiceBase
    {
        #region Constructors

        public TypedServiceBase()
        {
        }

        public TypedServiceBase(IDataStore dataStore)
            : base(dataStore)
        {
        }

        #endregion

        #region Abstract Methods

        public abstract ModelType CreateObject();

        public abstract ServiceResultObject<ModelType> GetObject(Guid id);

        public abstract ServiceResultList<ModelType> GetLookupList(Query query);

        public abstract ServiceResultList<ModelType> GetList(Query query, int index, int count);

        public abstract ServiceResultList<ModelType> GetList(Query query);

        public abstract ServiceResult Add(ModelType entity);

        public abstract ServiceResult Update(ModelType entity);

        public abstract ServiceResult Delete(Guid id);

        #endregion

        #region Methodss
        #endregion
    }
}