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
            int totalNumberOfPicture = 52;
            int numberOfPictureInARow = 3;
            int numberOfFilledRows = totalNumberOfPicture / numberOfPictureInARow;
            int PicturesOverARow = totalNumberOfPicture % numberOfPictureInARow;

            Console.WriteLine($"Количество полных рядов картин равно " +
                $"{numberOfFilledRows}, " +
                $"количество картин вне полного ряда {PicturesOverARow}.");
        }
    }
}
