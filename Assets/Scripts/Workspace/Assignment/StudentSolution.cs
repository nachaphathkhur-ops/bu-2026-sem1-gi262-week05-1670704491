using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            for (int i = 0; i< numbers.Length; i++)
            {
                int minIndex = i;
                for(int j = i; j<numbers.Length; j++)
                {
                    if(numbers[j] < numbers[minIndex])
                    {
                        minIndex =j;
                    }
                }

                //int temp = numbers[minIndex];
                //numbers[minIndex] = numbers[i];
                //numbers[i] = temp;

                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            for(int i = 0; i < numbers.Length -1; i++)
            {
                for (int j =0; j<numbers.Length - i -1; j++)
                {
                    if (numbers[j]> numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j+1], numbers[j]);
                    }
                }
            }
            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            for (int i =1; i<numbers.Length; i++)
            {
                int cuurentElement = numbers[i];
                int j = i - 1;

                while(j>=0 && numbers[j]> cuurentElement)
                {
                    numbers[j+1]= numbers[j];
                    j--;
                }

                numbers[j + 1] = cuurentElement;
            }
            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        { 

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                (numbers[i], numbers[maxIndex]) = (numbers[maxIndex], numbers[i]);
            }

            return numbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            for(int i =0; i < numbers.Length-1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            }
            return numbers;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int cuurentElement = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] < cuurentElement)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = cuurentElement;
            }
            return numbers;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            int n = numbers.Length;

            
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                
                for (int j = 0; j < n - i - 1; j++)
                {
                    
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                        

                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
            int largest = numbers[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                if (numbers[i] < largest)
                {
                    return numbers[i];
                }
            }

            return 0;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            return 0;
        }

        #endregion
    }
}