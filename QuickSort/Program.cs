using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        // Step1: Pick some element i.e. the pivot
        // Step 2: Split the array in 2 halves such that one half is < pivot and other > pivot
        // Step 3: move pivot into place
        // Step 4: sort left and right subparts
        private static void QuickSort(int[] InputArray, int left, int right) 
        {
            if (left < right)
            {
                int pivot = Partition(InputArray, left, right);

                if (pivot > 1) {
                    QuickSort(InputArray, left, pivot - 1);
                }
                if (pivot + 1 < right) {
                    QuickSort(InputArray, pivot + 1, right);
                }
            }
        
        }

        private static int Partition(int[] InputArray, int left, int right)
        {
            int pivot = InputArray[left];
            while (true) 
            {

                while (InputArray[left] < pivot) 
                {
                    left++;
                }

                while (InputArray[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (InputArray[left] == InputArray[right]) return right;

                    int temp = InputArray[left];
                    InputArray[left] = InputArray[right];
                    InputArray[right] = temp;


                }
                else 
                {
                    return right;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] InputArray = new int[] { 13, -88, 88, 1, 5, 6, 9, 17, 88, 100 };

            Console.WriteLine("Given input array : ");
            foreach (var item in InputArray)
            {
                Console.Write(" " + item);    
            }
            Console.WriteLine();

            QuickSort(InputArray, 0, InputArray.Length-1);
            
            Console.WriteLine();
            Console.WriteLine("Sorted array : ");
            foreach (var item in InputArray)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
