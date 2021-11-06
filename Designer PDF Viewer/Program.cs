using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designer_PDF_Viewer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);
            Console.WriteLine(result);
        }
        static int designerPdfViewer(int[] h, string word)
        {
            List<int> lengths = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                lengths.Add(h[word[i] - 97]);
            }
            int max = lengths.Max();

            return word.Length * max;
        }
    }
}
