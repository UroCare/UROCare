using SHC.UROCare.UROCareDataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;


namespace SHC.UROCare.UROCareBusinessObjects
{
    public class DataAccessLayer
    {
        static IUROCareEntities dataContext;

        public static IUROCareEntities GetDataContext()
        {
            dataContext = (IUROCareEntities)Thread.GetData(Thread.GetNamedDataSlot("dataContext"));
            if (null == dataContext || dataContext.IsDisposed)
            {
                dataContext = new UROCareEntities();
                Thread.SetData(Thread.GetNamedDataSlot("dataContext"),dataContext);
            }
            return dataContext;
        }     

        public void SetTestDataContext(IUROCareEntities testDataContext)
        {
            dataContext = testDataContext;
        }
    }
}
