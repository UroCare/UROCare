using System;
using FakeItEasy;
using System.Collections.Generic;

using SHC.UROCare.UROCareDataModel;
using System.Threading;

namespace SHC.UROCare.URCareBusinessObjectsTest
{
    public class TestObjectFactory
    {
        public static IUROCareEntities GetMockedDataContext()
        {
            
            IUROCareEntities uroCareEntity = A.Fake<IUROCareEntities>();
            A.CallTo(() => uroCareEntity.User_Master).Returns(new MockObjectSet<User_Master>());
            
            A.CallTo(() => uroCareEntity.Patient_Info).Returns(new MockObjectSet<Patient_Info>());
            return uroCareEntity;
        }

        public static void SetFakedDataContext()
        {
            Thread.SetData(Thread.GetNamedDataSlot("dataContext"),GetMockedDataContext());
        }
    }
}
