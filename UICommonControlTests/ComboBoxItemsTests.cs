using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SHC.UROCare.UICommonControls;
using SHC.UROCare.TestObjects;
using SHC.UROCare.UROCareBusinessObjects;

namespace SHC.UROCare.UICommonControlTests
{
    [TestClass]
    public class ComboBoxItemsTests
    {
        [TestMethod]
        public void ConstructorGivenValueWorksCorrectly()
        {
            int id = TestDataModelObjects.GetRandomNumber(1);
            string textToDisplay = TestDataModelObjects.GetRandomString(5);
            DoctorsListBO doctorsList= new DoctorsListBO();
            ComboBoxItem comboItem = new ComboBoxItem(id, () => textToDisplay, doctorsList);
            Assert.IsTrue(id == comboItem.ID);
            Assert.IsTrue(textToDisplay == comboItem.Text);
            Assert.IsTrue(comboItem.Value.Equals(doctorsList));
        }
    }
}
