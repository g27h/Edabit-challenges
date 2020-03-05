using System;
using System.Linq;
using System.Collections.Generic;
namespace Edabit_challenges
{
    public class IsIsogram
    {
        /**
         * What I Learned:
         * - how to use a try/catch case
         * - sometimes I can find the exceptions I need if I just run the program and see the one that pops up (haven't found an online source of exceptions yet)
         * - there technically is a way to CREATE YOUR OWN EXCEPTIONS
         * - I learned how to use lists better
         *     - I believe the "new List<char>()" part is actually using an empty constructor, though I could be wrong about this
         * - after looking at other solutions, a simple string could have been used to sort and count the number of unique characters which would determine if there are duplicates.
         * - how to use the "foreach" statement
         *      - the variable in the first part of the condition gives the whole unit that is returned
         * - strongly typed classes (like List<>), cannot have two different types that can do math operations on each other?
         *      - thus to do operations from lists with chars vs lists with integers, you must cast the chars to integers first, unlike other languages (like php)
         *  that have the option to not have to do this. In other words: the results will be UNEXPECTED
         * - Actually wrote code that can run methods of classes in other classes
         * - Determined the best way to push code to github is through creation of more classes for each
         *      function
         * */
        public static bool IsIsogram2(string str){
            str = str.ToLower(); //just make it lowercase
            //then make a list
            List<char> lst = new List<char>();//using empty constructor;blank list
            try{
                for(int i=0;i<str.Length;i++){
                    lst.Add(str[i]);
                }
                lst.Sort(); //sorts the list
                foreach(char s in lst){
                    System.Console.WriteLine("1st element: {0}",s);
                }
                for(int i=1;i<str.Length;i++){
                    if(lst[i]==lst[i-1]){
                        return false;
                    }
                }
                return true;
            }catch(System.ArgumentOutOfRangeException){ //return false if the index ever goes out of range (which it shouldn't)
                System.Console.WriteLine("throwing");
                return false;
            }
        }   
    }
}
