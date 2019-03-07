using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0707995_Assignment2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Student Name Harsimran Singh Student Id C0707995
            //CSD3354 Section 2 
            //Assignmnet 2
            //March 7,2019
            DelegateExcercises a = new DelegateExcercises();
            a.Method2();
        }
    }


    public class DelegateExcercises
    {
        public delegate int MyDelegate(int intValue);

        private int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }
        public void Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result = myDelegate(10);
            System.Console.WriteLine(result1);
            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);
        }
    }

}

