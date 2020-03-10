
namespace Edabit_challenges
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    public class FilterArray
    {
        /**
         * Possible classes used: Array, List, ArrayList
         * -List<T> class is the preferred class to ArrayList bc of the following:
         *      -It is type safe
         *      -ArrayList class is designed to hold heterogeneous collections of objects
         * 
         */
        public static int[] filterArray(object[] arr){
            //task: return string with only ints and no strings
            List<object> intList = new List<object>(); //create object List
            foreach (object i in arr){ //add items from object array to list
                intList.Add(i);
            }
            return intList.OfType<int>().ToArray(); //filter out all objects not of int and turn it into an array.

        }
    }
}