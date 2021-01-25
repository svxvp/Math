using System;
using System.Diagnostics;


namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            var Watch = Stopwatch.StartNew();
            int[] array = new int[15000];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            { array[i] = rnd.Next(); }
            sort.SelectionSorting(array);
            Console.WriteLine("Time: {0} ms", Watch.ElapsedMilliseconds);
            Console.ReadKey();


        }
    }

    public class Sort
    {
        public void SelectionSorting(int[]data) 
        {
            int temp = 0;
           
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
            
            Console.WriteLine(string.Join(",",data));
            
           
        }

        public void InsertionSorting(int[]data)
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
            Console.WriteLine(string.Join(",", data));
        }

      
    }
}
