using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistogramOCRTrainer.FEctra
{
    class ArrayExtras
    {

        public static T[][] InstantiateArray<T>(int width, int height) where T : new()
        {
            var ret = new T[height][];
            for (var y = 0; y < height; y++)
            {
                ret[y] = new T[width];
            }
            return ret;
        }

    }
}