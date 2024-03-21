using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinSearch
{
    public class BinarySearch
    {
        public string DoSort(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }

        public int BinSearch_int(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;

        }

        public int BinSearch_txt(string[] array, string target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int comparison = string.Compare(array[mid], target);

                if (comparison == 0)
                {
                    return mid;
                }
                else if (comparison < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        public int Search(List<Contact> contacts, string target)
        {
            int left = 0;
            int right = contacts.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int comparison = string.Compare(contacts[mid].LastName, target);

                if (comparison == 0)
                {
                    return mid;
                }
                else if (comparison < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
