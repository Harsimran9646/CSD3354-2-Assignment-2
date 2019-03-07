using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0707995_Assignment2
{
    public class Program
    {
        public static void Main()
        {
            //Student Name Harsimran Singh Student Id C0707995
            //student name Sukhraj singh student Id C0709562
            //CSD3354 Section 2 
            //Assignmnet 2
            //March 7,2019
            DelegateExcercises delegateExcercises = new DelegateExcercises();
            delegateExcercises.Method3();
            Console.ReadLine();
        }
    }

    public delegate int MyDelegate(out int i);
    public class DelegateExcercises
    {
        int Method1(out int i )
        { 
        i = 100;
        System.Console.WriteLine("Method1" +i);
        return 0;
        }
      
   public void Method3()



            {
            MyDelegate myDelegate = new MyDelegate(Method1);
            MyDelegate myDelegate1 = null;
            MyDelegate myDelegate2 =  myDelegate+myDelegate1;
            int intValue;
            myDelegate2(out intValue);
            }
        }
    
}



