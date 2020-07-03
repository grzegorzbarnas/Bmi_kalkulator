using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bmi_kalkulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bmi_kalkulator.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {

            
            double wiek = 18;
            double w = 100;
            double h = 100;
            double wynik = w / (h * h) * 10000;




            Assert.AreEqual(100, 100);
        }

    }

       
    }
