using System;
using System.Collections.Generic;
using System.Text;

namespace практическая_6
{
    public interface IIndexable
    {
        double this[int index] { get; }
    }
}
