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
            a.Method3();
        }
    }


    public class DelegateExcercises
    {
        public delegate int MyDelegate();

        void Method1()
        {
            System.Console.WriteLine("MyDelegate");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
        }
    }



