using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace SchoolPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "orange", "blue", "yellow", "purple", "green", "red" };

            var sixLetterColors = from color in colors
                                    where color.Count() == 6
                                    where color != "purple"
                                    select color.First();

            var anotherSixLetterColors = colors
                                         .Where(color => color.Count() == 6 && color != "purple")
                                         .Select(color => color.First());

            foreach (var color in sixLetterColors)
            {
                Console.WriteLine(color);
            }

            foreach (var color in anotherSixLetterColors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
