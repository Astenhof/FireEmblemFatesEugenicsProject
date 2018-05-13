using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireEmblemEugenics.Interfaces
{
    public interface IClassGrowthRates
    {
        double HPClassGrowth { get; }
        double StrengthClassGrowth { get; }
        double MagicClassGrowth { get; }
        double SkillClassGrowth { get; }
        double SpeedClassGrowth { get; }
        double LuckClassGrowth { get; }
        double DefenseClassGrowth { get; }
        double ResistanceClassGrowth { get; }
    }
}
