using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[]array=new int[20]{45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77  };
            Array.Sort(array);
            int start=0,end=array.Length-1;
            int searchElement=66;
            while(start<=end)
            {
               int mid=(start+end)/2;
               if(searchElement==array[mid])
               {
                   Console.WriteLine("Index: "+mid);
                   break;
               }
               else if(searchElement<array[mid])
               {
                   end=mid-1;
               }
               else
               {
                   start=mid+1;
               }
            }
           
        }
    }
}

