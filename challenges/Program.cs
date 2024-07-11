namespace challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 ,1,2,3};      
            Console.WriteLine("Duplicates: " + string.Join(", ", Find_Duplicates.FindDuplicates(arr)));
        }

    }
}