using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_ValueTypes
{
    public enum PastryType
    {
        Cake = 0,
        Danish,
        Croissant,
        Donut,
        Scone,
        Backlava
    }
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void InitAndDeclareVariables()
        {
            //Daclaring a Varibale
            int numOne;
            numOne = 1;

            //Declaring and Initializing a Variable
            int numTwo = 2;

            //Variable
            //named location in computer memory aka RAM
        }

        [TestMethod]
        public void ValueTypeVariables()
        {
            //Whole Numbers
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExamp = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;  //C# strongly typed language
            int intMax = 2147483647;
            Int32 snotherIntExample = 123456;
            long longMax = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            //Decimals
            double doubleExample = 1.23456789;  //hold least amount of memory
            float floatExample = 1.23456789f;
            decimal decimalExample = 1.23456789m;  //holds most amount of memory

            Console.WriteLine(doubleExample);

            //Character
            char charExample = 'a';  //single character must have single quotes
            char number = '3';
            char symbol = '&';
            char space = ' ';
            char specialChar = '\n'; //carriage return / new line

            //Bool
            bool isHungry = true;
            bool isTired = false;

            //Enum
            PastryType myPastry = PastryType.Backlava;

            //Structs
            DateTime today = DateTime.Now;
            Console.WriteLine(today);


        }
    }
}
