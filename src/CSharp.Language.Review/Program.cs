using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Language.Review
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Program app = new Program(args);

            app.AssignMarks(30, 80);

        }
    }
}
