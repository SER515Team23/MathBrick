using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBrick
{
    /// <summary>
    /// 在新建实例时传参
    /// </summary>
    class Calculation
    {
        private string inputString1;
        private string inputString2;

        //此构造函数用于解普通计算、一元一次方程和一元二次方程
        public Calculation(string str)
        {
            inputString1 = str;
        }

        //此构造函数用于解二元一次方程组
        public Calculation(string str1, string str2)
        {
            inputString1 = str1;
            inputString2 = str2;
        }

        /// <summary>
        /// 可以处理字符串形式的算式，如"3*(6+7)-73/5"，不能有空格和等号
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
        /// 现在可以处理如"-3x-6=7x+11"这种形式的以字符串传入的方程，不能有空格、乘除号和括号
        /// </summary>
        /// <returns></returns>
        public string LinearEquation()
        {
            try
            {
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
            int[] sum = new int[2];   //sum[0]存常数，sum[1]存x前面的系数
            int currentNum = 0, symbol = 1;   //symbol取符号，初始默认正数，currentNum取当前读到的数字
            int firstNum = 0; //firstNum用于存放一个数
            for (int i = 0; i < s.Length; i++)
            {

                char currentChar = s[i];   //currentChar取当前字符
                if (currentChar == '+')
                {
                    sum[0] += symbol * firstNum; //读到“+”时，说明当前读到的是一个常数，存入常数数组
                    symbol = 1;  //读取到“+”时，将符号置为1，代表加一个正数
                    firstNum = 0; //存完一个数之后，记得将该变量置为0，以便存储后续的数
                }
                else if (currentChar == '-')
                {
                    sum[0] += symbol * firstNum;
                    symbol = -1; //读取到“-”时，将符号置为-1，代表加一个负数	
                    firstNum = 0;
                }
                else if (currentChar == 'x')
                {
                    if (firstNum == 0)
                        firstNum = 1;
                    sum[1] += symbol * firstNum; firstNum = 0;
                }
                else //不是‘+’，‘-’，‘x’则说明当前字符是一个数字
                {
                    currentNum = Convert.ToInt32(currentChar) - 48;
                    firstNum = firstNum * 10 + currentNum * symbol;
                    symbol = 1;
                    if (i == s.Length - 1)    //当读取到最后一位不是x且还未结束时，说明当前是一个常数，累积加到常数中
                        sum[0] += symbol * firstNum;
                }
            }
            return sum;

        }

        /// <summary>
        /// ax^2 + bx + c = 0, if b^2-4ac<0 , no solution, else x1 = (-b + sqrt(b^2 - 4ac))/2a , x2 = (-b - sqrt(b^2 - 4ac))/2a
        /// 可以支持的字符串格式基本同一元一次方程，如"x^2+4x-6=2x^2+x-5"
        /// </summary>
        /// <returns></returns>
        public string QuadraticEquation()
        {
            try
            {
                int a = 0;
                int b = 0;
                int c = 0;
                string[] splitStringArray = inputString1.Split('=');
                int[] left = AddForCalculateQuadratic(splitStringArray[0]);
                int[] right = AddForCalculateQuadratic(splitStringArray[1]);

                a += left[0];
                b += left[1];
                c += left[2];

                a -= right[0];
                b -= right[1];
                c -= right[2];

                if (Math.Pow(b, 2) - 4 * a * c >= 0)
                {
                    return ("x1=" + (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a) + ("x2=" + (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a);
                }
                else
                {
                    return "No Solution!";
                }
            }
            catch(Exception ex)
            {
                return "error";
            }
        }

        private static int[] AddForCalculateQuadratic(string s)
        {
            int[] sum = new int[3];   //sum[0]存常数，sum[1]存x前面的系数
            int currentNum = 0, symbol = 1;   //symbol取符号，初始默认正数，currentNum取当前读到的数字
            int firstNum = 0; //firstNum用于存放一个数
            for (int i = 0; i < s.Length; i++)
            {

                char currentChar = s[i];   //currentChar取当前字符
                if (currentChar == '+')
                {
                    sum[0] += symbol * firstNum; //读到“+”时，说明当前读到的是一个常数，存入常数数组
                    symbol = 1;  //读取到“+”时，将符号置为1，代表加一个正数
                    firstNum = 0; //存完一个数之后，记得将该变量置为0，以便存储后续的数
                }
                else if (currentChar == '-')
                {
                    sum[0] += symbol * firstNum;
                    symbol = -1; //读取到“-”时，将符号置为-1，代表加一个负数	
                    firstNum = 0;
                }
                else if (currentChar == 'x')
                {

                    if (firstNum == 0)
                        firstNum = 1;

                    if (i != s.Length - 1)  //如果此x不在最后一位，则检查其下一位有没有‘^’
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
                else if (currentChar == '^') //读取到“^”时，i多加一次，忽略掉后面的2；
                {
                    i++;
                }
                else //不是‘+’，‘-’，‘x’则说明当前字符是一个数字
                {
                    currentNum = Convert.ToInt32(currentChar) - 48;
                    firstNum = firstNum * 10 + currentNum * symbol;
                    symbol = 1;
                    if (i == s.Length - 1)    //当读取到最后一位不是x且还未结束时，说明当前是一个常数，累积加到常数中
                        sum[0] += symbol * firstNum;
                }
            }
            return sum;
        }
        public string BinaryEquation()
        {
            return "error";
        }
    }
}

