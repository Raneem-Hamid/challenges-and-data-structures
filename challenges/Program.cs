namespace challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] output = ArrayReversal(arr);
            Console.WriteLine(string.Join(", ", output));
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
    }
}
