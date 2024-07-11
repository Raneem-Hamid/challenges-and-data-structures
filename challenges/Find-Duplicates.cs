using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges
{
    public class Find_Duplicates
    {

        public static int[] FindDuplicates(int[] arr)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (num == arr[j] && !result.Contains(num))
                    {
                        result.Add(num);
                        break; 
                    }
                }
            }

            return result.ToArray();
        }
    }
}
