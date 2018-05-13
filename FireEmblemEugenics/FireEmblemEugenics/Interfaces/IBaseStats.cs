using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireEmblemEugenics.Interfaces
{
    public interface IBaseStats
    {
        string Name { get; }
        double HP { get; }
        double Strength { get; }
        double Magic { get; }
        double Skill { get; }
        double Speed { get; }
        double Luck { get; }
        double Defense { get; }
        double Resistance { get; }
    }
}
