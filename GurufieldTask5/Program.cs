using System.Collections.Generic;

namespace GurufieldTask5
{
    class Program
    {
        static void Main()
        {
            var array = new List<string> {"red", "green", "yellow", "blue", "purple"};
            var newArray = ChangeStartingPoint(array, "purple");
        }

        private static IEnumerable<string> ChangeStartingPoint(List<string> array, string item)
        {
            var (startIndex, count) = (0, array.IndexOf(item));
            array.AddRange(array.GetRange(startIndex, count));
            array.RemoveRange(startIndex, count);
            return array;
        }
    }
}