using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maslab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дан одномерный массив числовых значений, насчитывающий N элементов.Вставить группу из M новых элементов, начиная с позиции K.

            int arrnum, newnum, inspos;
            float[] arr, insarr;
            int[] buf;

            Console.Write("Введите число N элементов массива: ");
            arrnum = Convert.ToInt32(Console.ReadLine());
            arr = new float[arrnum];

            Console.Write("Введите массив: ");
            arr = Console.ReadLine().Split().Select(float.Parse).ToArray();

            Console.Write("Введите число M новых элементов и номер позиции K вставки новых элементов: ");
            buf = new int[2];
            buf = Console.ReadLine().Split().Select(int.Parse).ToArray();

            newnum = buf[0];
            insarr = new float[newnum];
            inspos = buf[1];

            Console.Write("Введите новые элементы: ");
            insarr = Console.ReadLine().Split().Select(float.Parse).ToArray();

            Array.Resize(ref arr, arrnum + newnum);
            Array.ConstrainedCopy(arr, inspos - 1, arr, inspos + newnum - 1, arrnum - inspos + 1);
            Array.ConstrainedCopy(insarr, 0, arr, inspos - 1, newnum);


            Console.WriteLine("Получившийся массив: ");
            for (int i = 0; i < arrnum + newnum; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
