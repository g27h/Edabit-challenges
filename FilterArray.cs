
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
            //method: use mod?
            List<object> intList = new List<object>();
            foreach (object i in arr){
                intList.Add(i);
            }
            return intList.OfType<int>().ToArray();

        }
    }
}