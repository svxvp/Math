using System;

namespace Sort
{
    class Program
    {
        static void Main()
        {
            Sort sort = new Sort();
            
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            { array[i] = rnd.Next(1,51); }
            
            Console.WriteLine(String.Join(",",array));
            sort.SelectionSort(array);
            sort.PrintSortMassive(array);
            Console.ReadKey();
        }
    }
    
    public class Sort
    {
        public int[] SelectionSort(int[]data) 
        {
            int temp;
           
            for (int i = 0;i<data.Length-1;i++)
            {
                for(int j = 0;j< data.Length - 1 - i; j++)
                {
                    if(data[j+1]<data[j])
                    {
                        temp = data[j+1];
                        data[j+1] = data[j];
                        data[j] = temp;
                    }
                }
            }
            return data;
        }

        public int[] InsertionSort(int[]data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                int cur = data[i];
                int j = i;
                while (j > 0 && cur < data[j - 1])
                {
                    data[j] = data[j - 1];
                    j--;
                }
                data[j] = cur;
            }

            return data;
           
        }

        protected int[] QuickSorting(int[]data, long firstItem,long lastItem)
        {
            double p = data[(lastItem - firstItem) / 2 + firstItem]; 
            int temp;
            long i = firstItem, j = lastItem;
            while (i <= j)
            {
                while (data[i] < p && i <= lastItem) ++i;
                while (data[j] > p && j >= firstItem) --j;
                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    ++i; --j;
                }
            }
            if (j > firstItem) QuickSorting(data, firstItem, j);
            if (i < lastItem) QuickSorting(data, i, lastItem);
            return data;
        }
        public int[] QuickSort(int []data)
        {
            return QuickSorting(data, 0, data.Length - 1);
        }


        public void PrintSortMassive(int[]data)
        {   
            Console.WriteLine("Отсортированный массив\n"+String.Join(",",data));
        }
      
    }
}

