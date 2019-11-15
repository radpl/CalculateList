using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateList
{
    public class IntegerList
    {

        private readonly int[] _arr;
        private readonly int count;
        private int min, max;
        private double sum, avg, stdev, variance, sumofsqrdiff;

        public int[] GetArray { get { return _arr; }}
        public string GetArrayString {get { return string.Join(",", _arr); }}
        public IntegerList(int[] arr)
        {
            _arr = arr;
            min = max = _arr[0];
            avg = stdev = variance = sumofsqrdiff = sum = 0;
            count = _arr.Length;
            CalculateStats();
        }

        public void CalculateStats()
        {
            //Calculate Min, Max and Sum
            foreach (var el in _arr)
            {
                if (el < min) min = el;
                if (el > max) max = el;
                sum += el;
            }
            //Calculate Avarage
            avg = sum / count;

            //Calculate Standard Deviation
            foreach (var el in _arr)
            {
                sumofsqrdiff += ((el - avg) * (el - avg));
            }
            variance = sumofsqrdiff / count;
            stdev = Math.Sqrt(variance);
        }

        public override string ToString()
        {
            //Print statistics
            return
                $"Max number is: {max:0.###},\n" +
                $"Min number is: {min:0.###},\n" +
                $"Average is: {avg:0.####},\n" +
                $"Std Deviation is: {stdev:0.####}";
        }
    }
}
