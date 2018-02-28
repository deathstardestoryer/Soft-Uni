using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        var initialInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int numberOfRectangles = initialInput[0];
        int numberOfIntersections = initialInput[1];
        var allRectangles = new List<Rectangle>();

        for (int i = 0; i < numberOfRectangles; i++)
        {
            var separated = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            allRectangles.Add(new Rectangle(separated[0], double.Parse(separated[1]), double.Parse(separated[2]), double.Parse(separated[3]), double.Parse(separated[4])));
        }
        var pairsToIntersect = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
        var rectangle1 = allRectangles.Where(r => r.id == pairsToIntersect[0]).ToList();
        var rectangle2 = allRectangles.Where(r => r.id == pairsToIntersect[1]).ToList();
        


    }
   
    }

