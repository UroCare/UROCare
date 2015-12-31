using System;
using FakeItEasy;
using SHC.UROCare.UROCareDataModel;
using System.Collections.Generic;

using TestCommon;

namespace SHC.UROCare.URCareBusinessObjectsTest
{
    public class TestObjectFactory
    {
        public static IUROCareEntities GetMockedDataContext()
        {
            var mock = new Mock<IDbContext>();
            mock.Setup(x => x.Set<User>()).Returns(new FakeDbSet<User>
        {
            new User { ID = 1 }
        });

            
            IUROCareEntities uroCareEntity = A.Fake<IUROCareEntities>();
            A.CallTo(() => uroCareEntity.User_Master).Returns(new MockObjectSet<User_Master>());
            A.CallTo(() => uroCareEntity.User_Master).Returns(new MockObjectSet<User_Master>());
            A.CallTo(() => uroCareEntity.Patient_Info).Returns(new MockObjectSet<Patient_Info>());
            return uroCareEntity;
        }

    }
}
