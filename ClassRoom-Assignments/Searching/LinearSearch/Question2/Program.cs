using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[]array=new char[15]{ 'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d' };
            int i;
            char searchElement='m';
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
