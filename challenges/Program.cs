namespace challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] output = ArrayReversal(arr);
            Console.WriteLine(string.Join(", ", output));
            int[] aarr = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            //int[] aarr = { 2,3,4,5 };
            Console.WriteLine($"The most frequent number is : {MostFrequent(aarr)}");
        }

        public static int[] ArrayReversal(int[] arr)
        {
            int[] arr2 = new int[arr.Length];

            for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++)
            {
                arr2[j] = arr[i];
            }

            return arr2;
        }


        public static int MostFrequent(int[] aarr)
        {
            int num = aarr[0];
            int count = 1;

            for (int i = 0; i < aarr.Length; i++)
            {
              int counter = 1;
             for (int j = i + 1; j < aarr.Length; j++)
             {
            if (aarr[i] == aarr[j])
             {
               counter++;
            }
            }

            if (counter > count)
          {
             count = counter;
            num = aarr[i];
           }
           }

            if (count == 1)
            {
             num = aarr[0];
            }

            return num;
        }
    }
}
