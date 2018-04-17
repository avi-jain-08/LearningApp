using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp
{
    public class DivideByZero
    {
        // There are 2 Scenario when u catch the divide by Zero .
        // 1. if you put DivideByZeroException 1st then thr it will Handle Divide by Zero .It won't go to Expection catch block.
        //2. If you put DivideByZeroException1st 2nd (i.e. After the Exception), It will return a compile time Error saying that Base class (Exception) will catches all the Exception
        public void Exception()
        {
            int a = 5;
            int b = 0;
            try
            {
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException divEx)
            {
                Console.WriteLine("Divide By Zero : " + divEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Divide By Zero at base class : " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}