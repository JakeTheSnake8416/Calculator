using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Mathematics
{
    public class Calculator
    {
        const float PI = 3.1415926f;

        public static int Factorial(int num)
        {
            if (num == 0) return 1;
            return num * Factorial(num - 1);
        }
        public static float RoundDecimal(float num, int numOfDecimalPlaces)
        {
            
            string numStr = num.ToString();
            string[] subs = numStr.Split('.');
            try { return float.Parse(numStr.Remove(subs[0].Length + 1 + numOfDecimalPlaces)); }
            catch { return -1f;  }
        }

        public static int RoundWhole(int num, int numOfDigits)
        {
            return -1;
        }

        public static int RoundWhole(float num, int numOfDigits)
        {
            return -1;
        }

        public static int Power(int bas, int exp)
        {
            int result = bas;
            if (exp == 0) return 1;
            for (byte i = 0; i < exp - 1; i++)
            {
                result = result * bas;
            }
            return result;
        }

        public static float Power(float bas, int exp)
        {
            float result = bas;
            if (exp == 0) return 1;
            for (byte i = 0; i < exp - 1; i++)
            {
                result = result * bas;
            }
            return result;
        }

        public static int Root(int num, int root)
        {
            int hi = num;
            int lo = 1;
            int result = 1;
            for (byte i = 0; i < num / 4; i++)
            {
                result = (hi + lo) / 2;
                if (Power(result, root) == num) return result;
                else if (Power(result, root) > num) hi = result;
                else lo = result;
            }
            return result;
        }   

        public static int[] Factor(int num)
        {
            List<int> output = new List<int>();
            int result = num;
            for (int i = 0; i < num; i++)
            {
                if (result % 5 == 0) { result /= 5; output.Add(5); }
                else if (result % 3 == 0) { result /= 3; output.Add(3); }
                else if (result % 2 == 0) { result /= 2; output.Add(2); }
                else { output.Add(num); output.Add(1); break; }
            }
            return output.ToArray();
        }

        public static float RectArea(float length, float width)
        {
            return length * width;
        }

        public static float CirArea(float radius)
        {
            return PI * Power(radius, 2);
        }

        public static float Circumference(float radius)
        {
            return PI * 2 * radius;
        }

        public static float TriArea(float bas, float height)
        {
            return (bas / 2) * height;
        }

        public static float PercentOf(float percent, float of) //ex. 20% of 40 is what?
        {
            return (percent * of) / 100;
        }

        public static int AsPercent(int x, int of) //ex. 20 is what percent of 40?
        {
            
            return (x * 100) / of;
        }
    }
}
