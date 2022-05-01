using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Programme to display the current thread name
    internal class MultiThreading
    {
        public static void Main()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "MainThread";
            Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine(t.Name);
        }
    }
}

//Multi Threading:-

//Multitasking:-Multitasking is to help us to process multiple task at same time. It have ability to run multiple operation at same time.
//Ex- on window multiple task have been open at same time.
//Operating Syatem Process Management-  Like chrome, notepad, other application at same time will run. OS is internally generate the process. 
//Process is the part of os and component of os which is responsible to execute each and every programme.
//All application which is running is process. 

//What is thread?
//Ans: Thread is nothing but is a light weight process.In simple word thread is nothing but unit of process which is responsible to executing 
//the application or code.
//Under this process, all your appplication run.
//and to run all the application we need process.

//As we know that each and every programme have some block of code or programme or some logic to execute. There thread come into picture.
//By default every process have single thread.Which is responsible to executing the application and that thread is called as the main thread
//so we can say that each application is at list the single thread application.

//Note:- All threading related classes in c# belong to system.threading namespace. In all application we have main() method which is working 
//as a thread to execute our logic.
//Single thread Application all the logic or code which is present in to programme will be executed by the single thread which is Main Method.
//To remove the overburden on Main method multi threading concept came into picture.So in it we will segregate the whole code in multiple block
//of code.and each block of code will work like the thread.
