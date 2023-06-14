using System;
namespace dor
{
	public class Functions
	{
        public string MyName = "Dor";
        private string _myName = "Dor";
        public const string MY_NAME = "Dor";

        int number1 = 2;

        public void publicFunction() // get the function in all files
        {
            MyName = "linoy";

            Console.WriteLine(MyName);
        }

        private void privateFunction() { // junst in this class 
            Console.WriteLine("HI LINOY");
        }

        public void writeName() { // returns nothing
            Console.WriteLine("name");
        }

        public int sum(int number1, int number2) {
            return number1 + number2;
        }

        public bool isLarge(int number1, int number2) {
            return number1 > number2;
        }

        public bool itIsDor(string name) {
            return name.Equals("dor");
        } 

        //function types:
        //void
        //boolean
        //int
        //string
    }
}

