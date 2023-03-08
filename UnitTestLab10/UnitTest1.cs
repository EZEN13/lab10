using ClassLibraryLab10;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;

namespace Laba10Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int wheels1 = 6;
            int doors1 = 4;

            int wheels2 = 6;
            int doors2 = 4;


            Transport expected = new Transport(wheels1, doors1);
            Transport actual = new Transport(wheels2, doors2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod2()
        {
            Transport expected = new Transport();

            Transport actual = new Transport();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod3()
        {
            Transport expected = new Transport();

            expected.RandomInit();

            Transport actual = new Transport();

            actual.RandomInit();

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod4()
        {
            int r = 5;
            int d = 8;

            int h = 5;

            int g = 8;

            Transport expected = new Transport(r, d);

            expected.ToString();

            Transport actual = new Transport(h, g);

            actual.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod5()
        {
            Transport expected = new Transport();
            expected.RandomInit();

            Transport actual = new Transport();
            actual.RandomInit();
            actual.Wheels = 100;
            expected = (Transport)actual.ShallowCopy();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod6()
        {
            int wheels1 = 6;
            int doors1 = 4;
            double oil1 = 12.4;
            int horsepower1 = 421;



            int wheels2 = 6;
            int doors2 = 4;
            double oil2 = 12.4;
            int horsepower2 = 421;


            Avto expected = new Avto(wheels1, doors1, oil1, horsepower1);

            Avto actual = new Avto(wheels2, doors2, oil2, horsepower2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod7()
        {
            Avto expected = new Avto();

            Avto actual = new Avto();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod8()
        {
            int wheels1 = 6;
            int doors1 = 4;
            string color1 = "red";


            string color2 = "red";
            int wheels2 = 6;
            int doors2 = 4;


            Train expected = new Train(wheels1, doors1, color1);

            Train actual = new Train(wheels2, doors2, color2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod9()
        {
            Train expected = new Train();

            Train actual = new Train();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod10()
        {
            int wheels1 = 6;
            int doors1 = 4;
            string color1 = "red";

            string color2 = "red";
            int wheels2 = 6;
            int doors2 = 4;

            Train expected = new Train(wheels1, doors1, color1);
            expected.Show();

            Train actual = new Train(wheels2, doors2, color2);
            actual.Show();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod11()
        {
            int wheels1 = 6;
            int doors1 = 4;

            int wheels2 = 6;
            int doors2 = 4;

            Transport expected = new Transport(wheels1, doors1);
            expected.Show();

            Transport actual = new Transport(wheels2, doors2);
            actual.Show();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod12()
        {
            int wheels1 = 6;
            int doors1 = 4;
            double oil1 = 12.4;
            int horsepower1 = 421;



            int wheels2 = 6;
            int doors2 = 4;
            double oil2 = 12.4;
            int horsepower2 = 421;

            Avto expected = new Avto(wheels1, doors1, oil1, horsepower1);
            expected.Show();

            Avto actual = new Avto(wheels2, doors2, oil2, horsepower2);
            actual.Show();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod13()
        {
            int wheels1 = 6;
            int doors1 = 4;
            string color1 = "yellow";
            int capacity1 = 45;


            int capacity2 = 45;
            string color2 = "yellow";
            int wheels2 = 6;
            int doors2 = 4;


            Express expected = new Express(wheels1, doors1, color1, capacity1);
            expected.Show();

            Express actual = new Express(wheels2, doors2, color2, capacity2);
            actual.Show();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod14()
        {
            Transport expected = new Transport();
            expected.Show2();

            Transport actual = new Transport();
            actual.Show2();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod15()
        {
            Express expected = new Express();

            Express actual = new Express();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod16()
        {
            int wheels1 = 6;
            int doors1 = 4;
            int capacity1 = 100;
            string color1 = "red";


            int capacity2 = 100;
            string color2 = "red";
            int wheels2 = 6;
            int doors2 = 4;


            Express expected = new Express(wheels1, doors1, color1, capacity1);

            Express actual = new Express(wheels2, doors2, color2, capacity2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod17()
        {
            Express expected = new Express();
            expected.RandomInit();

            Express actual = new Express();
            actual.RandomInit();

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]

        public void TestMethod18()
        {
            Avto expected = new Avto();
            expected.RandomInit();

            Avto actual = new Avto();
            actual.RandomInit();

            Assert.AreNotEqual(expected, actual);
        }
    }
}