namespace challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3 ,1,2,3};      
            //Console.WriteLine("Duplicates: " + string.Join(", ", Find_Duplicates.FindDuplicates(arr)));

            int[] arr1 = { 5, 10, 15, 20 };
            int[] arr2 = { 10, 15, 25 };
            Console.WriteLine("Input: " + string.Join(", ", arr1)+ " and "+ string.Join(", ", arr2));

            Console.WriteLine("Common Elements: " + string.Join(", ", Common_Elements.Common_Elements.CommonElements(arr1, arr2)));
        }

    }
}