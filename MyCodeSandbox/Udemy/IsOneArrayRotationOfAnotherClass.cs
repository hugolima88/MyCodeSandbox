using System;

namespace MyCodeTestSandbox
{
    public class IsOneArrayRotationOfAnotherClass
    {
        public void Run()
        {
            var array1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var array2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine(IsOneArrayRotationOfAnother(array1, array2));
        }

        private bool IsOneArrayRotationOfAnother(int[] p_Array1, int[] p_Array2)
        {
            if (p_Array1.Length != p_Array2.Length)
                return false;

            int index1 = 0;
            int index2 = GetIndex(p_Array1[0], p_Array2);

            while (index1 < p_Array1.Length)
            {
                if (p_Array1[index1] == p_Array2[index2])
                {
                    index1++;
                    index2++;

                    if (index2 == p_Array2.Length)
                        index2 = 0;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private int GetIndex(int p_Value, int[] p_Array)
        {
            for (int i = 0; i < p_Array.Length; i++)
            {
                if (p_Array[i] == p_Value)
                    return i;
            }
            return -1;
        }
    }
}
