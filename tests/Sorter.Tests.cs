using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;
using System.Collections.Generic;

namespace NameSorter.UnitTests
{
    [TestClass]
    public class SorterTests
    {
        private readonly Sorter sorter;
        public List<string> sampleList1 = new List<string>();
        public List<string> sampleList2 = new List<string>();
        
        public List<string> sampleList1_result = new List<string>();
        public List<string> sampleList2_result = new List<string>();

        public SorterTests(){
            sorter = new Sorter(null);

            sampleList1.Add("Ihejirika Chiedozie");
            sampleList1.Add("Poppins Mary");
            sampleList1.Add("Poppins Mark");
            sampleList1.Add("Drew Nancy");
            sampleList1.Add("Escobar Pablo");

            sampleList1_result.Add("Drew Nancy");
            sampleList1_result.Add("Escobar Pablo");
            sampleList1_result.Add("Ihejirika Chiedozie");
            sampleList1_result.Add("Poppins Mark");
            sampleList1_result.Add("Poppins Mary");
        }


        [DataTestMethod]
        [DataRow("Chiedozie Ihejirika", "Ihejirika Chiedozie")]
        [DataRow("Nancy Mary Stanley", "Stanley Mary Nancy")]
        [DataRow("Timmy John Solomon Zinny", "Zinny Solomon John Timmy")]
        public void Test_reOrder(string x, string expected)
        {
            string result = sorter.reOrder(x);

            Assert.AreEqual(expected, result, false, $"The name has probably gotten twisted: {result}");
        }


        [DataTestMethod]
        [DataRow("Chiedozie Ihejirika", "Chiedozie Ihejirika")]
        [DataRow("   Tommy   James   ", "Tommy James")]
        [DataRow(" Marvelous Henry    Simon    Kurt  ", "Marvelous Henry Simon Kurt")]
        public void Test_nameClean(string x, string expected)
        {
            string result = sorter.nameClean(x);

            Assert.AreEqual(expected, result, false);
        }


        [TestMethod]
        public void Test_Sort(){
            List<string> result = sorter.SortList(sampleList1);

            CollectionAssert.AreEqual(sampleList1_result, result, "SortList function is busted");
        }
    }
}
