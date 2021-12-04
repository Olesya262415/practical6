using System;
using System.Collections.Generic;
using System.Text;

namespace практическая_6
{
    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
