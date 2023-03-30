using System;
namespace SelectionSortA
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[]array=new int[11]{45,33,12,55,77,22,33,14,67,12,35};
            int i,j,temp;
            for(i=0;i<array.Length-1;i++)
            {
                int index=i;
                for(j=i+1;j<array.Length;j++)
                {
                    if(array[j]<array[index])
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



