using System;
using System.Collections.Generic;

namespace MyCodeTestSandbox
{
    public class CommomElementsInTwoSortedArraysClass
    {
        public void Run()
        {
            var list1 = new List<int>
            {
                1, 3, 4, 6, 7, 9
            };
            var list2 = new List<int>
            {
                1, 2, 4, 5, 9, 10
            };

            Console.WriteLine(String.Join(" ", GetCommomElementsInTwoSortedArrays(list1, list2)));
        }

        private List<int> GetCommomElementsInTwoSortedArrays(List<int> p_List1, List<int> p_List2)
        {
            var commomElementsList = new List<int>();

            var currentIndex1 = 0;
            var currentIndex2 = 0;

            while (currentIndex1 < p_List1.Count && currentIndex2 < p_List2.Count)
            {
                if (p_List1[currentIndex1] == p_List2[currentIndex2])
                {
                    commomElementsList.Add(p_List1[currentIndex1]);
                    currentIndex1++;
                    currentIndex2++;
                }
                else
                {
                    if (p_List1[currentIndex1] < p_List2[currentIndex2])
                        currentIndex1++;
                    else
                        currentIndex2++;
                }
            }

            return commomElementsList;
        }
    }
}
