using System;
using System.Collections.Generic;

namespace MyCodeTestSandbox
{
    public class MostFrequentInArrayClass
    {
        public void Run()
        {
            var list = new List<int>
            {
                1, 3, 1, 3, 2, 1
            };

            Console.WriteLine(GetMostFrequent(list));
        }

        private int GetMostFrequent(List<int> p_List)
        {
            var dictionary = new Dictionary<int, int>();
            var currentMostFrequent = 0;

            foreach(var integer in p_List)
            {
                int valueInDictionary = 0;
                if (dictionary.TryGetValue(integer, out valueInDictionary))
                {
                    dictionary[integer] += 1;
                    if(currentMostFrequent == 0 || dictionary[integer] > dictionary[currentMostFrequent])
                        currentMostFrequent = integer;
                }
                else
                    dictionary.Add(integer, 1);
            }

            return currentMostFrequent;
        }
    }
}
