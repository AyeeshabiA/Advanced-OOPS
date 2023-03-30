using System;
namespace SelectionSortA
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
                int index=i;
                for(j=i+1;j<array.Length;j++)
                {
                    if(array[j]>array[index])
                    {
                        index=j;
                    }
                }
                if(index!=i)
                {
                    temp=array[i];
                    array[i]=array[index];
                    array[index]=temp;
                }
            }
            for(i=0;i<=array.Length-1;i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}





