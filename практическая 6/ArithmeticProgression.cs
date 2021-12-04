using System;
using System.Collections.Generic;
using System.Text;

namespace практическая_6
{
    public class ArithmeticProgression : IIndexableSeries
    {
        public double this[int index] => _start + (index - 1) * _step;
        private double _start;
        private int _step;
        private double _current;
        public ArithmeticProgression(double start, int step)
        {
            _start = start;
            _step = step;
            _current = start;
        }
        public double GetCurrent()
        {
            return _current;
        }
        public bool MoveNext()
        {
            _current = _current + _step;
            return true;
        }
        public void Reset()
        {
            _current = _start;
        }
    }
}
