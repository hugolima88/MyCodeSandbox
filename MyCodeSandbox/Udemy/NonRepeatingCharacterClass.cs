using System;
using System.Collections.Generic;

namespace MyCodeTestSandbox
{
    public class NonRepeatingCharacterClass
    {
        public void Run()
        {
            var array = new string[] { "a", "b", "a", "b", "c", "d" };
            Console.WriteLine(GetNonRepeatingCharacter(array));
        }

        private string GetNonRepeatingCharacter(string[] p_Array)
        {
            string nonRepeatingCharacter = null;
            var dic = new Dictionary<string, int>();

            foreach (var value in p_Array)
            {
                int currentValueTimes = 0;
                if (dic.TryGetValue(value, out currentValueTimes))
                {
                    dic[value] = ++currentValueTimes;

                    if (value.Equals(nonRepeatingCharacter))
                        nonRepeatingCharacter = null;
                }
                else
                {
                    dic.Add(value, 1);

                    if (nonRepeatingCharacter == null)
                        nonRepeatingCharacter = value;
                }
            }

            return nonRepeatingCharacter;
        }
    }
}
