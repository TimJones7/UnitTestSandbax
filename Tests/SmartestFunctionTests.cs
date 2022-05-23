using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSandbax.Tests
{
    public static class SmartestFunctionTests
    {
        //  Naming Conventions with Unit Test
        //  ClassName_MethodName_ExpectedResult()
        public static void SmartestFunction_ReturnsHasBigDick_ReturnsString()
        {
            try
            {
                //  {TRIPLE A TESTING}
                //  ARRANGE -> Go get your variables, whatever you need, classes, functions
                int num = 0;
                SmartestFunction smartestFunction = new SmartestFunction();

                //  ACT -> Execute this function
                string result = smartestFunction.ReturnsHasBigDick(num);

                //  ASSERT -> Whatever is returned, is it what you want?
                if (result == "big old floppy dick")
                {
                    Console.WriteLine("PASSED: SmartestFunction.ReturnsHasBigDick_ReturnsString");
                }
                else
                {
                    Console.WriteLine("FAILED: SmartestFunction.ReturnsHasBigDick_ReturnsString");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
