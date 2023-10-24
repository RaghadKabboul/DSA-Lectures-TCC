using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            if (start <= end)

            {
                int middle1 =  (end + start) / 3;
                
                if (key == arr[middle1]) 
                    return middle1;
                if (key < arr[middle1])
                    return TernarySearch(arr, key, start, middle1 - 1);
                int middle2 = end - (end - start) / 3;
                if (key == arr[middle2])
                    return middle2;
                if (key < arr[middle2])
                    return TernarySearch(arr, key, middle1 + 1, middle2 - 1);
                return TernarySearch(arr, key, middle2 + 1, end);

            }

            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance

            int f_Index = -1;
            int l_index = -1;
            if (is_first==true)
            {
                while (start <= end)
                {
                    int middle = (start + end) / 2;
                    if (arr[middle] > key)
                    {
                        end = middle - 1;

                    }
                    else if (arr[middle] == key)
                    {
                        end = middle - 1;
                        f_Index = middle;
                    }
                    else
                    {
                        start = middle + 1;
                    }

                }
                if (f_Index != -1)
                    return f_Index;
                return -1;
            }
            start = 0;
            end = arr.Length - 1;
            while (start <= end)
            {
                int middle = (start + end) / 2;
                if (arr[middle] > key)
                {
                    end = middle - 1;
                }
                else if (arr[middle] == key)
                {
                    l_index = middle;
                    start = middle + 1;
                }
                else
                {
                    start = middle + 1;
                }
            }
            if (l_index != -1)
                return l_index;
            return -1;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            int count = 0;
            int f_index = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length - 1);
            if (f_index != -1)
            {
                int L_index = BinarySearchForCalculatingRepeated(arr, key, false, f_index, arr.Length - 1);
                count = L_index - f_index + 1;
            }
            return count;
        }
    }
}
