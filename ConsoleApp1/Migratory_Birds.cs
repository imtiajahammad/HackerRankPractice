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
            //int res=migratoryBirds(new List<int>(){1,1,2,2,3});//result is one
            //int res=migratoryBirds(new List<int>(){1 ,4 ,4 ,4 ,5 ,3});//result is 4
            int res=migratoryBirds(new List<int>(){1 ,2 ,3 ,4 ,5 ,4 ,3 ,2 ,1 ,3, 4});//result is 3


            Console.WriteLine("Result is {0}",res);
        }
        public static int migratoryBirds(List<int> arr)
        {
            int[] array=arr.ToArray();
            int selectedkey=0;
            int selectedValue=0; 
            Dictionary<int,int> dics=new Dictionary<int, int>();
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
                if(dics.ContainsKey(array[i]))
                {
                    var val=dics[array[i]];
                    dics[array[i]]=val+1;
                }
                else
                {
                    dics.Add(array[i],1);
                }
            }
            foreach(var a in dics){
                if(selectedValue<a.Value){
                    selectedValue=a.Value;
                    selectedkey=a.Key;
                }
                else if(selectedValue==a.Value && selectedkey >a.Key){
                    selectedkey=a.Key;
                    selectedValue=a.Value;
                }
            }
            return selectedkey;
        }


    }
}
