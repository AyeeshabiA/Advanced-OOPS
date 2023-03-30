using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[]array=new int[20]{45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77  };
            int i;
            int searchElement=66;
            int flag=0;
            for(i=0;i<array.Length-1;i++)
            {
                
                    if(searchElement==array[i])
                    {
                        flag=1;
                        Console.WriteLine("Index: "+i);
                    }
                    
            }
            if(flag==0)
            {
                Console.WriteLine("Element not found");
            }
           
        }
    }
}
