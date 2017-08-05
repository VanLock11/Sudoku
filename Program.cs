using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            Sudoku_Constructor s = new Sudoku_Constructor();
            s.Draw();
            Console.WriteLine();
            s.CreateSudoku();
            s.Draw();
            Console.ReadKey();
        }
    }
}
