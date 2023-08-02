using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView.Model
{
    public class RandomNameGenerator
    {
        private Random random;

        public RandomNameGenerator()
        {
            random = new Random();
        }

        public string GenerateString(int length)
        {
            StringBuilder nameBuilder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                char randomLetter = (char)random.Next('A', 'Z' + 1);
                nameBuilder.Append(randomLetter);
            }

            return nameBuilder.ToString();
        }
    }
}
