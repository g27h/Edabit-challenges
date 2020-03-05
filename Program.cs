using System;
/** Quick things learned:
 * - To create a project in Visual Studio Code: use "dotnet new console" to create a new console application
 * - then run "dotnet build" to build the project, and "dotnet restore"
 * */
using System.Text.RegularExpressions;
using System.Runtime;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
namespace Edabit_challenges
{
    class Program
    {
        /**
         * the location of all of the testing for the new functions in their respective classes
         * */
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string[] arr = {"Algorism","PasSword","Dermatoglyphics","Cat","Filmography","Moose","Consecutive"};
            foreach (string str in arr){
                System.Console.WriteLine(IsIsogram.IsIsogram2(str));
            }
        }
    }
}