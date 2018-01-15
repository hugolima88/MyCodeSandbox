using System;

namespace MyCodeTestSandbox
{
    public class IsOneAwayClass
    {
        private const int MAX_ALLOWED_DIFFERENCES = 1;

        public void Run()
        {
            var array1 = new char[] { 'a', 'a', 'd' };
            var array2 = new char[] { 'a', 'a', 'c' };

            var program = new IsOneAwayClass();
            var isOneAway = program.IsOneAway(array1, array2);

            Console.WriteLine(String.Format("Is one away? {0}.", isOneAway));
        }

        private bool IsOneAway(char[] p_Array1, char[] p_Array2)
        {
            if (p_Array1.Length - p_Array2.Length > MAX_ALLOWED_DIFFERENCES ||
                p_Array2.Length - p_Array1.Length > MAX_ALLOWED_DIFFERENCES)
                return false;
            else if (p_Array1.Length == p_Array2.Length)
                return IsOneAwaySameLenght(p_Array1, p_Array2);
            else if (p_Array1.Length > p_Array2.Length)
                return IsOneAwayDifferentLenght(p_Array1, p_Array2);
            else
                return IsOneAwayDifferentLenght(p_Array2, p_Array1);
        }

        private bool IsOneAwaySameLenght(char[] p_Array1, char[] p_Array2)
        {
            int differencesCount = 0;

            for (int i = 0; i < p_Array1.Length; i++)
            {
                if (p_Array1[i] != p_Array2[i])
                    differencesCount++;

                if (differencesCount > MAX_ALLOWED_DIFFERENCES)
                    return false;
            }

            return true;
        }

        private bool IsOneAwayDifferentLenght(char[] p_Array1, char[] p_Array2)
        {
            int differencesCount = 0;
            int currentIndex = 0;

            while (currentIndex < p_Array2.Length)
            {
                if (p_Array1[currentIndex + differencesCount] != p_Array2[currentIndex])
                    differencesCount++;
                else
                    currentIndex++;

                if (differencesCount > MAX_ALLOWED_DIFFERENCES)
                    return false;
            }

            return true;
        }
    }
}
