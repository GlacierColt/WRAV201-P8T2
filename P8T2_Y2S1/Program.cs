using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P8T2_Y2S1
{
    internal class Program
    {
        const int NUM = 5;
        int[] array = new int[NUM];
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            for (int i = 0; i < NUM; i++)
            {
                Console.Write("Enter int: ");
                array[i] = int.Parse(Console.ReadLine());

            }
            SelectionSort2();
            for (int i = 0; i < NUM; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
            Console.ReadLine();
        }

        public void SelectionSort2()
        {
            int minPos;
            for (int pass = 0; pass < array.Length - 1; pass++)
            {
                minPos = FindMinPos(pass);   //Elements before pass are already sorted                

                int temp = array[pass];
                array[pass] = array[minPos];
                array[minPos] = temp;
            }
        }

        public int FindMinPos(int pass)
        {
            if (pass == array.Length - 1)
            {
                return pass;
            }
            int minPos = FindMinPos(pass + 1);
            if (array[pass] < array[minPos])
            {
                return pass;
            }
            else
            {
                return minPos;
            }
        }

    }
}
