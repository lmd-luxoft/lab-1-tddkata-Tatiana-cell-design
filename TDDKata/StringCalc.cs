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

            string[] s = v.Split(',');
            int k = 0;
            int arg1 = 0;
            int arg2 = 0;
            

            foreach (var arg0 in s)
            {
               // list.Add(arg0.Trim());
                string arg3 = arg0.Trim();

                Console.WriteLine(arg3);
                k++;
                if (k == 1) {
                    bool res1 = int.TryParse(arg3, out arg1);
                    if ((!res1) || (arg1 > 2) || (arg1 < 0)) {
                        throw new Exception("Неверное значение первого аргумента");
                    }   
                }
                if (k == 2)
                    {
                    bool res2 = int.TryParse(arg3, out arg2);
                    if ((!res2) || (arg2 > 2) || (arg2 < 0)) 
                       {
                        throw new Exception("Неверное значение второго аргумента");
                        }
                }
                if (k == 3)
                    {
                    throw new Exception("Ошибка. Количество аргументов в строке >= 3"); 
                     }

            }

            return arg1 + arg2;
        }
    }
}