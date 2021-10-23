using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvings
{
    public class Diagonal_Difference
    {
        public Diagonal_Difference()
        {
            //int[][] arr = new int[n][];

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}
            //diagonalDifference(arr);
            //long result =pthFactor(22876792454961, 28);
            /*long result = pthFactor(20, 3);
            Console.WriteLine(result);*/

            //List<string> list = groupTransactions(new List<string> { "bin", "can", "bin", "bin" });

            //var a = weightCapacity(new List<int> { 1, 3, 5 }, 7);


            var aa = 0;




        }
        public int diagonalDifference(int[][] arr)
        {
            int groupA = 0, groupB = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                    {
                        groupA = groupA + arr[i][j];
                    }
                    if (i == (arr.Length - j - 1))
                    {
                        groupB = groupB + arr[i][j];
                    }
                }
            }
            return Math.Abs(groupA - groupB);
        }





        //public static long pthFactor0(long n, long p)
        //{
        //    //Dictionary<long, long> dictionary = new Dictionary<long, long>();
        //    long[] array=new long[] { };
        //    int index = 0;
        //    List<long> list = new List<long>();
        //    for (long i = 1; i <= n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            //dictionary.Add(index, i);
        //            array[index] = i;
        //            index = index + 1;
        //        }
        //    }
        //    if (p > array.Length) { return 0; }
        //    /*if (p > dictionary.Count) { return 0; }*/
        //    return array[p];
        //    //long result = 0;
        //    /*if (dictionary.TryGetValue((p), out result))
        //    {
        //        return result;
        //    }*/
        //    //return result;
        //}
        //public static long pthFactor(long n, long p)
        //{
        //    Dictionary<long, long> dictionary = new Dictionary<long, long>();
        //    int index = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            dictionary.Add(index, i);
        //            index = index + 1;
        //        }
        //    }
        //    if (p > dictionary.Count) { return 0; }
        //    long result = 0;
        //    if (dictionary.TryGetValue((p), out result))
        //    {
        //        return result;
        //    }
        //    return result;
        //}
        //public static List<string> groupTransactions(List<string> transactions)
        //{
        //    //transactions.Sort();
        //    Dictionary<string,int> keyValuePairs=new Dictionary<string, int>();
        //    List<string> list = new List<string>();
        //    foreach(string a in transactions)
        //    {
        //        if (!keyValuePairs.ContainsKey(a))
        //        {
        //            keyValuePairs.Add(a, 1);
        //        }
        //        else
        //        {
        //            if(keyValuePairs.ContainsKey(a))
        //            {
        //            keyValuePairs[a] = keyValuePairs[a] + 1;
        //            }
        //        }
        //    }
        //    foreach(var a in keyValuePairs)
        //    {
        //        list.Add(a.Key.ToString() + " " + a.Value);
        //    }
        //    list.Sort();
        //    return list;
        //}

        //public static long getMaxUnits(List<long> boxes, List<long> unitsPerBox, long truckSize)
        //{
        //    var boxarrray=boxes.ToArray();
        //    var unitsarray = unitsPerBox.ToArray();
        //    Dictionary<string, long> dict = new Dictionary<string, long>();
        //    for(int i = 0; i < boxarrray.Length; i++)
        //    {
        //        dict.Add(boxarrray[i].ToString(), unitsarray[i]);
        //    }
        //    foreach(var a in dict)
        //    {

        //    }
        //    return 0;
        //}
        //public static int weightCapacity(List<int> weights, int maxCapacity)
        //{
        //    int maxLift = 0;
        //    Dictionary<int, int> dictInit = new Dictionary<int, int>();
        //    Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

        //    int index = 0;
        //    foreach(var w in weights)
        //    {
        //        index = index + 1;
        //        dictInit.Add(index, w);
        //    }
        //    foreach (var w in weights)
        //    {
        //        foreach (var ww in dictInit.Values)
        //        {

        //            index = index + 1;
        //            dict.Add(index, new List<int> { w,ww});
        //        }
        //    }
        //    foreach(var ab in dictInit)
        //    {
        //        index = index + 1;
        //        dict.Add(index, new List<int> { ab.Value });
        //    }



        //    foreach(var a in dict)
        //    {
        //        int smallSum = 0;
        //        foreach (int i in a.Value)
        //        {
        //            smallSum = smallSum + i;
        //        }
        //        if(smallSum> maxLift && smallSum<=maxCapacity)
        //        {
        //            maxLift = smallSum;
        //        }
        //    }

        //    return maxLift;
        //}
    }
}
