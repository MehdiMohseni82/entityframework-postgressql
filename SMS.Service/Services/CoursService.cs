using SMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMen.Query;

namespace SMS.Service.Service
{
    public class CoursService
        : TypedServiceBase<Cours>
    {

        #region Constructors

        public CoursService()
        {
        }

        public CoursService(IDataStore dataStore)
            : base(dataStore)
        { }

        #endregion

        #region Methods

        #endregion

        #region TypedServiceBase Implementation

        public override string ModuleName
        {
            get { return ""; }
        }

        public override ServiceResultList<Cours> GetList(Query query, int index, int count)
        {
            IEnumerable<Cours> result = null;
            int totalCount = 0;
            try
            {
                totalCount = DataStore.CoursRepository.CountBy(query);
                result = DataStore.CoursRepository.FindBy(query, index, count);
            }
            catch (Exception e)
            {
                return new ServiceResultList<Cours>(ServiceResultType.ErrorUnknown, e.Message);
            }
            return new ServiceResultList<Cours>(result, totalCount);
        }

        public override ServiceResultList<Cours> GetList(Query query)
        {
            IEnumerable<Cours> result = null;
            int totalCount = 0;
            try
            {
                totalCount = DataStore.CoursRepository.CountBy(query);
                result = DataStore.CoursRepository.FindBy(query);
            }
            catch (Exception e)
            {
                return new ServiceResultList<Cours>(ServiceResultType.ErrorUnknown, e.Message);
            }
            return new ServiceResultList<Cours>(result, totalCount);

        }

        public override ServiceResult Add(Cours entity)
        {
            // add entity to data store
            try
            {
                entity.Id = Guid.NewGuid();

                DataStore.CoursRepository.Add(entity);
                DataStore.CommitChanges();
            }
            catch (Exception e)
            {
                return new ServiceResult(ServiceResultType.ErrorUnknown, e.Message);
            }
            return new ServiceResult(ServiceResultType.Success);
        }

        public override ServiceResultObject<Cours> GetObject(Guid id)
        {
            Cours entity = null;
            try
            {
                // retrieve object from data store
                entity = DataStore.CoursRepository.FindBy(id);

                // make sure object exists
                if (entity == null)
                {
                    return new ServiceResultObject<Cours>(ServiceResultType.ErrorObjectNotFound);
                }

            }
            catch (Exception e)
            {
                return new ServiceResultObject<Cours>(ServiceResultType.ErrorUnknown, e.Message);
            }

            return new ServiceResultObject<Cours>(entity);
        }

        public override ServiceResult Update(Cours entity)
        {
            try
            {
                // fill update information

                // update object
                DataStore.CoursRepository.Update(entity);
                DataStore.CommitChanges();
            }
            catch (Exception e)
            {
                return new ServiceResult(ServiceResultType.ErrorUnknown, e.Message);
            }
            return new ServiceResult(ServiceResultType.Success);
        }

        public override ServiceResult Delete(Guid id)
        {
            // retrieve object from datastore
            Cours entity = DataStore.CoursRepository.FindBy(id);
            if (entity == null)
            {
                return new ServiceResult(ServiceResultType.ErrorObjectNotFound);
            }

            // delete object from datastore
            try
            {
                DataStore.CoursRepository.Remove(entity);
                DataStore.CommitChanges();
            }
            catch (Exception e)
            {
                return new ServiceResult(ServiceResultType.ErrorUnknown, e.Message);
            }

            return new ServiceResult(ServiceResultType.Success);
        }

        public override ServiceResultList<Cours> GetLookupList(Query query)
        {
            IEnumerable<Cours> result = null;
            int totalCount = 0;
            try
            {
                totalCount = DataStore.CoursRepository.CountBy(query);
                result = DataStore.CoursRepository.FindBy(query);
            }
            catch (Exception e)
            {
                return new ServiceResultList<Cours>(ServiceResultType.ErrorUnknown, e.Message);
            }
            return new ServiceResultList<Cours>(result, totalCount);

        }

        public override Cours CreateObject()
        {
            return DataStore.CoursRepository.CreateObject();
        }

        #endregion
    }
}
