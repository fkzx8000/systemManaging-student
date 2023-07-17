using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_work.Logic;

namespace TDD_work.Tests
{
    [TestClass]
    public class SortTests
    {

        [TestMethod]
        public void TestRegularSortNotEmpty()
        {
            UserData[] data = new UserData[]
            {
        new UserData { FirstName = "AAA", AverageGrade = "70" },
        new UserData { FirstName = "BBB", AverageGrade = "80" },
        new UserData { FirstName = "CCC", AverageGrade = "90" }
            };
            UserData[] sortedData = Sort.regularSort(data);
            Assert.IsNotNull(sortedData);
            Assert.IsTrue(sortedData.Length > 0);
        }


        [TestMethod]
        public void TestRegularSort_DoesNotLoseRecords()
        {

            List<UserData> data = new List<UserData>
        {
            new UserData { FirstName = "AAA", AverageGrade = "88" },
            new UserData { FirstName = "BBB", AverageGrade = "75" },
            new UserData { FirstName = "CCC", AverageGrade = "92" },
        };


            UserData[] input = Sort.convertToArr(data);
            UserData[] result = Sort.regularSort(input);


            Assert.AreEqual(input.Length, result.Length);
        }

        [TestMethod]
        public void Sort_convertToArr()
        {
            List<UserData> data = new List<UserData>()
            {
                new UserData() { FirstName = "AAA",LastName = "BBB",PhoneNumber="111111111",Email="aaa@aaa.com", AverageGrade = "20" },
                new UserData() { FirstName = "CCC",LastName = "DDD",PhoneNumber="222222222",Email="aaa@aaa.com" ,AverageGrade = "15" },
                new UserData() { FirstName = "ABAB",LastName = "AVAV",PhoneNumber="5555555555",Email="aaa@aaa.com" ,AverageGrade = "85" }
            };
            UserData[] arrData = Sort.convertToArr(data);
            


            Assert.AreEqual(arrData[0].AverageGrade, "20");
            Assert.AreEqual(arrData[1].AverageGrade, "15");
            Assert.AreEqual(arrData[2].AverageGrade, "85");
        }


        [TestMethod]
        public void TestRegularSortEmptyData()
        {
            List<UserData> data = new List<UserData>();
            UserData[] arrData = Sort.convertToArr(data);
            var result = Sort.regularSort(arrData);
            Assert.AreEqual(result.Length, 0);
        }

        [TestMethod]
        public void TestRegularSortSingleElement()
        {
            List<UserData> data = new List<UserData>
        {
            new UserData { FirstName = "AAAA", AverageGrade = "90" }
        };

            var result = Sort.regularSort(Sort.convertToArr(data));
            Assert.AreEqual(result[0].FirstName, "AAAA");
        }

        [TestMethod]
        public void TestRegularSortAlreadySorted()
        {

            List<UserData> data = new List<UserData>
        {
            new UserData { FirstName = "AAAA", AverageGrade = "80" },
            new UserData { FirstName = "BBBB", AverageGrade = "85" },
            new UserData { FirstName = "CCCC", AverageGrade = "90" },
            new UserData { FirstName = "DDDD", AverageGrade = "95" }
        };
            var result = Sort.regularSort(Sort.convertToArr(data));
            Assert.AreEqual(result[0].FirstName, "AAAA");
            Assert.AreEqual(result[1].FirstName, "BBBB");
            Assert.AreEqual(result[2].FirstName, "CCCC");
            Assert.AreEqual(result[3].FirstName, "DDDD");
        }

        [TestMethod]
        public void TestRegularSortDescendingOrder()
        {
            List<UserData> data = new List<UserData>
        {
            new UserData { FirstName = "AAAA", AverageGrade = "95" },
            new UserData { FirstName = "BBBB", AverageGrade = "90" },
            new UserData { FirstName = "CCCC", AverageGrade = "85" },
            new UserData { FirstName = "DDDD", AverageGrade = "80" }
        };

            var result = Sort.regularSort(Sort.convertToArr(data));          
            Assert.AreEqual(result[0].FirstName, "DDDD");
            Assert.AreEqual(result[1].FirstName, "CCCC");
            Assert.AreEqual(result[2].FirstName, "BBBB");
            Assert.AreEqual(result[3].FirstName, "AAAA");
        }

        [TestMethod]
        public void TestQuickSortEmptyArray()
        {
            UserData[] data = new UserData[0];
            UserData[] sortedData = Sort.quickSort(data, 0, data.Length - 1);


            CollectionAssert.AreEqual(data, sortedData);
        }

        [TestMethod]
        public void TestQuickSortOneElementArray()
        {

            UserData[] data = new UserData[] { new UserData { FirstName = "AAA", AverageGrade = "80" } };


            UserData[] sortedData = Sort.quickSort(data, 0, data.Length - 1);


            CollectionAssert.AreEqual(data, sortedData);
        }

