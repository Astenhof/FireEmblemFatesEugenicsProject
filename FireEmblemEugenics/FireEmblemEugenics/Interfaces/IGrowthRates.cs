using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireEmblemEugenics.Interfaces
{
    public interface IGrowthRates
    {
        double HPGrowth { get; }
        double StrengthGrowth { get; }
        double MagicGrowth { get; }
        double SkillGrowth { get; }
        double SpeedGrowth { get; }
        double LuckGrowth { get; }
        double DefenseGrowth { get; }
        double ResistanceGrowth { get; }
    }
}
