using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[]array=new double[6]{1.1,65.3,93.9,55.5,3.5,6.9  };
            int i;
            double searchElement=3.5;
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
