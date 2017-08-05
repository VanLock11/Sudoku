using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Sudoku_Constructor
    {
        private int[,] arr = new int[9, 9];
        private Random rd = new Random();
        //list - array of numbers 1---9
        private List<int> list = new List<int>();
        private int[] a = new int[3];
        private int[] b = new int[3];
        private int[] c = new int[3];

        public Sudoku_Constructor()
        {
        }

        //Filling List
        private void InputList()
        {
            for (int i = 1; i <= 9; i++)
            {
                list.Add(i);
            }
        }

        //Array filling
        public void CreateSudoku()
        {
            InputList();
            for (int i = 0; i < 3; i++)
            {

                a[i] = list[rd.Next(0, list.Count - 1)];
                list.Remove(a[i]);
                b[i] = list[rd.Next(0, list.Count - 1)];
                list.Remove(b[i]);
                c[i] = list[rd.Next(0, list.Count - 1)];
                list.Remove(c[i]);

            }
            int k = 1;

            for (int i = 0; i < 9; i++)
            {
                if (i == 3 || i == 6)
                {
                    k = 1;
                }
                LoadStak(i, k++);
            }
        }

        //Filling an array line
        private void LoadStak(int _i, int k)
        {
            int _a = 0, _b = 0, _c = 0;

            switch (k)
            {
                case 1:
                    for (int j = 0; j < 9; j++)
                    {
                        arr[_i, j] = _a != 3 ? a[_a++] : _b != 3 ? b[_b++] : _c != 3 ? c[_c++] : 0;
                    }
                    break;
                case 2:
                    for (int j = 0; j < 9; j++)
                    {
                        arr[_i, j] = _b != 3 ? b[_b++] : _c != 3 ? c[_c++] : _a != 3 ? a[_a++] : 0;
                    }
                    break;
                case 3:
                    for (int j = 0; j < 9; j++)
                    {
                        arr[_i, j] = _c != 3 ? c[_c++] : _a != 3 ? a[_a++] : _b != 3 ? b[_b++] : 0;
                    }
                    break;
                default:
                    break;
            }
            if (k == 3)
            {
                Сastling();
            }
        }

        //Moving an array to 1 unit
        private void Сastling()
        {
            int t = a[0];
            a[0] = a[1];
            a[1] = a[2];
            a[2] = b[0];
            b[0] = b[1];
            b[1] = b[2];
            b[2] = c[0];
            c[0] = c[1];
            c[1] = c[2];
            c[2] = t;

        }
        //Output array sudoku
        public void Draw()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        //Array zeroing  
        public void Zeroing()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = 0;
                }
            }
        }

    }
}
