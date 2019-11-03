using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Author: Xinkai Wang
 * Description: Do normal calculation and solve equation
*/

namespace MathBrick
{
    /// <summary>
    /// Pass arguments when creating an instance
    /// </summary>
    class Calculation
    {
        private string inputString1 = "";
        private string inputString2 = "";

        private bool checkInputForEquation(string str)
        {
            if (str.Contains("*") || str.Contains("/") || str.Contains("(") || str.Contains(")") || !str.Contains("="))
                return false;
            return true;
        }

        //This constructor is used to solve ordinary computations, linear equations and quadratic equations
        public Calculation(string str)
        {
            inputString1 = str;
        }

        //This constructor is used to solve binary equations
        public Calculation(string str1, string str2)
        {
            inputString1 = str1;
            inputString2 = str2;
        }

        /// <summary>
        /// You can work with strings like "3*(6+7)-73/5" without Spaces or equal signs
        /// </summary>
        /// <returns></returns>
        public string Calculate()
        {
            try
            {
                var result = new System.Data.DataTable().Compute(inputString1, "");
                return result.ToString();
            }
            catch (Exception ex)
            {
                var errormassage = ex;
                return "error";
            }
        }

        /// <summary>
        /// if bx+a=0, then x=-a/b
        /// You can now deal with equations passed in as a string in the form of "-3x-6=7x+11" without Spaces, multiplication and division signs, and parentheses
        /// </summary>
        /// <returns></returns>
        public string LinearEquation()
        {
            try
            {
                if (!checkInputForEquation(inputString1))
                    return "error";
                int a = 0;
                int b = 0;
                string[] splitStringArray = inputString1.Split('=');
                int[] left = AddForCalculateLinear(splitStringArray[0]);
                int[] right = AddForCalculateLinear(splitStringArray[1]);
                //left of the equation
                a += left[0];
                b += left[1];

                //right of the equation
                a -= right[0];
                b -= right[1];
                if (b == 0)
                {
                    return "No Solution!";
                }
                else
                {
                    double v = (-a + 0.0) / b;
                    return "x=" + v.ToString();
                }
            }
            catch (Exception ex)
            {
                var errormassage = ex;
                return "error";
            }
        }

        private static int[] AddForCalculateLinear(string s)
        {
            int[] sum = new int[2];  
            int currentNum = 0, symbol = 1;   
            int firstNum = 0; 
            for (int i = 0; i < s.Length; i++)
            {

                char currentChar = s[i];  
                if (currentChar == '+')
                {
                    sum[0] += symbol * firstNum; 
                    symbol = 1;  
                    firstNum = 0; 
                }
                else if (currentChar == '-')
                {
                    sum[0] += symbol * firstNum;
                    symbol = -1;
                    firstNum = 0;
                }
                else if (currentChar == 'x')
                {
                    if (firstNum == 0)
                        firstNum = 1;
                    sum[1] += symbol * firstNum; firstNum = 0;
                }
                else
                {
                    currentNum = Convert.ToInt32(currentChar) - 48;
                    firstNum = firstNum * 10 + currentNum * symbol;
                    symbol = 1;
                    if (i == s.Length - 1)    
                        sum[0] += symbol * firstNum;
                }
            }
            return sum;

        }

