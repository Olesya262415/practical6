using System;
using System.Collections.Generic;
using System.Text;

namespace практическая_6
{
    public class GeometricProgression : IIndexableSeries
    {
        public double this[int index] => _start * Math.Pow(_step, index - 1);
        private double _start;
        private int _step;
        private double _current;
        public GeometricProgression(double start, int step)
        {
            _start = start;
            _step = step;
            _current = _start;
        }
        public double GetCurrent()
        {
            return _current;
        }
        public bool MoveNext()
        {
            _current = _current * _step;
            return true;
        }
        public void Reset()
        {
            _current = _start;
        }
    }
}
