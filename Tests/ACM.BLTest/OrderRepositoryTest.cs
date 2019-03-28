﻿using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            // Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(2018, 3, 27, 0, 0, 0,
                                               new TimeSpan(7, 0, 0))
            };

            // Act
            var actual = orderRepository.Retrieve(10);

            // Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
    
}
