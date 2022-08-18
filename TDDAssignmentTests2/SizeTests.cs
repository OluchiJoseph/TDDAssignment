using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDAssignment.Tests
{
    [TestClass()]
    public class SizeTests
    {
        [TestMethod()]
        [DataRow("30","5","10","1500")]
        [DataRow("50","6","30","9000")]
        [DataRow("40","5","20","4000")]

        public void SizeTest(string l, string w, string d, string expected)
        {
            var volume = new Size();
            double length = double.Parse(l);
            double width = double.Parse(w);
            double depth = double.Parse(d);
            double expectedRes = double.Parse(expected);

            var volumeCalc = volume.Capacity(length, width, depth);

            

            //Single test
            //var size = new Size();
            //double volume = size.Capacity(70, 20, 50);
            //Assert.AreEqual(70000, volume);
        }
  
    }
}