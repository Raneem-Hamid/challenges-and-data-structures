using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges.Common_Elements
{
    public class Common_Elements
    {
        public static int[] CommonElements(int[] arr1 , int[] arr2)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                int num = arr1[i];
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (num == arr2[j] && !result.Contains(num))
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