        /// <summary>
        /// ax^2 + bx + c = 0, if b^2-4ac<0 , no solution, else x1 = (-b + sqrt(b^2 - 4ac))/2a , x2 = (-b - sqrt(b^2 - 4ac))/2a
        /// The string format that can be supported is basically the same primitive primary equation, such as "x^2+4x-6=2x^2+x-5".
        /// </summary>
        /// <returns></returns>
        public string QuadraticEquation()
        {
            try
            {
                if (!checkInputForEquation(inputString1))
                    return "error";
                int a = 0;
                int b = 0;
                int c = 0;
                string[] splitStringArray = inputString1.Split('=');
                int[] left = AddForCalculateQuadratic(splitStringArray[0]);
                int[] right = AddForCalculateQuadratic(splitStringArray[1]);

                a += left[2];
                b += left[1];
                c += left[0];

                a -= right[2];
                b -= right[1];
                c -= right[0];

                if (Math.Pow(b, 2) - 4 * a * c >= 0)
                {
                    return ("x1=" + (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a) + ("    x2=" + (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a);
                }
                else
                {
                    return "No Solution!";
                }
            }
            catch (Exception)
            {
                return "error";
            }
        }

        private static int[] AddForCalculateQuadratic(string s)
        {
            int[] sum = new int[3];  
            int currentNum = 0, symbol = 1;   
            int firstNum = 0; 
            for (int i = 0; i < s.Length; i++)
            {

                char currentChar = s[i]; 
                if (currentChar == '+')
                {
                    sum[0] += symbol * firstNum; 
                    symbol = 1;  
                    firstNum = 0;
                }
                else if (currentChar == '-')
                {
                    sum[0] += symbol * firstNum;
                    symbol = -1; 
                    firstNum = 0;
                }
                else if (currentChar == 'x')
                {

                    if (firstNum == 0)
                        firstNum = 1;

                    if (i != s.Length - 1)  
                    {
                        if(s[i+1] == '^')   
                        {
                            sum[2] += symbol * firstNum; firstNum = 0;
                        }
                        else
                        {
                            sum[1] += symbol * firstNum; firstNum = 0;
                        }
                    }
                    else
                    {
                        sum[1] += symbol * firstNum; firstNum = 0;
                    }
                }
                else if (currentChar == '^') 
                {
                    i++;
                }
                else 
                {
                    currentNum = Convert.ToInt32(currentChar) - 48;
                    firstNum = firstNum * 10 + currentNum * symbol;
                    symbol = 1;
                    if (i == s.Length - 1)    
                        sum[0] += symbol * firstNum;
                }
            }
            return sum;
        }

        /// <summary>
        /// if ax+by=m; cx+dy=n, then x=(bn-dm)/(bc-ad); y=(an-cm)/(ad-bc)
        /// The string format that can be supported is basically the same primitive primary equation, such as str1 = "3x+4y+7=9x-3y-9"; str2 = "8x-3=3y+5";
        /// </summary>                             
        /// <returns></returns>
        public string BinaryEquation()
        {
            try
            {
                if (!checkInputForEquation(inputString1))
                    return "error";
                if (!checkInputForEquation(inputString2))
                    return "error";
                int a = 0, b = 0, m = 0;
                int c = 0, d = 0, n = 0;
                string[] splitStringArray1 = inputString1.Split('=');
                string[] splitStringArray2 = inputString2.Split('=');
                int[] left1 = AddForCalculateBinary(splitStringArray1[0]);
                int[] right1 = AddForCalculateBinary(splitStringArray1[1]);
                int[] left2 = AddForCalculateBinary(splitStringArray2[0]);
                int[] right2 = AddForCalculateBinary(splitStringArray2[1]);

                a += left1[1];
                b += left1[2];
                m -= left1[0];

                a -= right1[1];
                b -= right1[2];
                m += right1[0];

                c += left2[1];
                d += left2[2];
                n -= left2[0];

                c -= right2[1];
                d -= right2[2];
                n += right2[0];


                return "x=" + ((b * n - d * m) + 0.0) / (b * c - a * d) + ("    y=" + ((a * n - c * m) + 0.0) / (a * d - b * c));


            }
            catch (Exception)
            {
                return "error";
            }
        }

        private static int[] AddForCalculateBinary(string s)
        {
            int[] sum = new int[3];  
            int currentNum = 0, symbol = 1;   
            int firstNum = 0; 
            for (int i = 0; i < s.Length; i++)
            {

                char currentChar = s[i];   
                if (currentChar == '+')
                {
                    sum[0] += symbol * firstNum; 
                    symbol = 1;  
                    firstNum = 0; 
                }
                else if (currentChar == '-')
                {
                    sum[0] += symbol * firstNum;
                    symbol = -1; 	
                    firstNum = 0;
                }
                else if (currentChar == 'x')
                {

                    if (firstNum == 0)
                        firstNum = 1;
                    sum[1] += symbol * firstNum; firstNum = 0;

                }
                else if (currentChar == 'y')
                {
                    if (firstNum == 0)
                        firstNum = 1;
                    sum[2] += symbol * firstNum; firstNum = 0;
                }
                else 
                {
                    currentNum = Convert.ToInt32(currentChar) - 48;
                    firstNum = firstNum * 10 + currentNum * symbol;
                    symbol = 1;
                    if (i == s.Length - 1)    
                        sum[0] += symbol * firstNum;
                }
            }
            return sum;
        }
    }
}

