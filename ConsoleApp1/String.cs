using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class String
    {
        private char[] arr;
        private int size=0;

        public void SetArr(char[]array)
        {
            
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 91 && array[i] <= 121)
                {
                    size++;
                    
                }
            }
            arr = new char[size];

            size = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 91 && array[i] <= 121)
                    {
                        arr[size] = array[i];
                    size++;
                    }
                }
        }

        public char[] Sort()
        {
            char temp;
            for(int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j<arr.Length; j++) 
                {
                    if (arr[i] > arr[j])
                    {
                       
                            temp = arr[i];
                            arr[i] =arr[j];
                           arr[j] = temp;
                        
                    }
                }
            }
        

            return arr;
        }

        public char[] GetArr()
        {
            return arr;
        }

    }
}
