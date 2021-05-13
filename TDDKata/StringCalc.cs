// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;

namespace TDDKata
{
    internal class StringCalc
    {

        internal int Sum(string v)
        {
            // throw new NotImplementedException();ArgumentOutOfRangeException}
            //  ArrayList list = new ArrayList();
            char[] delimiterChars = { ',','\n' };

            string[] s = v.Split(delimiterChars);
            int arg1 = 0;
            int arg2 = 0;
            

            foreach (var arg0 in s)
            {
                //list.Add(arg0.Trim());
                string arg3 = arg0.Trim();

              //  Console.WriteLine(arg3);
                
                bool res1 = int.TryParse(arg3, out arg1);
                if ((!res1) || (arg1 > 2) || (arg1 < 0))
                {
                    Console.WriteLine("@@@@"+ arg1);
                    throw new Exception("Неверное значение аргумента");
                }
                else 
                { arg2 += arg1;
                  Console.WriteLine(arg2);
                };  
                 
                 
            }

            return arg2;
        }
    }
}