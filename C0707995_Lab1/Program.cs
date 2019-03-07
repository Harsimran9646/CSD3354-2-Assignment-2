using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0707995_Assignment2
{
    internal class Program
    {
        public static void Main()
        {
            //Student Name Harsimran Singh Student Id C0707995
            //CSD3354 Section 2 
            //Assignmnet 2
            //March 7,2019
            DelegateExcercises delegateExcercises = new DelegateExcercises();
            delegateExcercises.Method3();
            Console.ReadLine();
        }
    }

    public delegate void MyDelegate();
    public class DelegateExcercises
    {
       

      void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            
           
           myDelegate();
        }
        }
    }