        [TestMethod]
        public void TestQuickSortSortedArray()
        {

            UserData[] data = new UserData[]
            {
            new UserData { FirstName = "AAA", AverageGrade = "80" },
            new UserData { FirstName = "BBB", AverageGrade = "85" },
            new UserData { FirstName = "CCC", AverageGrade = "90" },
            new UserData { FirstName = "DDD", AverageGrade = "95" }
            };


            UserData[] sortedData = Sort.quickSort(data, 0, data.Length - 1);


            CollectionAssert.AreEqual(data, sortedData);
        }

        [TestMethod]
        public void TestQuickSortUnsortedArray()
        {
            UserData[] data = new UserData[]
            {
            new UserData { FirstName = "CCC", AverageGrade = "90" },
            new UserData { FirstName = "DDD", AverageGrade = "95" },
            new UserData { FirstName = "AAA", AverageGrade = "80" },
            new UserData { FirstName = "BBB", AverageGrade = "85" }
            };
            UserData[] expectedSortedData = new UserData[]
            {
            new UserData { FirstName = "AAA", AverageGrade = "80" },
            new UserData { FirstName = "BBB", AverageGrade = "85" },
            new UserData { FirstName = "CCC", AverageGrade = "90" },
            new UserData { FirstName = "DDD", AverageGrade = "95" }
            };


            UserData[] sortedData = Sort.quickSort(data, 0, data.Length - 1);

            Assert.AreEqual(expectedSortedData[0].AverageGrade, sortedData[0].AverageGrade);
            Assert.AreEqual(expectedSortedData[1].AverageGrade, sortedData[1].AverageGrade);
            Assert.AreEqual(expectedSortedData[2].AverageGrade, sortedData[2].AverageGrade);
            Assert.AreEqual(expectedSortedData[3].AverageGrade, sortedData[3].AverageGrade);
        }

        [TestMethod]
        public void TestQuickSortArrayWithDuplicateValues()
        {

            UserData[] data = new UserData[]
            {
            new UserData { FirstName = "CCC", AverageGrade = "90" },
            new UserData { FirstName = "DDD", AverageGrade = "85" },
            new UserData { FirstName = "AAA", AverageGrade = "85" },
            new UserData { FirstName = "BBB", AverageGrade = "90" }
            };
            UserData[] expectedSortedData = new UserData[]
            {
            new UserData { FirstName = "DDD", AverageGrade = "85" },
            new UserData { FirstName = "AAA", AverageGrade = "85" },
            new UserData { FirstName = "CCC", AverageGrade = "90" },
            new UserData { FirstName = "BBB", AverageGrade = "90" }
            };

            CollectionAssert.AreNotEquivalent(expectedSortedData, data);
        
        }

        [TestMethod]
        public void TestQuickSortReturnsValue()
        {

            var data = new List<UserData>()
        {
            new UserData() { FirstName = "AAA", AverageGrade = "80" },
            new UserData() { FirstName = "BBB", AverageGrade = "60" },
            new UserData() { FirstName = "CCC", AverageGrade = "70" },
            new UserData() { FirstName = "DDD", AverageGrade = "90" },
            new UserData() { FirstName = "EEE", AverageGrade = "75" }
        };
            var dataArray = Sort.convertToArr(data);


            var result = Sort.quickSort(dataArray, 0, dataArray.Length - 1);


            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestQuickSortArrayHasNotLostRecords()
        {

            var data = new List<UserData>()
        {
            new UserData() { FirstName = "AAA", AverageGrade = "80" },
            new UserData() { FirstName = "BBB", AverageGrade = "60" },
            new UserData() { FirstName = "CCC", AverageGrade = "70" },
            new UserData() { FirstName = "DDD", AverageGrade = "90" },
            new UserData() { FirstName = "EEE", AverageGrade = "75" }
        };
            var dataArray = Sort.convertToArr(data);
            var result = Sort.quickSort(dataArray, 0, dataArray.Length - 1);

            Assert.AreEqual(dataArray.Length, result.Length);
            for (int i = 0; i < dataArray.Length; i++)
            {
                Assert.IsTrue(dataArray.Contains(result[i]));
            }
        }

        [TestMethod]
        public void TestQuickSortArrayIsSorted()
        {
            var data = new List<UserData>()
        {
            new UserData() { FirstName = "AAA", AverageGrade = "80" },
            new UserData() { FirstName = "BBB", AverageGrade = "60" },
            new UserData() { FirstName = "CCC", AverageGrade = "70" },
            new UserData() { FirstName = "DDD", AverageGrade = "90" },
            new UserData() { FirstName = "EEE", AverageGrade = "75" }
        };
            var dataArray = Sort.convertToArr(data);


            var result = Sort.quickSort(dataArray, 0, dataArray.Length - 1);


            for (int i = 0; i < result.Length - 1; i++)
            {
                Assert.IsTrue(int.Parse(result[i].AverageGrade) <= int.Parse(result[i + 1].AverageGrade));
            }
        }


    }

}