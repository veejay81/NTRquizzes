using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AsgQuizzes.Tests
{
    /// <summary>
    /// HINT: Maybe you should use some kind of object double library (Moq? RhinoMocks?)
    /// </summary>
    [TestClass]
    public class OrderTest
    {
        
        [TestMethod]
        public void TestDiscountAppliedAndSavedInRepository()
        {
            var orderId = Guid.NewGuid();

            // HINT: Some dependency missing here?
            var orderController = new OrderController(null);
            
            var originalTotal = orderController.GetById(orderId).TotalPrice;
            var modifiedTotal = orderController.ApplyDiscount(orderId, 10m).TotalPrice;
            Assert.AreEqual(originalTotal*0.9m, modifiedTotal);
        }

        [TestMethod]
        public void TestIncorrectOrderTotalThrowsValidationExceptionOnNew()
        {
            var orderController = new OrderController(null);
            var myOrder = new Order {TotalPrice = 100};
            orderController.New(myOrder);
            // HINT: Assert missing! Maybe is there an attribute to expect an exception?
        }

        [TestMethod]
        public void TestIncorrectLineTotalThrowsValidationExceptionOnUpdate()
        {
            throw new NotImplementedException();
        }

    }
}
