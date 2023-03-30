using System;
namespace BubbleSort3A
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[]array=new double[6]{1.1,65.3,93.9,55.5,3.5,6.9};
            int i,j;
            double temp;
            for(i=0;i<array.Length-1;i++)
            {
                for(j=0;j<array.Length-1;j++)
                {
                    if(array[j]>array[j+1])
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
