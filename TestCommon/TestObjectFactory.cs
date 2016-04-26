using System;
using FakeItEasy;
using System.Collections.Generic;
using SHC.UROCare.UROCareDataModel;
using System.Threading;

namespace SHC.UROCare.TestObjects
{
    public class TestObjectFactory
    {
        public static IUROCareEntities GetMockedDataContext()
        {
            
            IUROCareEntities uroCareEntity = A.Fake<IUROCareEntities>();
            A.CallTo(() => uroCareEntity.User_Master).Returns(new MockObjectSet<User_Master>());            
            A.CallTo(() => uroCareEntity.Patient_Info).Returns(new MockObjectSet<Patient_Info>());
            A.CallTo(() => uroCareEntity.Doctors_List).Returns(new MockObjectSet<Doctors_List>());
            A.CallTo(() => uroCareEntity.Urology_History).Returns(new MockObjectSet<Urology_History>());

            return uroCareEntity;
        }

        public static void SetFakedDataContext()
        {
            Thread.SetData(Thread.GetNamedDataSlot("dataContext"),GetMockedDataContext());
        }
    }
}
