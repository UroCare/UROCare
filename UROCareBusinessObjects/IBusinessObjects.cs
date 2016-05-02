
using SHC.UROCare.UROCareDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SHC.UROCare.UROCareBusinessObjects
{
    public interface IBusinessObject
    {
       
    }

    public interface IPersistable<TEntity> : IBusinessObject
    {
        void MapDatabaseValueToObject(TEntity databaseEntity);
        void MapFromObjectToDatabaseEntity(TEntity databaseEntity);

        int Save(IUROCareEntities dataContext);
        int Save();   
    }   
}
