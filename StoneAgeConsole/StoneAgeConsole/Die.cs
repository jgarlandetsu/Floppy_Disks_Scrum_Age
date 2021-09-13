using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneAgeConsole
{
    class Die
    {
        List<String> DiceFaces = new List<string>();
        String Face;

        public Die(Random r1)
        {
            MakeDieFaces();
            AssignFace(r1);
            PrintDie();
        }

        public void MakeDieFaces()
        {
            DiceFaces.Add(" _________ \n|         |\n|         |\n|    X    |\n|         |\n|_________|\n");
            DiceFaces.Add(" _________ \n|         |\n|  X      |\n|         |\n|      X  |\n|_________|\n");
            DiceFaces.Add(" _________ \n|         |\n|  X      |\n|    X    |\n|      X  |\n|_________|\n");
            DiceFaces.Add(" _________ \n|         |\n|  X   X  |\n|         |\n|  X   X  |\n|_________|\n");
            DiceFaces.Add(" _________ \n|         |\n|  X   X  |\n|    X    |\n|  X   X  |\n|_________|\n");
            DiceFaces.Add(" _________ \n|         |\n|  X   X  |\n|  X   X  |\n|  X   X  |\n|_________|\n");
        }

        public void AssignFace(Random r2)
        {
            Face = DiceFaces[r2.Next(6)];
        }

        public void PrintDie()
        {
            Console.Write(Face);
        }
    }
}
