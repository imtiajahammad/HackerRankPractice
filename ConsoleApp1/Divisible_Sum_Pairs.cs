using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvings
{
    public class Divisible_Sum_Pairs
    {
        /// <summary>
        /// Given an array of integers and a positive integer k, determine the number of (i,j) pairs where i<j and ar[i] + ar[j]  is divisible by k.
        /// ar=[1,2,3,4,5,6]
        /// k=5
        /// Three pairs meet the criteria: [1,4], [2,3] and [4,6].
        /// </summary>
        public Divisible_Sum_Pairs()
        {
            int k=5;
            List<int> list=new List<int>{
                1,2,3,4,5,6
            };
            //int res=divisibleSumPairs(list.Count,k,list);
            int res=divisibleSumPairs(6,3,new List<int>{1,3,2,6,1,2});

            Console.WriteLine("result is {0}",res);
        }
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int countSets=0;
            int[] arr=ar.ToArray();
            for(int i=0;i<arr.Length-1;i++){
                Console.WriteLine(arr[i]);
                for(int j=i+1;j<arr.Length;j++){
                    if(i<j && ( (arr[i]+arr[j]) % k )==0 ){
                        countSets++;
                    }
                }

            }
            return countSets;
        }

    }
}
