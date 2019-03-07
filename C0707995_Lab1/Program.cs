using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0707995_Assignment2
{
    internal class Program
    {
        public static void Main ()
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
            public delegate void MyDelegate();

        private void Method1()
            {
                Console.WriteLine("Method1");
                Console.ReadLine();
            }
            public void Method2()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }
        }
    
}

namespace DelegatesAnsEvents
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //To DO:Call Method2 from the DelegateExcercises class 
        }
    }
}
