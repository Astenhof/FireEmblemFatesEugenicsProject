using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireEmblemEugenics.Data.Class_Stats.Hoshido
{
    public class Samurai : AClass
    {
        Samurai()
        {
            ClassName = "Samurai";
            HPClassGrowth = 10;
            StrengthClassGrowth = 10;
            MagicClassGrowth = 0;
            SkillClassGrowth = 15;
            SpeedClassGrowth = 20;
            LuckClassGrowth = 15;
            DefenseClassGrowth = 0;
            ResistanceClassGrowth = 10;
        }
    }
}
