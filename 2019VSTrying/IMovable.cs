using System;
using System.Collections.Generic;
using System.Text;

namespace _2019VSTrying
{
    interface IMovable
    {
        int PopulationDensity(); 
        int Population { get; set;  }
        double Area { get; set; }
        
    }
}
