using System;

namespace Developer
{
    public class TwoString
    {
        public static void StringNumberSum()
        {
            string s1 = "2358748975348927934678543895793649053";
            string s2 = "547563439958469048560043928434987096854890432";
            string sum = "";
            bool isNumber = true;
            if (s1.Substring(0, 1) != "-" && s2.Substring(0, 1) != "-")
            {
                int i = s1.Length - 1;
                int j = s2.Length - 1;
                int c = 0;
                while (i >= 0 && j >= 0 && isNumber)
                {
                    if (checkIsNumber(s1.Substring(i, 1)) && checkIsNumber(s2.Substring(j, 1)))
                    {
                        int total = Convert.ToInt32(s1.Substring(i, 1)) + Convert.ToInt32(s2.Substring(j, 1)) + c;
                        sum = total > 9 ? total % 10 + sum : total + sum;
                        c = total / 10;
                        i--;
                        j--;
                    }
                    else
                    {
                        isNumber = false;
                    }
                }
                while (i >= 0 && isNumber)
                {
                    if (checkIsNumber(s1.Substring(i, 1)))
                    {
                        sum = Convert.ToInt32(s1.Substring(i, 1)) + sum + c;
                        c = 0;
                        i--;
                    }
                    else
                    {
                        isNumber = false;
                    }
                    
                }
                while (j >= 0 && isNumber)
                {
                    if (checkIsNumber(s2.Substring(j, 1)))
                    {
                        sum = Convert.ToInt32(s2.Substring(j, 1)) + sum + c;
                        c = 0;
                        j--;
                    }
                    else
                    {
                        isNumber = false;
                    }
                    
                }
            }

            if(isNumber)
                Console.Write(sum);
            else
                Console.Write("Either of two given strings is negative or invalid string");
        }

        private static bool checkIsNumber(string number)
        {
            int num;
            bool result = int.TryParse(number, out num);
            return result;
        }
    }
}
