using System;
namespace InsertionSortA
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[]array=new char[12]{'c','a','f','b','k','h','z','t','m','p','l','d'};
            int i,j;
            char temp;
            for(i=0;i<array.Length-1;i++)
            {
                for(j=i+1;j>0;j--)
                {
                    if(array[j]<array[j-1])
                    {
                        temp=array[j];
                        array[j]=array[j-1];
                        array[j-1]=temp;
                    }
                }
            }
            for(i=0;i<=array.Length-1;i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}


