using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        //could hold 1, 1, 2, 3, 5, 8, 13, 21, 34...
        private int[] BaseSequence { get; set; }
       

        /*
       public override int GetNext(int current)
       {
           //'current' argument is read-only
           return current + Step;
       }

       public int[] GetSequence(int how_many)
       {
           int[] numbers = new int[how_many];
           numbers[0] = GetFirst(); //i = 1
           for (int i = 1; i < numbers.Length; i++)
           {
               numbers[i] = GetNext(numbers[i - 1]);
           }

           return numbers;
       }

       public string PrintNumbers(int[] number_array)
       {
           return String.Join(" ", number_array);
       }
       */
    }
}
