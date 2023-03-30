using System;
namespace BubbleSortD
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[]array=new int[11]{45,33,12,55,77,22,33,14,67,12,35};
            int i,j,temp;
            for(i=0;i<array.Length-1;i++)
            {
                for(j=0;j<array.Length-1;j++)
                {
                    if(array[j]<array[j+1])
                    {
                        temp=array[j];
                        array[j]=array[j+1];
                        array[j+1]=temp;
                    }
                }
            }
            for(i=0;i<array.Length-1;i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}
