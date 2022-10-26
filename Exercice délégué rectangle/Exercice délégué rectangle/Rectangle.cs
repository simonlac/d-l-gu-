using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_délégué_rectangle
{
    class Rectangle
    {
        private delegate void RectDelegate(int[] p_rectangle);
      


        p_rectangle = p_longueur + p_largeur
        private void TriAscendant2(int[] tableau)
        {
            Console.WriteLine("Tri ascendant...");
            Array.Sort(tableau);
            foreach (int i in tableau)
                Console.Write(i.ToString() + " ");
            Console.WriteLine("\n");
        }
        private void TriDescendant2(int[] tableau)
        {
            Console.WriteLine("Tri descendant...");
            Array.Sort(tableau);
            Array.Reverse(tableau);
            foreach (int i in tableau)
                Console.Write(i.ToString() + " ");
        }
        public void demotri4(int[] tableau)
        {
            Console.WriteLine("Multicast...\n");
            DelegateTri tri = TriAscendant2;
            tri += TriDescendant2;
            tri(tableau);


        }
    }


}
