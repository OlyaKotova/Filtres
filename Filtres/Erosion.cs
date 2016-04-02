using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filtres
{
    class Erosion : FewFiltres
    {
        public bool[,] kernel;

        public Erosion()

        {
            int sizeM = 3;
            bool[,] kernel = new bool[sizeM, sizeM];
            this.kernel = kernel;
            kernel[0, 0] = false; kernel[0, 1] = true; kernel[0, 2] = false;
            kernel[1, 0] = true; kernel[1, 1] = true; kernel[1, 2] = true;
            kernel[2, 0] = false; kernel[2, 1] = true; kernel[2, 2] = false;
        }
    }
        
}
