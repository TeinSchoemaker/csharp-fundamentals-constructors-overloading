



using System.Reflection.Metadata.Ecma335;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float Add(float a, float b)
        {
            return a + b;
        }

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double Add(double a, double b)
        {
            return a + b;
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)      
        public float Subtract(float a, float b)
        {
            return a - b;
        }

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed        
        public string Subtract(string _string, char _char)
        {
            return _string.Replace(_char.ToString(), "");
        }

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string Multiply(string a, int b)
        {
            string result= "";

            for (int i = 0; i < b; i++)
            {
                result += a;
                
                if (i < b - 1)
                {
                    result += ",";
                }
            }

            return result;
        }

        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] Multiply(string[] a, int b)
        {

            List<int> result = new List<int>();
            foreach (string num in a)
            {
                result.Add(int.Parse(num) * b);
            }
            return result.ToArray();
        }

    }
}
