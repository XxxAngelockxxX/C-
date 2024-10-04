using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Task1 : ITaskeable
    {
        private int[] your_nums = new int[3];
        public void Inicelisation_chek() {
            
            for (int i = 0; i < your_nums.Length; i++)
            {
                Console.WriteLine("input " + (i + 1) + " Storonu");
                your_nums[i] = int.Parse(Console.ReadLine());
                if (your_nums[i] > 26 && your_nums[i] <1)
                {
                    Console.WriteLine("Incorrect num");
                }
                else
                {
                    Console.WriteLine(your_nums[i]);
                }
            }
        }
        public void StartTask()
        {
            Inicelisation_chek();
             
        }
    }
}
