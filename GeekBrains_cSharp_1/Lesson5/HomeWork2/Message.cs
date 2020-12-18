using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Message
    {
        public static void DisplayCustomLengthWords(string[] arr, int numLetter, out string newStr)
        {
            List<string> newArr = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= numLetter)
                {
                    newArr.Add(arr[i]);
                }
            }
            newStr = String.Join(" ", newArr);
        }

        public static void RemoveCurrentWord(string[] arr, char simbol, out string newStr)
        {
            List<string> newArr = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i][arr[i].Length - 1] != simbol)
                {
                    newArr.Add(arr[i]);
                }
            }
            newStr = String.Join(" ", newArr);
        }

        public static void FindMaxWords(string[] arr, out string newStr)
        {
            StringBuilder sb = new StringBuilder();
            int max = 0;
            String maxStr = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i].Length)
                {
                    max = arr[i].Length;
                    maxStr = arr[i];
                }
            }
            sb.AppendFormat("{0} ",maxStr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (!StringComparer.OrdinalIgnoreCase.Equals(maxStr,arr[i]) && maxStr.Length == arr[i].Length)
                {
                    if (i == arr.Length - 1)
                    {
                        sb.Append(arr[i]);
                    }
                    else 
                    {
                        sb.AppendFormat("{0} ", arr[i]);
                    }
                }
            }  
            newStr = string.Join(",", sb.ToString());
        }

    }
}
