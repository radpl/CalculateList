using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateList
{
    public class IntegerList
    {

        private readonly int[] _list;
        private int min, max, sum;

        public IntegerList(int[] list)
        {
            _list = list;
            min = max = _list[0];
            Calculate();
        }

        private void Calculate()
        {
            //Calculate Min, Max and Sum
            foreach (var el in _list)
            {
                if (el < min) min = el;
                if (el > max) max = el;
                sum += el;
            }
        }

        public override string ToString()
        {
            return string.Join(",", _list) + " " + min + " " + max + " " + sum ;
        }
    }
}
