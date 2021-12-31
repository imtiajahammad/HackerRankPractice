using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvings
{
    public class Migratory_Birds
    {
        /// Given an array of bird sightings where every element represents a bird type id,
        /// determine the id of the most frequently sighted type. 
        /// If more than 1 type has been spotted that maximum amount, 
        /// return the smallest of their ids.
        /// arr=[1,1,2,2,3]
        /// There are two each of types 1  and 2, and one sighting of type 3. Pick the lower of the two types seen twice: type 1.
        ///    
        public Migratory_Birds()
        {
            int res=migratoryBirds(new List<int>(){1,1,2,2,3});
            Console.WriteLine("Result is {0}",res);
        }
        public static int migratoryBirds(List<int> arr)
        {
            return 0;
        }


    }
}
