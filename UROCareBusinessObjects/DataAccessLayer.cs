using SHC.UROCare.UROCareDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SHC.UROCare.UROCareBusinessObjects
{
    public class DataAccessLayer
    {
        static IUROCareEntities dataContext;

        public static IUROCareEntities GetDataContext()
        {
            dataContext = new UROCareEntities(); 
            
            return dataContext;
        }

        public void SetTestDataContext(IUROCareEntities testDataContext)
        {
            dataContext = testDataContext;
        }
    }
}
