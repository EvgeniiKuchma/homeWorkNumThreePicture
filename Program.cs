using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkNumThreePicture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int images = 52;
            int pictureInRow = 3;
            int filledRows = images / pictureInRow;
            int overImages = images % pictureInRow;

            Console.WriteLine($"Количество полных рядов картин равно " +
                $"{filledRows}, " +
                $"количество картин вне полного ряда {overImages}.");
        }
    }
}
