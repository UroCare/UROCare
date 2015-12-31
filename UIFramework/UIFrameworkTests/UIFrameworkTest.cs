// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SHCPL.UI;

namespace UIFrameworkTests
{
    /// <summary>
    /// Test class having all the tests related to the UIFramework.
    /// </summary>
    [TestClass]
    public class UIFrameworkTest
    {
        [ExpectedException(typeof (ArgumentNullException))]
        [TestMethod]
        public void Navigate_GivenNullNode_ThrowsArgumentNullException()
        {
            var nodeContext = new Mock<INodeContext>();
            UIFramework.Instance.Navigate(null, nodeContext.Object);
        }

        [ExpectedException(typeof (ArgumentNullException))]
        [TestMethod]
        public void Navigate_GivenNullContext_ThrowsArgumentNullException()
        {
            var mockedObject = new Mock<INodeFactory>();
            UIFramework.Instance.Navigate(mockedObject.Object, null);
        }

        [TestMethod]
        public void Navigate_GivenNodeCalledTwice_RaisesNodeChangingEvent()
        {
            bool eventRaised = false;
            NodeChangingEventHandler handler = (sender, node) => eventRaised = true;
            UIFramework.Instance.NodeChangingEvent += handler;
            try
            {
                var mockedNodeFactory = new Mock<INodeFactory>();
                var mockedNodeContext = new Mock<INodeContext>();
                var mockedNode = new Mock<INode>();
                mockedNodeFactory.Setup(nodeFactory => nodeFactory.CreateNode(It.IsAny<INodeContext>())).Returns(
                    mockedNode.Object);
                UIFramework.Instance.Navigate(mockedNodeFactory.Object, mockedNodeContext.Object);
                UIFramework.Instance.Navigate(mockedNodeFactory.Object, mockedNodeContext.Object);
                Assert.IsTrue(eventRaised);
            }
            finally
            {
                UIFramework.Instance.NodeChangingEvent -= handler;
            }
        }

        [TestMethod]
        public void Navigate_GivenNodeWhenCalled_RaisesNodeChangedEventAfterNodeChanging()
        {
            bool eventRaised = false;
            NodeChangingEventHandler handler = (sender, node) => eventRaised = true;
            NodeChangedEventHandler changedEventHandler = (sender, node) => Assert.IsTrue(eventRaised);

            UIFramework.Instance.NodeChangingEvent += handler;
            UIFramework.Instance.NodeChangedEvent += changedEventHandler;
            try
            {
                var mockedNodeFactory = new Mock<INodeFactory>();
                var mockedNodeContext = new Mock<INodeContext>();
                var mockedNode = new Mock<INode>();
                mockedNodeFactory.Setup(nodeFactory => nodeFactory.CreateNode(It.IsAny<INodeContext>())).Returns(
                    mockedNode.Object);
                UIFramework.Instance.Navigate(mockedNodeFactory.Object, mockedNodeContext.Object);
                UIFramework.Instance.Navigate(mockedNodeFactory.Object, mockedNodeContext.Object);
            }
            finally
            {
                UIFramework.Instance.NodeChangingEvent -= handler;
                UIFramework.Instance.NodeChangedEvent -= changedEventHandler;
            }
        }

        [TestMethod]
        public void Navigate_WhenCalledOnSameNode_DoesNotRaiseEvent()
        {
            bool eventRaised = false;
            NodeChangedEventHandler handler = (sender, node) => eventRaised = true;
            try
            {
                var mockedFactory = new Mock<INodeFactory>();
                var mockedNodeContext = new Mock<INodeContext>();
                var mockedNode = new Mock<INode>();
                mockedFactory.Setup(nodeFactory => nodeFactory.CreateNode(It.IsAny<INodeContext>())).Returns(
                    mockedNode.Object);
                UIFramework.Instance.Navigate(mockedFactory.Object, mockedNodeContext.Object);
                UIFramework.Instance.NodeChangedEvent += handler;
                UIFramework.Instance.Navigate(mockedFactory.Object, mockedNodeContext.Object);
                Assert.IsFalse(eventRaised);
            }
            finally
            {
                UIFramework.Instance.NodeChangedEvent -= handler;
            }
        }

        [TestMethod]
        public void GetRecommendedColors_WhenCalled_ReturnsColorsInformation()
        {
            var result = UIFramework.Instance.GetRecommendedColors();
        }
    }
}