using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ProductService.Tests
{
    [TestClass()]
    public class ProductServiceTests
    {
        private List<Product> _productData = new List<Product>
        {
            new Product() {Id = 1, Cost = 1, Revenue = 11, SellPrice = 21},
            new Product() {Id = 2, Cost = 2, Revenue = 12, SellPrice = 22},
            new Product() {Id = 3, Cost = 3, Revenue = 13, SellPrice = 23},
            new Product() {Id = 4, Cost = 4, Revenue = 14, SellPrice = 24},
            new Product() {Id = 5, Cost = 5, Revenue = 15, SellPrice = 25},
            new Product() {Id = 6, Cost = 6, Revenue = 16, SellPrice = 26},
            new Product() {Id = 7, Cost = 7, Revenue = 17, SellPrice = 27},
            new Product() {Id = 8, Cost = 8, Revenue = 18, SellPrice = 28},
            new Product() {Id = 9, Cost = 9, Revenue = 19, SellPrice = 29},
            new Product() {Id = 10, Cost = 10, Revenue = 20, SellPrice = 30},
            new Product() {Id = 11, Cost = 11, Revenue = 21, SellPrice = 31}
        };

        private ProductService _target;

        [TestInitialize]
        public void Init()
        {
            _target = new ProductService(_productData);
        }

        [TestMethod()]
        public void Sum_Cost_By_Groupping_ThreeRows()
        {
            var actual = _target.GetSum(3,"cost");
            var expect = new List<int>(){6,15,24,24};

            CollectionAssert.AreEqual(expect,actual);
        }

        [TestMethod()]
        public void Sum_Revenue_By_Groupping_FourRows()
        {
            var actual = _target.GetSum(4, "revenue");
            var expected = new List<int>() { 50, 66, 60 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Groupping_By_NegativeNumber_Should_Throw_ArgumentException()
        {
            Action act = () => _target.GetSum(-1, "revenue");
            act.ShouldThrow<ArgumentException>();
        }

        [TestMethod()]
        public void Sum_By_NotExisted_ColumnName_Gender_Should_Throw_ArgumentException()
        {
            Action act = () => _target.GetSum(3, "gender");
            act.ShouldThrow<ArgumentException>();
        }

        [TestMethod()]
        public void Groupping_By_Zero_Should_Return_Zero()
        {
            var actual = _target.GetSum(0, "revenue");
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }

}
