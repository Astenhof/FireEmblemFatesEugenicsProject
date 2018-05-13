using FireEmblemEugenics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireEmblemEugenics.Data.Character_Stats.Hoshido
{
    public class Kaze : ACharacter
    {
        private IClass _class;

        public IClass Class
        {
            get { return _class; }
            set { _class = value; OnPropertyChanged(); }
        }

        public Kaze()
        {
            HPGrowth = 55;
            StrengthGrowth = 40;
            MagicGrowth = 0;
            SkillGrowth = 45;
            SpeedGrowth = 65;
            LuckGrowth = 20;
            DefenseGrowth = 20;
            ResistanceGrowth = 35;
        }
    }
}
