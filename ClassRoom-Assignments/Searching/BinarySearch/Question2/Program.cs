using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[]array=new char[15]{'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'   };
            Array.Sort(array);
            Console.WriteLine(array);
            int start=0,end=array.Length-1;
            char searchElement='m';
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

