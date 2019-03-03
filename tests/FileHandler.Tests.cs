using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;
using System.Collections.Generic;

namespace NameSorter.UnitTests
{
    [TestClass]
    public class FileHandlerTests
    {
        private readonly FileHandler filehandler;

        public FileHandlerTests(){
            filehandler = new FileHandler();
        }


        //Test if ReadFile returns the correct file content.
        [DataTestMethod]
        [DataRow("../../../test-names1.txt", "Hunter Uriah Mathew Clarke")]
        [DataRow("../../../test-names2.txt", "Chiedozie Samuel Ihejirika")]
        public void Test_ReadFile(string x, string expected){
            var result = filehandler.ReadFile(x);

            foreach(var item in result){
                Assert.AreEqual(expected, item, $"{item}");
            }
        }
    }
}
