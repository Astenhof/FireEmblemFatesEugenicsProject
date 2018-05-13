using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireEmblemEugenics.Data.Class_Stats.Hoshido
{
    public class Ninja : AClass
    {
        Ninja()
        {
            ClassName = "Ninja";
            HPClassGrowth = 5;
            StrengthClassGrowth = 5;
            MagicClassGrowth = 0;
            SkillClassGrowth = 20;
            SpeedClassGrowth = 20;
            LuckClassGrowth = 0;
            DefenseClassGrowth = 5;
            ResistanceClassGrowth = 15;
        }
    }
}
