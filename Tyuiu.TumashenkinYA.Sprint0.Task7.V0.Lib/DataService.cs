using System.Runtime.ExceptionServices;

namespace Tyuiu.TumashenkinYA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] resualArray = new int[5];
            for (var i = 0; i < resualArray.Length; i++)
            {
                resualArray[i] = numOne[i] + numTwo[i];
            }
            return resualArray;
        }
    }
}
