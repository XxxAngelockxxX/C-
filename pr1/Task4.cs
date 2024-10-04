using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Task4: ITaskeable
    { 
        private int[] array_X = new int[36];
        public int MInput() { 
            int M;
            Console.WriteLine("Input your number");
            M = int.Parse(Console.ReadLine());
            return M;

        }
        public int Inicalisetion_X(int M)
        {
             int not_come = 0;
            for (int i = 0; i < array_X.Length; i++)
            {
                Console.WriteLine("Input " + (i+1) + " element ");
                array_X[i] = int.Parse(Console.ReadLine());
                if (array_X[i] == 0 || Math.Abs(array_X[i]) < M)
                {
                    not_come++;
                }
            }
            return not_come;
        }
        public void Output_array_X() 
        {
             Console.WriteLine(" Your Array X: ");
            for (int i = 0; i < array_X.Length; i++)
            {
                Console.Write(array_X[i] + ", ");
            }
            Console.WriteLine();
        }
        public void Inicalisetion_and_output_Y(int not_come , int M)
        {            
            int[] array_Y = new int[36-not_come];
            int vel = 0;
            for (int i = 0; i < array_X.Length;i++)
            {
                if (array_X[i] != 0 || Math.Abs(array_X[i]) > M)
                {
                    array_Y[vel] = array_X[i];
                    vel++;
                }
            }
             
            Console.WriteLine(" Your Array Y: ");
            for (int i = 0; i < array_Y.Length; i++)
            {
                Console.Write(array_Y[i] + ", ");
            }

        }
        
        public void StartTask()
        {
            int M = MInput();
            int not = Inicalisetion_X(M);
            Output_array_X();
            Inicalisetion_and_output_Y(not , M);
            Console.WriteLine(" Your M: " + M);
           
        }
    }
}
